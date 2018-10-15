using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Events;
using Gecko.JQuery;

namespace GeckofxUnitTests
{
    [TestFixture]
    internal class GeckoWebBrowserTests
    {
        private GeckoWebBrowser _browser;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            Xpcom.Initialize(XpComTests.XulRunnerLocation);
            //affecting browser.Realod()/GoForward()/GoBackward() of error page
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;
            var f = new Form();
            
            _browser = new GeckoWebBrowser();
            _browser.Dock = DockStyle.Fill;
            f.Controls.Add(_browser);
            f.Show();
        }

        [TearDown]
        public void AfterEachTestTearDown()
        {
            _browser.Dispose();
        }


        public static string errorMessage = null;

        private class TestGeckoWebBrowser : GeckoWebBrowser
        {
            protected override void Dispose(bool disposing)
            {
                if (disposing == false)
                {
                    var currentThread = System.Threading.Thread.CurrentThread;
                    errorMessage = String.Format("Disposed called by GC {0} {1}", currentThread.ManagedThreadId, currentThread.ApartmentState);
                    Console.WriteLine(errorMessage);
                }

                base.Dispose(disposing);
            }
        }

        [Test]
        public void MissingDisposeTest_ControlIsNotYetCreated_DoesNotThrowExceptions()
        {
            WeakReference reference = null;
            new Action(() =>
            {
                var nonDisposedBrowser = new TestGeckoWebBrowser();

                reference = new WeakReference(nonDisposedBrowser, true);
            })();

            for (var i = 5; i >= 0; i--)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            Assert.IsNull(reference.Target, "Weak ref hasn't been released rendering this test meaningless");
            Assert.IsTrue(errorMessage.Contains("Disposed called by"));
        }

        [Test]
        public void LoadHtml_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
        {
            string innerHtml = "<div id=\"_lv5\">old value</div>";

            _browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

                             + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

                             + "<body>" + innerHtml + "</body></html>");

