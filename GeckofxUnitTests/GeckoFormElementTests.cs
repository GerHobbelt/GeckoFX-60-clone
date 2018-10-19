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

		[Test]
		public void AccessProperty_AccessingPropertyThatIsNotDefined_ShouldNotCauseError()
		{
			_browser.LoadHtml("<html><body><form id=f><input id=i></form></body></html>");
			_browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			((Gecko.GeckoHtmlElement)_browser.Document.GetElementById("i")).Focus();

			var actElem = (GeckoInputElement)_browser.Document.ActiveElement;
			Assert.AreEqual(actElem.Form.Action, "file:///");
		}
	}
}
