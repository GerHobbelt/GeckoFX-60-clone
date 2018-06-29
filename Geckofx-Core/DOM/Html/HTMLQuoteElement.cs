using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoQuoteElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLQuoteElement */ nsISupports DOMHTMLElement;

        internal GeckoQuoteElement(/* nsIDOMHTMLQuoteElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoQuoteElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLQuoteElement */ nsISupports;
        }

        public string Cite
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCiteAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCiteAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}