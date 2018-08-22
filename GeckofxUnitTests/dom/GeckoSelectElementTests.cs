using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko.DOM;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture]
    class GeckoSelectElementTests : BaseElementWrapperTests
    {
        [Test]
        public void SelectedIndex_ReturnsIndex()
        {
            string select = @"<select id='myid' >
  <option value=""volvo"">Volvo</option>
  <option value=""saab"">Saab</option>
  <option value=""mercedes"">Mercedes</option>
  <option value=""audi"">Audi</option>
</select> ";
            _browser.TestLoadHtml(select);
            var selectElement = (GeckoSelectElement)_browser.Document.GetElementById("myid");

            Assert.AreEqual(0, selectElement.SelectedIndex);
        }

        [Test]
        public void Add_ANewOptionToSelectElementBeforeFirstElement_OptionGetsAdded()
        {
            string select = @"<select id='myid' >
  <option value=""volvo"">Volvo</option>
  <option value=""saab"">Saab</option>
  <option value=""mercedes"">Mercedes</option>
  <option value=""audi"">Audi</option>
</select>";
            _browser.TestLoadHtml(select);
            var selectElement = (GeckoSelectElement)_browser.Document.GetElementById("myid");            
            Assert.AreEqual(4, selectElement.Length);
            Assert.AreEqual("volvo", selectElement.Options.Item(0).Value);

            var option = (GeckoOptionElement)_browser.Document.CreateElement("option");
            option.Value = "hi";
            option.Label = "hello";
            selectElement.Add(option, selectElement.Options.Item(0));

            Assert.AreEqual(5, selectElement.Length);
            Assert.AreEqual("hi", selectElement.Options.Item(0).Value);
            Assert.AreEqual("hello", selectElement.Options.Item(0).Label);
        }

        [Test]
        public void Add_ANewOptionToSelectElementNotSpecifyingBefore_OptionGetsAdded()
        {
            string select = @"<select id='myid' >
  <option value=""volvo"">Volvo</option>
  <option value=""saab"">Saab</option>
  <option value=""mercedes"">Mercedes</option>
  <option value=""audi"">Audi</option>
</select>";
            _browser.TestLoadHtml(select);
            var selectElement = (GeckoSelectElement)_browser.Document.GetElementById("myid");
            Assert.AreEqual(4, selectElement.Length);
            Assert.AreEqual("volvo", selectElement.Options.Item(0).Value);
            var option = (GeckoOptionElement)_browser.Document.CreateElement("option");
            option.Value = "hi";
            option.Label = "hello";

            selectElement.Add(option);

            Assert.AreEqual(5, selectElement.Length);
            Assert.AreEqual("hi", selectElement.Options.Item(4).Value);
            Assert.AreEqual("hello", selectElement.Options.Item(4).Label);
        }
    }
}
