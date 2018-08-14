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
    }
}
