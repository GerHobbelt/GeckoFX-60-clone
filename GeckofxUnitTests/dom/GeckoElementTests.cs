using Gecko;
using Gecko.DOM;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture]
    class GeckoElementTests : BaseElementWrapperTests
    {
        [TestCase("hello", "hello")]
        [TestCase("", "")]
        [TestCase(null, ""), Description(@"This goes against standard browser behaviour but its how geckofx used to work:
This is the standard behavior:
document.body.setAttribute('test', null)
undefined
document.body.getAttribute('test')
'null'

attribute store the toString of an object, rather then the object itself.
For geckofx we special case null SetAttribute(.., null) to mean remove attribute.
")]
        public void SetAttribute_VariousValues_GetAttributeReturnsWhatSetAttributeSet(string val, string expected)
        {
            string div = "<div id='myid' />";
            _browser.TestLoadHtml(div);
            var divElement = _browser.Document.GetElementById("myid");

            divElement.SetAttribute("somename", val);

            Assert.AreEqual(expected, divElement.GetAttribute("somename"));
        }

        [TestCase("", "")]
        [TestCase("=2", "2")]
        [TestCase("=null", "null")]
        [TestCase("='null'", "null")]
        public void GetAttribute(string attributeAssignment, string expectedResult)
        {
            string div = $"<div id='myid' test{attributeAssignment} />";
            _browser.TestLoadHtml(div);
            var divElement = _browser.Document.GetElementById("myid");

            Assert.AreEqual(expectedResult, divElement.GetAttribute("test"));
        }

        [Test]
        public void GetAttribute_ValueSetToNullViaJavascript_ReturnsTheToStringOfNull()
        {
            string div = $"<div id='myid' test='inital' />";
            _browser.TestLoadHtml(div);

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("document.getElementById('myid').setAttribute('test', null);", out result));

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
                Assert.AreEqual("hello world", result);
            }

            var divElement = _browser.Document.GetElementById("myid");

            Assert.AreEqual("null", divElement.GetAttribute("test"));
        }
    }
}
