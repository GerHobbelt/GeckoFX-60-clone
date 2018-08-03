using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoLinkElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLLinkElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoLinkElement(nsISupports window, /* nsIDOMHTMLLinkElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public bool Disabled
        {
            get { /*return DOMHTMLElement.GetDisabledAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDisabledAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Charset
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCharsetAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCharsetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
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

        public string Media
        {
            get { /*return nsString.Get(DOMHTMLElement.GetMediaAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMediaAttribute(new nsAString(value));*/throw new NotImplementedException(); }
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