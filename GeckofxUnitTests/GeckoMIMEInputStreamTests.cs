using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.IO;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class GeckoMIMEInputStreamTests
	{
		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{

		}

		/// <summary>
		/// This is for unit tests only.
		/// </summary>
		/// <param name="stream"></param>
		/// <returns></returns>
		internal string ReadGeckoMIMEInputStreamAsUTF8(MimeInputStream stream)
		{
			byte[] buffer = new byte[2048];
			var count = stream.Read(buffer,0, 2048);

			return System.Text.UTF8Encoding.UTF8.GetString(buffer).Trim();
		}

		[Test]
		public void SetData_SimpleData_HeaderContainsSimpleData()
		{
			MimeInputStream stream = MimeInputStream.Create();
			string simpleData = "id=hello";
			stream.SetData(simpleData);

			Assert.IsTrue(ReadGeckoMIMEInputStreamAsUTF8(stream).Contains(simpleData));			
		}
	}
}