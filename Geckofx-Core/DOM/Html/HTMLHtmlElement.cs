using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoHtmlHtmlElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLHtmlElement */ nsISupports DOMHTMLElement;

        internal GeckoHtmlHtmlElement(/* nsIDOMHTMLHtmlElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoHtmlHtmlElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLHtmlElement */ nsISupports;
        }

        public string Version
        {
            get { return nsString.Get(DOMHTMLElement.GetVersionAttribute); }
            set { DOMHTMLElement.SetVersionAttribute(new nsAString(value)); }
        }
    }
}