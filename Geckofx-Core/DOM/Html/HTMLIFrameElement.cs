using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM
{
    public class GeckoIFrameElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLIFrameElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoIFrameElement(nsISupports window, /* nsIDOMHTMLIFrameElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string FrameBorder
        {
            get { /*return nsString.Get(DOMHTMLElement.GetFrameBorderAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetFrameBorderAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Height
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHeightAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHeightAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string LongDesc
        {
            get { /*return nsString.Get(DOMHTMLElement.GetLongDescAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetLongDescAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string MarginHeight
        {
            get { /*return nsString.Get(DOMHTMLElement.GetMarginHeightAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMarginHeightAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string MarginWidth
        {
            get { /*return nsString.Get(DOMHTMLElement.GetMarginWidthAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMarginWidthAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Scrolling
        {
            get {/* return nsString.Get(DOMHTMLElement.GetScrollingAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetScrollingAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Src
        {
            get { /*return nsString.Get(DOMHTMLElement.GetSrcAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSrcAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Width
        {
            get {/* return nsString.Get(DOMHTMLElement.GetWidthAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public GeckoDocument ContentDocument
        {
            get
            {
                //var doc = DOMHTMLElement.GetContentDocumentAttribute() as nsIDOMHTMLDocument;
                //return (doc == null) ? null : new GeckoDocument(doc);
                throw new NotImplementedException();
            }
        }

        public GeckoWindow ContentWindow
        {
            get
            {
                //var window = DOMHTMLElement.GetContentWindowAttribute();
                //return (window == null) ? null : new GeckoWindow(window);
                throw new NotImplementedException();
            }
        }
    }
}