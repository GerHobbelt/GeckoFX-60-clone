using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko.DOM;
using GeckofxUnitTests.dom;
using NUnit.Framework;

namespace GeckofxUnitTests
{
    [TestFixture]
    class GeckoFormElementTests : BaseElementWrapperTests
    {
        [Test]
        public void Action_ActionContainsLink_ReturnsLink()
        {
            string form = "<form action='/action_page.php' id='myid'>First name:< br ></form>";
            _browser.TestLoadHtml(form);

            var formElement = (GeckoFormElement)_browser.Document.GetElementById("myid");

            Assert.AreEqual("file:///action_page.php", formElement.Action);
        }
    }
}
