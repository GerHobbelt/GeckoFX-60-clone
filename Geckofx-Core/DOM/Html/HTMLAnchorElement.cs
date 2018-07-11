using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoAnchorElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLAnchorElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoAnchorElement(nsISupports window, /* nsIDOMHTMLAnchorElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoAnchorElement(nsISupports window, object element) : base(window, element as /* nsIDOMHTMLElement */nsIDOMElement)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLAnchorElement */ nsIDOMElement;
        }

        public string Charset
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCharsetAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCharsetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Coords
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCoordsAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCoordsAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Href
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHrefAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHrefAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Hreflang
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHreflangAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHreflangAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Rel
        {
            get { /*return nsString.Get(DOMHTMLElement.GetRelAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetRelAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Rev
        {
            get { /*return nsString.Get(DOMHTMLElement.GetRevAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetRevAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Shape
        {
            get { /*return nsString.Get(DOMHTMLElement.GetShapeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetShapeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Target
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTargetAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTargetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}