using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoAreaElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLAreaElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoAreaElement(nsISupports window, /* nsIDOMHTMLAreaElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Alt
        {
            get {/* return nsString.Get(DOMHTMLElement.GetAltAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAltAttribute(new nsAString(value));*/throw new NotImplementedException(); }
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

        public bool NoHref
        {
            get { /*return DOMHTMLElement.GetNoHrefAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNoHrefAttribute(value);*/throw new NotImplementedException(); }
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
    }
}