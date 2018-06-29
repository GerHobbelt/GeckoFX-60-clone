using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoStyleElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLStyleElement */ nsISupports DOMHTMLElement;

        internal GeckoStyleElement(/* nsIDOMHTMLStyleElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoStyleElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLStyleElement */ nsISupports;
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