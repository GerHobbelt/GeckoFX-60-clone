using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko.DOM;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture()]
    class GeckoScriptElementTests : BaseElementWrapperTests
    {
        [Test]
        public void Src_SrcSpecified_ReturnsSpecifiedSrc()
        {
            _browser.TestLoadHtml("<script src='file:///unknownfile.js'>let a = 2 + 3; console.log(a);</script>");
            var objectUnderTest = _browser.Document.Body.FirstChild as GeckoScriptElement;
            Assert.NotNull(objectUnderTest);

            Assert.AreEqual("file:///unknownfile.js", objectUnderTest.Src);
        }

        [Test]
        public void Type_StandardType_ReturnsType()
        {
            _browser.TestLoadHtml("<script type='text/javascript'>let a = 2 + 3; console.log(a);</script>");
            var objectUnderTest = _browser.Document.Body.FirstChild as GeckoScriptElement;
            Assert.NotNull(objectUnderTest);

            Assert.AreEqual("text/javascript", objectUnderTest.Type);
        }

        [Test]
        public void Text_InlineScript_ReturnsScriptContents()
        {
            var testScript = "let a = 2 + 3; console.log(a);";
            _browser.TestLoadHtml($"<script>{testScript}</script>");
            var objectUnderTest = _browser.Document.Body.FirstChild as GeckoScriptElement;
            Assert.NotNull(objectUnderTest);

            Assert.AreEqual(testScript, objectUnderTest.Text);
        }
    }
}
