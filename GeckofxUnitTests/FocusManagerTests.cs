using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class FocusManagerTests
	{
		nsIFocusManager m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.CreateInstance<nsIFocusManager>("@mozilla.org/focus-manager;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

        [Ignore("This hangs in FF60")]
		[Test]
		public void GetLastFocusMethod_OfStubbedDOMWindow_ReturnsZero()
		{
			var stubDOMWindow = new StubDOMWindow();
			Assert.AreEqual(0, m_instance.GetLastFocusMethod(stubDOMWindow));			
		}

		[Test]
		public void GetActiveWindowAttribute_ActiveWindowIsNull_ReturnsNull()
		{			
			Assert.IsNull(m_instance.GetActiveWindowAttribute());
		}
	}

	#region Stubs
	internal class StubDOMWindow : mozIDOMWindowProxy
	{		

	}
	#endregion
}