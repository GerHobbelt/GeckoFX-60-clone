using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoFieldSetElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLFieldSetElement */ nsISupports DOMHTMLElement;

        internal GeckoFieldSetElement(/* nsIDOMHTMLFieldSetElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoFieldSetElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLFieldSetElement */ nsISupports;
        }

        public GeckoFormElement Form
        {
            get { return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); }
        }
    }
}