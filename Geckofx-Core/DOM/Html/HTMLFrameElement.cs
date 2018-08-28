using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoFrameElement : GeckoHtmlElement
    {
        private readonly mozIDOMWindowProxy _window;
        private /* nsIDOMHTMLFrameElement */ nsIDOMElement DOMHTMLElement;
        private Lazy<WebIDL.HTMLFrameElement> _htmlFrame;

        internal GeckoFrameElement(mozIDOMWindowProxy window,/* nsIDOMHTMLFrameElement */ nsIDOMElement element) : base(window, element)
        {
            _window = (mozIDOMWindowProxy)window;
            this.DOMHTMLElement = element;
            _htmlFrame = new Lazy<HTMLFrameElement>(() => new HTMLFrameElement((mozIDOMWindowProxy)window, (nsISupports)element));
        }

        public string FrameBorder
        {
            get { return _htmlFrame.Value.FrameBorder; }
            set { _htmlFrame.Value.FrameBorder = value; }
        }

        public string LongDesc
        {
            get { return _htmlFrame.Value.LongDesc; }
            set { _htmlFrame.Value.LongDesc = value; }
        }

        public string MarginHeight
        {
            get { return _htmlFrame.Value.MarginHeight; }
            set { _htmlFrame.Value.MarginHeight = value; }
        }

        public string MarginWidth
        {
            get { return _htmlFrame.Value.MarginWidth; }
            set { _htmlFrame.Value.MarginWidth = value; }
        }

        public string Name
        {
            get { return _htmlFrame.Value.Name; }
            set { _htmlFrame.Value.Name = value; }
        }

        public bool NoResize
        {
            get { return _htmlFrame.Value.NoResize; }
            set { _htmlFrame.Value.NoResize = value; }
        }

        public string Scrolling
        {
            get { return _htmlFrame.Value.Scrolling; }
            set { _htmlFrame.Value.Scrolling = value; }
        }

        public string Src
        {
            get { return _htmlFrame.Value.Src; }
            set { _htmlFrame.Value.Src = value; }
        }

        public GeckoDocument ContentDocument
        {
            get
            {
                var doc = _htmlFrame.Value.ContentDocument;
                return doc == null ? null : new GeckoDocument(_window, doc);
            }
        }

        public GeckoWindow ContentWindow
        {
            get
            {
                var window = _htmlFrame.Value.ContentWindow;
                return window == null ? null : new GeckoWindow(_window, (nsISupports)window);               
            }
        }
    }
}