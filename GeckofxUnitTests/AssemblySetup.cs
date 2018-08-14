using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using Gecko;
using GeckofxUnitTests;
using NUnit.Framework;


[assembly: Parallelizable(ParallelScope.None)]
[assembly: Apartment(ApartmentState.STA)]

/// <summary>
/// This class is intentially not in a namespace
/// as it provides per assembly setup.
/// </summary>
[Apartment(ApartmentState.STA)]
[SetUpFixture]
public class MySetUpClass
{
    [OneTimeSetUp]
    public void RunBeforeAnyTestInAssembly()
    {
#if !DEBUG
        if (Xpcom.IsWindows && Xpcom.Is32Bit)
        {
            var proc = System.Diagnostics.Process.GetCurrentProcess();
            var assembly = Assembly.LoadFrom(proc.MainModule.FileName);

            if (!IsLargeAware(assembly.Location))
                Assert.Fail($"Tests are not running in LargeAddressAware environment. Run \"%VS140COMNTOOLS%..\\..\\VC\\bin\\editbin\" /LARGEADDRESSAWARE {assembly.Location}");
        }
#endif

        // Run all these tests using a turkish locale
        var ci = new CultureInfo("tr-TR");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        // Needed when single unittests are run
        var xulrunnerPath = XpComTests.XulRunnerLocation;
        xulrunnerPath = @"C:\mozilla-release\obj-i686-pc-mingw32\dist\bin";
        Xpcom.Initialize(xulrunnerPath);
    }

    [OneTimeTearDown]
    public void RunAfterTestsInAssembly()
    {

    }

    /// <summary>
    /// https://stackoverflow.com/a/9056757/361714
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    static bool IsLargeAware(string file)
    {
        using (var fs = File.OpenRead(file))
        {
            return IsLargeAware(fs);
        }
    }
    /// <summary>
    /// Checks if the stream is a MZ header and if it is large address aware
    /// </summary>
    /// <param name="stream">Stream to check, make sure its at the start of the MZ header</param>
    /// <exception cref=""></exception>
    /// <returns></returns>
    static bool IsLargeAware(Stream stream)
    {
        const int IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x20;

        var br = new BinaryReader(stream);

        if (br.ReadInt16() != 0x5A4D)       //No MZ Header
            return false;

        br.BaseStream.Position = 0x3C;
        var peloc = br.ReadInt32();         //Get the PE header location.

        br.BaseStream.Position = peloc;
        if (br.ReadInt32() != 0x4550)       //No PE header
            return false;

        br.BaseStream.Position += 0x12;
        return (br.ReadInt16() & IMAGE_FILE_LARGE_ADDRESS_AWARE) == IMAGE_FILE_LARGE_ADDRESS_AWARE;
    }
}
