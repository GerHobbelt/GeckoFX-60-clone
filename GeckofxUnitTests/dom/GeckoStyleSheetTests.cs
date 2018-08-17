using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture]
    class GeckoStyleSheetTests : BaseElementWrapperTests
    {
        [Test]
        public void CssRules_Enumerate_DoesNotThrowException()
        {
            _browser.Navigate("www.google.com");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();


            GeckoStyleSheet styleSheet = _browser.Document.StyleSheets.First();
            foreach (var rule in styleSheet.CssRules)
            {
                Assert.NotNull(rule);
                Assert.DoesNotThrow(() => { var unused = rule.CssText; });
                Assert.DoesNotThrow(() => { var unused = rule.StyleCssText; });
            }
        }

        [Test]
        public void OwnerNode()
        {
            _browser.Navigate("www.google.com");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();


            GeckoStyleSheet styleSheet = _browser.Document.StyleSheets.First();
            var ownerNode = styleSheet.OwnerNode;

            Assert.AreEqual("STYLE", ownerNode.NodeName);
        }
    }
}
