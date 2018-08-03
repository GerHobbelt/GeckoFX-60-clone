using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoEmbedElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLEmbedElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoEmbedElement(nsISupports window, /* nsIDOMHTMLEmbedElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Height
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHeightAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHeightAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get {/* return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Src
        {
            get {/* return nsString.Get(DOMHTMLElement.GetSrcAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSrcAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Width
        {
            get { /*return nsString.Get(DOMHTMLElement.GetWidthAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}