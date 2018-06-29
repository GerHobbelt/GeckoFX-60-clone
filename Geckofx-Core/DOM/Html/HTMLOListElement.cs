using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoOListElement : GeckoHtmlElement
    {
        private /* /* nsIDOMHTMLOListElement*/ nsISupports DOMHTMLElement;

        internal GeckoOListElement(/* /* nsIDOMHTMLOListElement*/ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoOListElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* /* nsIDOMHTMLOListElement*/ nsISupports;
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