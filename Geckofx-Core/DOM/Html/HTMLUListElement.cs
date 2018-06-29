using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoUListElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLUListElement */ nsISupports DOMHTMLElement;

        internal GeckoUListElement(/* nsIDOMHTMLUListElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoUListElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLUListElement */ nsISupports;
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