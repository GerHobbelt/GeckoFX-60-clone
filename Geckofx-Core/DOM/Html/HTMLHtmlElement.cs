using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoHtmlHtmlElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLHtmlElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoHtmlHtmlElement(nsISupports window, /* nsIDOMHTMLHtmlElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Version
        {
            get { /*return nsString.Get(DOMHTMLElement.GetVersionAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetVersionAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}