            _browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
                                                                     {
                                                                         Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);
                                                                     };

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();


            Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);
        }

        [Test]
        public void LoadHtmlInUrl_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
        {
            string innerHtml = "<div id=\"_lv5\">old value</div>";
            string url = "http://mydomain.myzone/";

            _browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

                             + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

                             + "<body>" + innerHtml + "</body></html>", url);

            _browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
            {
                Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);
            };

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(innerHtml, _browser.Document.Body.InnerHtml);

            Assert.AreEqual(url, _browser.Url.AbsoluteUri);
        }

        public class TestCallback : nsITextInputProcessorCallback
        {
            public bool OnNotify(nsITextInputProcessor aTextInputProcessor, nsITextInputProcessorNotification aNotification)
            {
                Console.WriteLine("TestCallback:OnNotify");
                return true;
            }
        }

        [Test]
        public void DomContentChanged_ChangeContentOfTextInputWithKeyPressAndMoveToSecondInput_DomContentChangedShouldFire()
        {
            string html = "<input id=\"one\" type=\"text\" value=\"hello\" /><input id=\"two\" type=\"text\"  value=\"world\" />";
            _browser.TestLoadHtml(html);

            // Place browser on a form and show it. This is need to make the gecko accept the key press.
            Form f = new Form();
            f.Controls.Add(_browser);
            _browser.Visible = true;
            f.Show();

            // Focus first input box
            _browser.Document.GetHtmlElementById("one").Focus();
            GeckoRange range = _browser.Document.CreateRange();
            range.SelectNode(_browser.Document.GetHtmlElementById("one"));
            _browser.Window.Selection.AddRange(range);

            // record if DomContentChanged event happened.
            bool contentChangedEventReceived = false;
            _browser.DomContentChanged += (sender, e) => contentChangedEventReceived = true;


            // Modify first input by sending a keypress.
            // This could be refactored but at least it shows how to invoke a keypress using nsITextInputProcessor
            var instance = Xpcom.CreateInstance<nsITextInputProcessor>("@mozilla.org/text-input-processor;1");
            using (var context = new AutoJSContext(_browser.Window))
            {
                var result = context.EvaluateScript(
                    @"new KeyboardEvent('', { key: 'a', code: 'KeyA', keyCode: KeyboardEvent.DOM_VK_A });");
                instance.BeginInputTransaction((mozIDOMWindow) _browser.Document.DefaultView.DomWindow, new TestCallback());
                nsString.Set(instance.SetPendingCompositionString, "hi");
                instance.Keyup((nsIDOMEvent)result.ToComObject(context.ContextPointer), 0, 1);
                result = context.EvaluateScript(
                    @"new KeyboardEvent('', { key: 'Enter', code: 'Enter' });");
                instance.FlushPendingComposition(null, 0, 2);
                instance.CommitComposition((nsIDOMEvent)result.ToComObject(context.ContextPointer), 0, 2);
            }

            // DomContentChanged Event should fire when we move we move to next element.
            _browser.Document.GetHtmlElementById("two").Focus();
            range.SelectNode(_browser.Document.GetHtmlElementById("two"));
            _browser.Window.Selection.RemoveAllRanges();
            _browser.Window.Selection.AddRange(range);

            Assert.IsTrue(contentChangedEventReceived);
        }

        [Test]
        public void LoadFrameset_RegressionTest_ShouldNotThrowException()
        {
            string innerHtml = "<frame src=\"www.google.com\">";
            _browser.TestLoadFrameset(innerHtml);
            var frame = _browser.Document.GetElementsByTagName("frame")[0] as GeckoFrameElement;
            Assert.NotNull(frame);
            Assert.NotNull(frame.ContentWindow);
        }

        [Test]
        public void Editor_LoadedReadonlyocument_ReturnsNull()
        {
            _browser.TestLoadHtml("hello world.");
            Assert.Null(_browser.Editor);
        }

        [Test]
        public void Editor_LoadedEditableDocument_ReturnsNonNull()
        {
            _browser.TestLoadEditableHtml("hello world.");
            Assert.NotNull(_browser.Editor);
        }

        [Ignore("JavascriptError need refactoring to the new system (in gecko 33+)")]
        [Platform("Win")]
        [Test]
        public void JavascriptError_NaviagateWithSomeJavascriptThatThrowsException_AttachedEventHandlerShouldExecute()
        {
            List<JavascriptErrorEventArgs> errorEventArgs = new List<JavascriptErrorEventArgs>();

#if PORT
			browser.JavascriptError += (object sender, JavascriptErrorEventArgs e) => errorEventArgs.Add(e);
#endif

            _browser.Navigate("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");");

            Application.DoEvents();

            Assert.AreEqual(2, errorEventArgs.Count);
            Assert.AreEqual("someRandomFunctionNameThatDoesNotExist is not defined", errorEventArgs[0].Message);
            Assert.AreEqual("ReferenceError: someRandomFunctionNameThatDoesNotExist is not defined", errorEventArgs[1].Message);

            Assert.AreEqual(1, errorEventArgs[0].ErrorNumber);
            Assert.AreEqual(1, errorEventArgs[1].ErrorNumber);

            Assert.AreEqual(1, errorEventArgs[0].Line);
            Assert.AreEqual(1, errorEventArgs[1].Line);

            Assert.AreEqual("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");", errorEventArgs[0].Filename);
            Assert.AreEqual("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");", errorEventArgs[1].Filename);

            Assert.AreEqual(ErrorFlags.REPORT_EXCEPTION, errorEventArgs[0].Flags);
            Assert.AreEqual(ErrorFlags.REPORT_EXCEPTION, errorEventArgs[1].Flags);

            Assert.AreEqual(0, errorEventArgs[0].Pos);
            Assert.AreEqual(0, errorEventArgs[1].Pos);
        }

        [Test]
        public void ConsoleMessage_NavigateWithSomeInvalidCss_AttachedEventHandlerShouldExecute()
        {
            ConsoleMessageEventArgs eventArgs = null;

            EventHandler<ConsoleMessageEventArgs> eventHandler = (object sender, ConsoleMessageEventArgs e) => eventArgs = e;
            _browser.ConsoleMessage += eventHandler;

            string html = "<p style=\"background: bluse; color: white;\">hello</p>";
            _browser.TestLoadHtml(html);

            _browser.ConsoleMessage -= eventHandler;

            Assert.NotNull(eventArgs);
            Assert.IsNotEmpty(eventArgs.Message);
            // Error messages changes based upon locale. (color/colour)
            Assert.IsTrue(eventArgs.Message.Contains(@"JavaScript Warning: ""Error in parsing value for ‘background’.  Declaration dropped."), eventArgs.Message);
        }

        [Test]
        public void AddMessageEventListener_JScriptFiresEvent_ListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void AddMessageEventListener_CalledTwice_LatestListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.AddMessageEventListener("callMe", p => payload = "newone " + p);

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual("newone some data", payload);
        }

        [Test]
        public void RemoveMessageEventListener_JScriptFiresEvent_ListenerIsNotCalled()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.RemoveMessageEventListener("callMe");

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(null, payload);
        }

        [Test]
        public void AddMessageEventListener_JScriptFiresEventUsingJQueryExecutor_ListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.AddMessageEventListener("callMe", p => payload = p);

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>No Content
			                
							</head><body></body></html>");

            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            var javaScript = @"var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent(event);";
            var executor = new JQueryExecutor(_browser.Window);

            executor.ExecuteJQuery(javaScript);

            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void AddMessageEventListener_JScriptFiresEventAfterNavigatedToAnotherPage_ListenerIsCalledWithMessage()
        {
            string payload = null;

            _browser.LoadHtml(
                @"<!DOCTYPE html>
			                 <html><head>No Content
			                
							</head><body></body></html>");



            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.Navigate("about:blank");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            var javaScript = @"var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent(event);";
            var executor = new JQueryExecutor(_browser.Window);

            executor.ExecuteJQuery(javaScript);

            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void AddMessageEventListener_NavigatingToSeveralPages_ListenerIsReattachedAndCalledWithMessage()
        {
            string payload = null;

            var document = @"<!DOCTYPE html><html><head>No Content</head><body></body></html>";

            _browser.AddMessageEventListener("callMe", p => payload = p);
            _browser.LoadHtml(document);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            _browser.LoadHtml(document);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            var javaScript = @"var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent(event);";
            var executor = new JQueryExecutor(_browser.Window);

            executor.ExecuteJQuery(javaScript);

            Assert.AreEqual("some data", payload);
        }

        [Test]
        public void EvaluateScript_SimpleJavascript_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml("");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
                Assert.AreEqual(5, int.Parse(result));

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
                Assert.AreEqual("hello world", result);
            }
        }

        [Test]
        public void EvaluateScript_UnicodeJavascript_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml("");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;

                Assert.IsTrue(context.EvaluateScript("'文';", out result));
                Assert.AreEqual("文"[0], result[0]);

                Assert.IsTrue(context.EvaluateScript("'a\0a';", out result));
                Assert.AreEqual("a", result);

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + '中\0文';", out result));
                Assert.AreEqual("hello 中", result);

            }
        }

        [Test]
        public void EvaluateScript_SimpleJavascriptWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
        {
            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
                Assert.AreEqual(5, Int32.Parse(result));

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
                Assert.AreEqual("hello world", result);
            }
        }

        [Test]
        public void EvaluateScript_JavascriptAccessExistingGlobalObjects_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml("hello world");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                Assert.IsTrue(context.EvaluateScript("this", (nsISupports)_browser.Window.DomWindow, out result));
                Assert.AreEqual("[object Window]", result);

                Assert.IsTrue(context.EvaluateScript("this", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("[object HTMLDocument]", result);

                Assert.IsTrue(context.EvaluateScript("this.defaultView", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("[object Window]", result);

                Assert.IsTrue(context.EvaluateScript("this.body.innerHTML;", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("hello world", result);

                Assert.IsTrue(context.EvaluateScript("this.body.innerHTML = 'hi';", (nsISupports)_browser.Document.DomObject, out result));
                Assert.IsTrue(context.EvaluateScript("this.body.innerHTML;", (nsISupports)_browser.Document.DomObject, out result));
                Assert.AreEqual("hi", result);

                Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
                Assert.AreEqual("200", result);
            }
        }

        [Test]
        public void EvaluateScript_JavascriptAccessExistingGlobalObjectsWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
        {
            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                var ret = context.EvaluateScript("this", _browser.Window.DomWindow);
                Assert.IsFalse(ret.IsUndefined);
                Assert.AreEqual("[object Window]", ret.ToString());

                var execption = Assert.Throws<GeckoJavaScriptException>(() => context.EvaluateScript("body.innerHTML;", _browser.Window.DomWindow));
                Assert.AreEqual("JSError : ReferenceError: body is not defined StackTrace: @script:1:1\n", execption.Message);

                Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
                Assert.AreEqual("200", result);
            }
        }

        [Test]
        public void EvaluateScript_PassBodyasThis_ThisEqualsBodyObject()
        {
            _browser.TestLoadHtml("hello world");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                context.EvaluateScript("this;", (nsISupports)_browser.Document.Body.DomObject, out result);

                Assert.AreEqual("[object HTMLBodyElement]", result);
            }
        }

        [Test]
        public void EvaluateScript_PassBodysFirstChildAndPassToAInlineFunction_FunctionReturnsExpectedResults()
        {
            _browser.TestLoadHtml("hello <span>world</span>");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                string result;
                context.EvaluateScript("function dosomthing(node) { return node.textContent; } dosomthing(this);", (nsISupports)_browser.Document.Body.FirstChild.DomObject, out result);

                Assert.AreEqual("hello ", result);
            }
        }

        [Test]
        public void EvaluateScript_Run500Times_DoesNotCrash()
        {
            _browser.TestLoadHtml("");

            using (AutoJSContext context = new AutoJSContext(_browser.Window))
            {
                for (int i = 0; i < 500; i++)
                {
                    string result;
                    context.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_Run500TimesCreatingNewAutoJSContextEachTime_DoesNotCrash()
        {
            _browser.TestLoadHtml("");

            for (int i = 0; i < 500; i++)
            {
                using (AutoJSContext context = new AutoJSContext(_browser.Window))
                {
                    string result;
                    context.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_Run500Times_CreatingNewSafeAutoJSContextEachTime_DoesNotCrash()
        {
            for (int i = 0; i < 500; i++)
            {
                using (var safeContext = new AutoJSContext(_browser.Window))
                {
                    string result;
                    safeContext.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_Run500TimesNavigatingToANewDocumentEachTime_DoesNotCrash()
        {
            for (int i = 0; i < 500; i++)
            {
                _browser.TestLoadHtml(String.Format("{0}", i));

                using (AutoJSContext context = new AutoJSContext(_browser.Window))
                {
                    string result;
                    context.EvaluateScript("2+3;", out result);
                    Assert.AreEqual("5", result);
                }
            }
        }

        [Test]
        public void EvaluateScript_ReturingJsVal_ScriptExecutesAndReturnsJsValOfExpectedTypeAndContainingExpectedResult()
        {
            using (var context = new AutoJSContext(_browser.Window))
            {
                var jsVal = context.EvaluateScript("3 + 2;");
                Assert.IsTrue(jsVal.IsInt);
                Assert.AreEqual(5, jsVal.ToInteger());
            }
        }

        [Test]
        public void EvaluateScript_SyntacticallyInvalidJavascript_GeckoExceptionIsThrown()
        {
            using (var context = new AutoJSContext(_browser.Window))
            {
                var exception = Assert.Throws<GeckoException>(() => context.EvaluateScript("2 + _---;"));
                Assert.AreEqual("Failed to compile script.", exception.Message);
            }
        }

        [Test]
        public void EvaluateScript_JavascriptThatCallsMethodThatDoesNotExist_GeckoExceptionIsThrown()
        {
            using (var context = new AutoJSContext(_browser.Window))
            {
                var exception = Assert.Throws<GeckoJavaScriptException>(() => context.EvaluateScript("this.mymethodthatdontexist(3);"));
                Assert.AreEqual("JSError : TypeError: this.mymethodthatdontexist is not a function StackTrace: @script:1:1\n", exception.Message);
            }
        }


        [Test]
        public void Navigating_FrameDocumentLoaded_NavigatigAndFrameNavigatingEventIsCalled()
        {
            int navigatingCounter = 0;
            int frameNavigatingCounter = 0;
            _browser.Navigating += (sender, args) => navigatingCounter++;
            _browser.FrameNavigating += (sender, args) => frameNavigatingCounter++;

            _browser.TestLoadHtml(@"<html><body><iframe src='data:text/html,hello world'></iframe></body></html>'");

            Assert.AreEqual(1, navigatingCounter, "Navigating");
            Assert.AreEqual(1, frameNavigatingCounter, "FrameNavigating");
        }

        [Test]
        public void Navigating_JSCreatedFrameDocumentLoaded_NavigatigAndFrameNavigatingEventIsCalled()
        {
            int navigatingCounter = 0;
            int frameNavigatingCounter = 0;
            _browser.Navigating += (sender, args) => navigatingCounter++;
            _browser.FrameNavigating += (sender, args) => frameNavigatingCounter++;

            _browser.TestLoadHtml(@"
<html>
	<body>
		<script type='text/javascript'>
setTimeout(function(){
			var iframe = document.createElement('iframe');
			iframe.src = 'data:text/html,hello world';
			document.body.appendChild(iframe);
}, 1000);
		</script>
	</body>
</html>");
            DateTime expire = DateTime.Now.AddSeconds(5);
            while (DateTime.Now < expire)
                Application.DoEvents();


            Assert.AreEqual(1, navigatingCounter, "Navigating");
            Assert.AreEqual(1, frameNavigatingCounter, "FrameNavigating");
        }

        [Test]
        public void Navigating_IntialDocumentLoad_NavigatigEventIsCalled()
        {
            int counter = 0;
            _browser.Navigating += (sender, args) => counter++;

            _browser.TestLoadHtml("hello world");

            Assert.AreEqual(1, counter);
        }

        [Test]
        public void Navigating_TwoDocumentsLoaded_NavigatigEventIsCalledTwice()
        {
            int counter = 0;
            _browser.Navigating += (sender, args) => counter++;

            _browser.TestLoadHtml("hello world");
            _browser.TestLoadHtml("hello world");

            Assert.AreEqual(2, counter);
        }

        [Test]
        public void Navigating_UseJavaScriptToChangeDocument_NavigatigEventIsCalledWhenJavascriptChangesDocument()
        {
            int counter = 0;
            _browser.Navigating += (sender, args) => counter++;

            _browser.TestLoadHtml("hello world");
            _browser.Navigate("javascript:location.href='http://www.google.com';");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(2, counter);
        }

        [Platform("Win")]
        [Test]
        public void Navigating_UseJavaScriptToChangeDocumentToAUrlTheDoesNotExist_NavigatigEventIsCalled()
        {
            int counter = 0;
            int shouldNotChangeCounter = 0;

            _browser.TestLoadHtml("hello world");
            _browser.Navigating += (sender, args) => { counter++; args.Cancel = true; };
            _browser.Navigated += (sender, args) => shouldNotChangeCounter++;

            _browser.Navigate("javascript:location.href='http://www.domaindoesnNotExitqwertyuuiasdf.com?helloworld';");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(1, counter);
            Assert.AreEqual(0, shouldNotChangeCounter);
        }

        [Platform("Win")]
        [Test]
        public void Navigating_NavigatingIsCanceled_NavigateDoesNotComplete()
        {
            _browser.TestLoadHtml("hello world");
            bool navigatingCalled = false;
            bool navigatedCalled = false;

            _browser.Navigated += (sender, args) => navigatedCalled = true;
            _browser.Navigating += (sender, args) =>
                                      {
                                          args.Cancel = true;
                                          navigatingCalled = true;
                                      };
            _browser.Navigate("www.google.com");

            while (!navigatingCalled)
                Application.DoEvents();

            Assert.False(navigatedCalled);
            Assert.AreEqual("hello world", _browser.Document.Body.InnerHtml);

            navigatingCalled = false;
            _browser.Navigate("javascript:location.href='http://www.google.co.uk';");

            while (!navigatingCalled)
                Application.DoEvents();

            Assert.False(navigatedCalled);
            Assert.AreEqual("hello world", _browser.Document.Body.InnerHtml);
        }

        [Test]
        [Ignore("Navigate doesn't behave how describe in this unittest on my Windows 7 64bit machine.")]
        public void Navigating_NavigationError_Http()
        {
            int errorCount = 0, completeCount = 0;
            _browser.DocumentCompleted += (sender, e) => ++completeCount;
            _browser.NavigationError += (sender, e) => ++errorCount;

            _browser.Navigate("http://localhost:63333");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0, "localhost:63333 should have failed.");
            errorCount = completeCount = 0;

            _browser.Navigate("http://localhost:25");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0, "(1) localhost:25 should have failed.");
            errorCount = completeCount = 0;

            _browser.Reload();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0, "(2) localhost:25 should have failed.");
            errorCount = completeCount = 0;
        }

        [Test]
        public void Navigating_NavigationError_Chrome()
        {
            int errorCount = 0, completeCount = 0;
            _browser.DocumentCompleted += (sender, e) => ++completeCount;
            _browser.NavigationError += (sender, e) => ++errorCount;

            _browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 0 && completeCount == 1);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/content/aaaa"); //not found
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            Assert.True(_browser.CanGoBack);
            _browser.GoBack();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 0 && completeCount == 1);
            errorCount = completeCount = 0;

            Assert.True(_browser.CanGoForward);
            _browser.GoForward();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/content/bindings/general.xml");
            _browser.Stop();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;

            _browser.Navigate("chrome://global/content/bindings/general.xml");
            _browser.Navigating += (sender, e) => e.Cancel = true;
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 1 && completeCount == 0);
            errorCount = completeCount = 0;
        }

        [Test]
        public void Navigating_NavigationError_History()
        {
            string errorUrl = null;
            _browser.NavigationError += (sender, e) => errorUrl = e.Uri;

            _browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            _browser.Navigate("chrome://global/content/aaaa"); //not found
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.True(_browser.CanGoBack);
            _browser.GoBack();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.True(_browser.CanGoForward);
            _browser.GoForward();
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(errorUrl, "chrome://global/content/aaaa");

            _browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(errorUrl, "chrome://global/bindings/general.xml");
        }

        [Test]
        [Ignore("Expected fail.")]
        public void Navigating_NavigationError_History2()
        {
            string errorUrl = null;
            _browser.NavigationError += (sender, e) => errorUrl = e.Uri;

            _browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            _browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            // TODO Navigate("chrome://global/bindings/general.xml") failed and the url was not pushed into history stack,
            // so the assertion failed. may be a mozilla's bug
            Assert.True(_browser.GoBack());
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(_browser.GoForward());
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(errorUrl, "chrome://global/bindings/general.xml");
        }

        [Test]
        public void Navigating_Retarget()
        {
            int errorCount = 0, completeCount = 0, retargetCount = 0;
            string url = "data:application/zip,xyzuvw";
            GeckoRetargetedEventArgs rte = null;
            string contentType = null;
            _browser.DocumentCompleted += (sender, e) => ++completeCount;
            _browser.NavigationError += (sender, e) => ++errorCount;
            _browser.Retargeted += (sender, e) =>
            {
                ++retargetCount;
                rte = e;
                contentType = (rte.Request as Gecko.Net.Channel).ContentType;
            };

            _browser.Navigate(url);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.True(errorCount == 0 && completeCount == 0 && retargetCount == 1, "Unexpected event counts");
            Assert.AreEqual(url, rte.Uri.ToString());
            Assert.AreEqual("application/zip", contentType);
        }

        [Test]
        public void LoadContent_ControlHandleCreated_DocumentIsInitalizedWithSpecifiedContent()
        {
            Assert.AreEqual(true, _browser.IsHandleCreated);
            _browser.LoadContent("<body><div id='main'>hello world</div></body>", "http://www.earth.com", "text/html");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual(_browser.Document.GetElementById("main").TextContent, "hello world");
        }

        [Test]
        public void LoadContent_ControlHandleNotCreated_DocumentIsInitalizedWithContentAndHandleCreationisForced()
        {
            using (var browser = new GeckoWebBrowser())
            {
                Assert.AreEqual(false, browser.IsHandleCreated);
                browser.LoadContent("<body><div id='main'>hello world</div></body>", "http://www.earth.com", "text/html");
                Assert.AreEqual(true, browser.IsHandleCreated);
                browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
                Assert.AreEqual(browser.Document.GetElementById("main").TextContent, "hello world");
            }
        }

        /// <summary>
        /// UKAC unit test for CreateWindow
        /// </summary>
        [Ignore("bug hasn't been fixed yet.")]
        [Test]
        public void CreateWindow_OnloadEventCallsWindowOpenToCheckCreateWindowSuccess_ShouldReturnWindowObject()
        {
            _browser.CreateWindow += (m, e) =>
            {
                e.WebBrowser = new GeckoWebBrowser();
            };

            _browser.LoadHtml("<body onload=\"name='d'window.open('about:blank')\"></body>");
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
            Assert.AreEqual("[object Window]", _browser.Window.Name);
        }
    }
}
