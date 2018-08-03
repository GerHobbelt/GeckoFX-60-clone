using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoOListElement : GeckoHtmlElement
    {
        private /* /* nsIDOMHTMLOListElement*/ nsIDOMElement DOMHTMLElement;

        internal GeckoOListElement(nsISupports window, /* /* nsIDOMHTMLOListElement*/ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public bool Compact
        {
            get { /*return DOMHTMLElement.GetCompactAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCompactAttribute(value);*/throw new NotImplementedException(); }
        }

        public int Start
        {
            get { /*return DOMHTMLElement.GetStartAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetStartAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}