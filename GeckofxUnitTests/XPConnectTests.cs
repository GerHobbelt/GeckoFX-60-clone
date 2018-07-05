using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.DOM.Svg;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class XPConnectTests
	{
		nsIXPConnect m_instance;

		private GeckoWebBrowser _browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			// defined in nsIXPConent.idl
			// CB6593E0-F9B2-11d2-BDD6-000064657374
			var ptr = (IntPtr)Xpcom.GetService(new Guid("CB6593E0-F9B2-11d2-BDD6-000064657374"));
			Assert.IsNotNull(ptr);
			m_instance = (nsIXPConnect)Xpcom.GetObjectForIUnknown(ptr);
			Assert.IsNotNull(m_instance);

			_browser = new GeckoWebBrowser();
			var unused = _browser.Handle;
			Assert.IsNotNull(_browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}
	}
}
