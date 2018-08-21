using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM window.
    /// </summary>
    public class GeckoWindow
        : IEquatable<GeckoWindow>, IDisposable
    {
        private ComPtr<nsISupports> _domWindowProxy;
        private ComPtr<nsISupports> _innerWindow;
        private Lazy<WebIDL.Window> _window;

        #region ctor & dtor

        public GeckoWindow(mozIDOMWindow window, bool ownRCW = true)
        {
            _domWindowProxy = new ComPtr<nsISupports>((nsISupports)window, ownRCW);
            _window = new Lazy<Window>(() => new WebIDL.Window(_domWindowProxy.Instance, _innerWindow?.Instance ?? _domWindowProxy.Instance));
        }

        public GeckoWindow(nsIDOMWindow window, bool ownRCW = true)
        {
            throw new NotImplementedException();
        }

        public GeckoWindow(mozIDOMWindowProxy window, bool ownRCW = true)
        {
            _domWindowProxy = new ComPtr<nsISupports>((nsISupports)window, ownRCW);
            _window = new Lazy<Window>(() => new WebIDL.Window(_domWindowProxy.Instance, _innerWindow?.Instance ?? _domWindowProxy.Instance));
        }

        public GeckoWindow(mozIDOMWindowProxy window, nsISupports innerWindow, bool ownRCW = true)
        {
            _domWindowProxy = new ComPtr<nsISupports>((nsISupports)window, ownRCW);
            _innerWindow = new ComPtr<nsISupports>(innerWindow, ownRCW);
            _window = new Lazy<Window>(() => new WebIDL.Window(_domWindowProxy.Instance, _innerWindow?.Instance ?? _domWindowProxy.Instance));
        }

        ~GeckoWindow()
        {
            Xpcom.DisposeObject(ref _domWindowProxy);
        }

        public void Dispose()
        {
            Xpcom.DisposeObject(ref _domWindowProxy);
            GC.SuppressFinalize(this);
        }

        #endregion

        /// <summary>
        /// Gets the underlying unmanaged DOM object.
        /// </summary>
        public nsISupports DomWindow => _innerWindow?.Instance ?? _domWindowProxy?.Instance;

        public WindowUtils WindowUtils
        {
            get
            {
                var utils = Xpcom.QueryInterface<nsIDOMWindowUtils>(DomWindow);
                return utils.Wrap(DomWindow, WindowUtils.Create);
            }
        }


        /// <summary>
        /// Gets the document displayed in the window.
        /// </summary>
        public GeckoDomDocument Document => _window.Value.Document.Wrap(_domWindowProxy.Instance,
            GeckoDomDocument.CreateDomDocumentWraper);

        /// <summary>
        /// Gets the parent window of this one.
        /// </summary>
        public GeckoWindow Parent => _window.Value.Parent.Wrap(x => new GeckoWindow(x));

        public double ScrollX => _window.Value.ScrollX;

        public double ScrollY => _window.Value.ScrollY;

        public int ScrollMinX => _window.Value.ScrollMinX;

        public int ScrollMinY => _window.Value.ScrollMinY;

        public int ScrollMaxX => _window.Value.ScrollMaxX;

        public int ScrollMaxY => _window.Value.ScrollMaxY;

        public void ScrollTo(int xScroll, int yScroll)
        {
            _window.Value.ScrollTo(xScroll, yScroll);
        }

        public void ScrollBy(double xScrollDif, double yScrollDif)
        {
            _window.Value.ScrollBy(xScrollDif, yScrollDif);
        }

        public void ScrollByLines(int numLines)
        {
            _window.Value.ScrollByLines(numLines);
        }

        public void ScrollByPages(int numPages)
        {
            _window.Value.ScrollByPages(numPages);
        }

        public void SizeToContent()
        {
            _window.Value.SizeToContent();
        }

        public GeckoWindow Top
        {
            get
            {
                return
                    _window.Value.Top.Wrap(_domWindowProxy.Instance,
                        (x,y) => new GeckoWindow(y));
            }
        }

        public string Name
        {
            get { return _window.Value.Name; }
            set { _window.Value.Name = value; }
        }

        public ulong MozPaintCount
        {
            get { return _window.Value.MozPaintCount; }
        }

        public object Content
        {
            get { return _window.Value.Content; }
        }

        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord,
            bool searchInFrames, bool showDialog)
        {
            return _window.Value.Find(str, caseSensitive,
                backwards, wrapAround, wholeWord, searchInFrames, showDialog);
        }

        public void Print()
        {
            nsIWebBrowserPrint print = Xpcom.QueryInterface<nsIWebBrowserPrint>(_domWindowProxy.Instance);

            try
            {
                print.Print(null, null);
            }
            catch (COMException e)
            {
                //NS_ERROR_ABORT means user cancelled the printing, not really an error.
                if (e.ErrorCode != GeckoError.NS_ERROR_ABORT)
                    throw;
            }

            Marshal.ReleaseComObject(print);
        }

        public GeckoSelection Selection => GeckoSelection.Create(_domWindowProxy.Instance,
            _window.Value.GetSelection());

        // The WebIDL Window interfaces doesn't seem to have a Frames apptribute that returns a WindowCollection (rather just a window proxy? is it QI-able?)
#if false
		public GeckoWindowCollection Frames
		{
			get { return new GeckoWindowCollection(_domWindowProxy.Instance.GetFramesAttribute()); }
		}
#endif

        public bool Equals(GeckoWindow other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(other, null)) return false;
            return _domWindowProxy.Instance.GetHashCode() == other._domWindowProxy.Instance.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (ReferenceEquals(obj, null)) return false;
            return _domWindowProxy.Instance.GetHashCode() == ((GeckoWindow) obj)._domWindowProxy.Instance.GetHashCode();
        }

        public override int GetHashCode()
        {
// ReSharper disable once NonReadonlyFieldInGetHashCode
            return _domWindowProxy.Instance.GetHashCode();
        }
    }


    public static class GeckoWindowExtension
    {
        public static bool IsTopWindow(this GeckoWindow geckoWindow)
        {
            if (geckoWindow == null) return true;
            using (var top = geckoWindow.Top)
            {
                if (top == null)
                    return true;
                return top.DomWindow.GetHashCode() == geckoWindow.DomWindow.GetHashCode();
            }
        }
    }
}