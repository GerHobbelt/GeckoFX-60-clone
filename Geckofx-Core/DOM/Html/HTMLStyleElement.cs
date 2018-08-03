using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoStyleElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLStyleElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoStyleElement(nsISupports window, /* nsIDOMHTMLStyleElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public bool Disabled
        {
            get { /*return DOMHTMLElement.GetDisabledAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDisabledAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Media
        {
            get { /*return nsString.Get(DOMHTMLElement.GetMediaAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMediaAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}