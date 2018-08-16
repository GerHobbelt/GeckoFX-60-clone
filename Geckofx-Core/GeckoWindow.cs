using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.Interop;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM window.
    /// </summary>
    public class GeckoWindow
        : IEquatable<GeckoWindow>, IDisposable
    {
        private ComPtr<nsISupports> _domWindowProxy;
        private ComPtr<mozIDOMWindow> _innerWindow;

        #region ctor & dtor

        public GeckoWindow(mozIDOMWindow window, bool ownRCW = true)
        {
            _domWindowProxy = new ComPtr<nsISupports>((nsISupports)window, ownRCW);
        }

        public GeckoWindow(nsIDOMWindow window, bool ownRCW = true)
        {
            throw new NotImplementedException();
        }

        public GeckoWindow(mozIDOMWindowProxy window, bool ownRCW = true)
        {
            _domWindowProxy = new ComPtr<nsISupports>((nsISupports)window, ownRCW);
        }

        public GeckoWindow(mozIDOMWindowProxy window, mozIDOMWindow innerWindow, bool ownRCW = true)
        {
            _domWindowProxy = new ComPtr<nsISupports>((nsISupports)window, ownRCW);
            _innerWindow = new ComPtr<mozIDOMWindow>(innerWindow, ownRCW);
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
        public nsISupports DomWindow
        {
            get { return _domWindowProxy.Instance; }
        }

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
        public GeckoDomDocument Document
        {
            get
            {
                nsISupports innerWindow = (nsISupports)_innerWindow?.Instance;
                return
                    new WebIDL.Window(_domWindowProxy.Instance, innerWindow ?? _domWindowProxy.Instance).Document.Wrap(_domWindowProxy.Instance,
                        GeckoDomDocument.CreateDomDocumentWraper);
            }
        }

        /// <summary>
        /// Gets the parent window of this one.
        /// </summary>
        public GeckoWindow Parent
        {
            get
            {
                return
                    new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).Parent.Wrap(
                        x => new GeckoWindow(x));
            }
        }

        public double ScrollX
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollX; }
        }

        public double ScrollY
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollY; }
        }

        public int ScrollMinX
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollMinX; }
        }

        public int ScrollMinY
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollMinY; }
        }

        public int ScrollMaxX
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollMaxX; }
        }

        public int ScrollMaxY
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollMaxY; }
        }

        public void ScrollTo(int xScroll, int yScroll)
        {
            new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollTo(xScroll, yScroll);
        }

        public void ScrollBy(double xScrollDif, double yScrollDif)
        {
            new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollBy(xScrollDif, yScrollDif);
        }

        public void ScrollByLines(int numLines)
        {
            new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollByLines(numLines);
        }

        public void ScrollByPages(int numPages)
        {
            new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).ScrollByPages(numPages);
        }

        public void SizeToContent()
        {
            new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).SizeToContent();
        }

        public GeckoWindow Top
        {
            get
            {
                return
                    new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).Top.Wrap(_domWindowProxy.Instance,
                        (x,y) => new GeckoWindow(y));
            }
        }

        public string Name
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).Name; }
            set { new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).Name = value; }
        }

        public ulong MozPaintCount
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).MozPaintCount; }
        }

        public object Content
        {
            get { return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).Content; }
        }

        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord,
            bool searchInFrames, bool showDialog)
        {
            return new WebIDL.Window(_domWindowProxy.Instance, (nsISupports) _domWindowProxy.Instance).Find(str, caseSensitive,
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
            new WebIDL.Window(_domWindowProxy.Instance, _domWindowProxy.Instance).GetSelection());

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