using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoQuoteElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLQuoteElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoQuoteElement(mozIDOMWindowProxy window, /* nsIDOMHTMLQuoteElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Cite
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCiteAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCiteAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}