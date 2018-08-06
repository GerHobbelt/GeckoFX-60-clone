using System;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko
{
    internal sealed class ChromeContext : IDisposable
    {
        private bool _isInitialized;
        private ComPtr<nsIWindowlessBrowser> _webNav;
        private ComPtr<nsIDOMElement> _command;

        public ChromeContext()
        {
            var appShell = Xpcom.GetService2<nsIAppShellService>(Contracts.AppShellService);
            _webNav = appShell.Instance.CreateWindowlessBrowser(true).AsComPtr();
            // Load a chrome page so we get permission to use canvas.drawWindow
            _webNav.Instance.LoadURI("chrome://global/content/reader/aboutReader.html", 0, null, null, null, null);
        }

        #region IDisposable implementation

#if DEBUG
        /// <summary/>
        ~ChromeContext()
        {
            Dispose(false);
        }
#endif

        /// <summary/>
        public bool IsDisposed { get; private set; }

        /// <summary/>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary/>
        private void Dispose(bool fDisposing)
        {
            System.Diagnostics.Debug.WriteLineIf(!fDisposing,
                "****** Missing Dispose() call for " + GetType() + ". *******");
            if (fDisposing && !IsDisposed)
            {
                // dispose managed and unmanaged objects
                if (_webNav != null)
                    _webNav.Dispose();
                if (_command != null)
                    _command.Dispose();
                _isInitialized = false;
            }
            _webNav = null;
            _command = null;
            IsDisposed = true;
        }

        #endregion

        private void Init()
        {
            if (_isInitialized)
                return;

            _isInitialized = true;
            var proxy = (mozIDOMWindowProxy)Xpcom.QueryInterface(_webNav.Instance, typeof(mozIDOMWindowProxy).GUID);

            GeckoDomDocument doc = _webNav.Instance.GetDocumentAttribute()
                .Wrap((nsISupports)proxy, GeckoDomDocument.CreateDomDocumentWraper);
            GeckoElement rootElement = doc.DocumentElement;
            while (rootElement.FirstChild != null)
                rootElement.RemoveChild(rootElement.FirstChild);

            // Use of the canvas technique was inspired by: the abduction! firefox plugin by Rowan Lewis
            // https://addons.mozilla.org/en-US/firefox/addon/abduction/

            uint flags = /*nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_DO_NOT_FLUSH*/2
                        //| nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_DRAW_VIEW 4
                        | /*nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_ASYNC_DECODE_IMAGES*/16
                        | /*nsIDOMCanvasRenderingContext2DConsts.DRAWWINDOW_USE_WIDGET_LAYERS*/8;

            string func = @"
function drawWindow(window, document, x, y, w, h, canvas)
{
	try {
		canvas = document.createElement('canvas');
		canvas.width = w;
		canvas.height = h;
		ctx = canvas.getContext('2d');
		ctx.drawWindow(window, x, y, w, h, 'rgb(255,255,255)', " + flags + @");
        return canvas.toDataURL('image/png');
	} catch(e) {
		return e + '' + 'window = ' + window + ' x = ' + x;
	}
}
";

            var button = doc.CreateElement("button");
            button.SetAttribute("onclick",
                func +
                @"this.dataset.drawResult = drawWindow(this.sourceWin, this.ownerDocument, this.x, this.y, this.w, this.h)");
            rootElement.AppendChild(button);

            _command = Xpcom.QueryInterface<nsIDOMElement>(button.DOMElement).AsComPtr();
        }

        internal byte[] DrawWindow(mozIDOMWindowProxy window, uint x, uint y, uint w, uint h)
        {
            Xpcom.AssertCorrectThread();
            Init();

            var proxy = (mozIDOMWindowProxy)Xpcom.QueryInterface(_webNav.Instance, typeof(mozIDOMWindowProxy).GUID);

            SetValue(proxy, "x", x);
            SetValue(proxy, "y", y);
            SetValue(proxy, "w", w);
            SetValue(proxy, "h", h);

            new HTMLElement(proxy, (nsISupports)_command.Instance).SetProperty("sourceWin", window);
            var element = new HTMLElement(proxy, (nsISupports)_command.Instance);
            element.Click();
            string base64Image = null;
            var dataSet = new DOMStringMap(proxy, new HTMLElement(proxy, (nsISupports)_command.Instance).Dataset);
            var drawResult = dataSet.GetProperty<string>("drawResult");

            if (drawResult != null)
                base64Image = drawResult;

            if (base64Image == null)
                throw new InvalidOperationException();
            if (!base64Image.StartsWith("data:image/png;base64,"))
                throw new InvalidOperationException(base64Image);

            byte[] bytes = Convert.FromBase64String(base64Image.Substring("data:image/png;base64,".Length));
            return bytes;
        }

        private void SetValue(mozIDOMWindowProxy proxy, string name, uint value)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var element = new HTMLElement(proxy, (nsISupports)_command.Instance);
            element.SetProperty(name, value);
        }
    }
}
