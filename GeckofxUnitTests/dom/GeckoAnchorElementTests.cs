using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using Gecko.DOM;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture]
    class GeckoAnchorElementTests
    {
        private GeckoWebBrowser _browser;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            _browser = new GeckoWebBrowser();
            var unused = _browser.Handle;
            Assert.IsNotNull(_browser);
        }

        [Test]
        public void Href_AnchorContainsNormalLink_LinkIsReturnedByHref()
        {
            string anchor = "<a href='https://www.somelink.com' id='myid' class='none'>link</a>";
            _browser.TestLoadHtml(anchor);
            var anchorElement = (GeckoAnchorElement) _browser.Document.GetElementById("myid");

            Assert.AreEqual("https://www.somelink.com/", anchorElement.Href);
        }
    }
}
