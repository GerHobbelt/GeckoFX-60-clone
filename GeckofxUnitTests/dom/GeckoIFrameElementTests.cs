using System;
using System.IO;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    [TestFixture]
    class GeckoIFrameElementTests : BaseElementWrapperTests
    {

        [Test]
        public void Align_GetAndSet()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.Align);
                frameElement.Align = "somethingelse";
                Assert.AreEqual("somethingelse", frameElement.Align);
            }
        }

        [Test]
        public void FrameBorder_GetAndSet()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.FrameBorder);
                frameElement.FrameBorder = "somethingelse";
                Assert.AreEqual("somethingelse", frameElement.FrameBorder);
            }
        }

        [Test]
        public void Height_GetAndSet()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.Height);
                frameElement.Height = "somethingelse";
                Assert.AreEqual("somethingelse", frameElement.Height);
            }
        }

        [Test]
        public void LongDesc_Get()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.LongDesc);
            }
        }

        [Test]
        public void MarginHeight_GetAndSet()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.MarginHeight);
                frameElement.MarginHeight = "somethingelse";
                Assert.AreEqual("somethingelse", frameElement.MarginHeight);
            }
        }

        [Test]
        public void MarginWidth_GetAndSet()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.MarginWidth);
                frameElement.MarginWidth = "somethingelse";
                Assert.AreEqual("somethingelse", frameElement.MarginWidth);
            }
        }

        [Test]
        public void Name_GetAndSet()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(String.Empty, frameElement.Name);
                frameElement.Name = "somethingelse";
                Assert.AreEqual("somethingelse", frameElement.Name);
            }
        }

        [Test]
        public void ContentDocument_Get()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(TestIFrameHelper.InnerFrameHtml, frameElement.ContentDocument.Body.InnerHtml);
            }
        }

        [Test]
        public void ContentWindow_Get()
        {
            using (new TestIFrameHelper(_browser))
            {
                var frameElement = (GeckoIFrameElement)_browser.Document.GetElementById("myid");
                Assert.AreEqual(TestIFrameHelper.InnerFrameHtml, ((GeckoHtmlElement)frameElement.ContentWindow.Document.DocumentElement.LastChild).InnerHtml);
            }
        }
    }

    #region helper classes

    /// <summary>
    /// Create a test iframe setup. IFrame element has id of 'myid'
    /// </summary>
    public class TestIFrameHelper : IDisposable
    {
        private readonly GeckoWebBrowser _browser;
        const string innerFrameHtml = "<b>hello world</b>";
        private readonly string _filename;
        private readonly string _filenameFrame;

        public TestIFrameHelper(GeckoWebBrowser browser)
        {
            _browser = browser;
            _filename = Path.GetTempFileName() + ".html";
            _filenameFrame = Path.GetTempFileName() + ".html";

            File.WriteAllText(_filename,
                   $"<!DOCTYPE html>\r\n<html>\r\n<body>\r\n\r\n<iframe id='myid' src=\"file://{_filenameFrame}\">\r\n  <p>Your browser does not support iframes.</p>\r\n</iframe>\r\n\r\n</body>\r\n</html>\r\n");

            File.WriteAllText(_filenameFrame, InnerFrameHtml);

            _browser.Navigate(_filename);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
        }

        public static string InnerFrameHtml => innerFrameHtml;

        public void Dispose()
        {
            File.Delete(_filename);
            File.Delete(_filenameFrame);
        }
    }

    #endregion
}
