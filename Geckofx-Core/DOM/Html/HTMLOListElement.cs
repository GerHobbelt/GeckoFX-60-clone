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
            get { return DOMHTMLElement.GetCompactAttribute(); }
            set { DOMHTMLElement.SetCompactAttribute(value); }
        }

        public int Start
        {
            get { return DOMHTMLElement.GetStartAttribute(); }
            set { DOMHTMLElement.SetStartAttribute(value); }
        }

        public string Type
        {
            get { return nsString.Get(DOMHTMLElement.GetTypeAttribute); }
            set { DOMHTMLElement.SetTypeAttribute(new nsAString(value)); }
        }
    }
}