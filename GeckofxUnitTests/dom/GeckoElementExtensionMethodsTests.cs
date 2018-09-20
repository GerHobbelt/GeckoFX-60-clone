using System;
using System.IO;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture]
    class GeckoElementExtensionMethodsTests : BaseElementWrapperTests
    {
        [Test]
        public void GetBoundingClientRect_SimpleExample_ReturnsARect()
        {
            string div = @"<div>before<div id='myid'><div>hello</div> world</div>after</div>";
            _browser.TestLoadEditableHtml(div);
            var divElement = _browser.Document.GetElementById("myid");

            var rect = divElement.GetBoundingClientRect();
            Assert.NotNull(rect);
            Assert.Greater(rect.Height, 0);
            Assert.Greater(rect.Width, 0);
        }
    }
}
