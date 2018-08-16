using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoIFrameElement : GeckoHtmlElement
    {
        private readonly nsISupports _window;
        private /* nsIDOMHTMLIFrameElement */ nsIDOMElement DOMHTMLElement;
        private Lazy<HTMLIFrameElement> _frameElement;

        internal GeckoIFrameElement(nsISupports window, /* nsIDOMHTMLIFrameElement */ nsIDOMElement element) : base(window, element)
        {
            _window = window;
            this.DOMHTMLElement = element;
            _frameElement = new Lazy<HTMLIFrameElement>(() => new HTMLIFrameElement((mozIDOMWindowProxy)_window, (nsISupports)element));
        }

        public string Align
        {
            get { return _frameElement.Value.Align; }
            set { _frameElement.Value.Align = value; }
        }

        public string FrameBorder
        {
            get { return _frameElement.Value.FrameBorder; }
            set { _frameElement.Value.FrameBorder = value; }
        }

        public string Height
        {
            get { return _frameElement.Value.Height; }
            set { _frameElement.Value.Height = value; }
        }

        public string LongDesc
        {
            get { return _frameElement.Value.LongDesc; }
            set { _frameElement.Value.LongDesc = value; }
        }

        public string MarginHeight
        {
            get { return _frameElement.Value.MarginHeight; }
            set { _frameElement.Value.MarginHeight = value; }
        }

        public string MarginWidth
        {
            get { return _frameElement.Value.MarginWidth; }
            set { _frameElement.Value.MarginWidth = value; }
        }

        public string Name
        {
            get { return _frameElement.Value.Name; }
            set { _frameElement.Value.Name = value; }
        }

        public string Scrolling
        {
            get { return _frameElement.Value.Scrolling; }
            set { _frameElement.Value.Scrolling = value; }
        }

        public string Src
        {
            get { return _frameElement.Value.Src; }
            set { _frameElement.Value.Src = value; }
        }

        public string Width
        {
            get { return _frameElement.Value.Width; }
            set { _frameElement.Value.Width = value; }
        }

        public GeckoDocument ContentDocument
        {
            get
            {
                var doc = _frameElement.Value.ContentDocument;
                return doc == null ? null : new GeckoDocument(_window, doc);
            }
        }

        public GeckoWindow ContentWindow
        {
            get
            {
                var window = _frameElement.Value.ContentWindow;
                return window == null ? null : new GeckoWindow((mozIDOMWindowProxy)_window, (nsISupports)window);
            }
        }
    }
}
