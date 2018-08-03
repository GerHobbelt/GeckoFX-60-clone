using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoUListElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLUListElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoUListElement(nsISupports window, /* nsIDOMHTMLUListElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public bool Compact
        {
            get { /*return DOMHTMLElement.GetCompactAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCompactAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}