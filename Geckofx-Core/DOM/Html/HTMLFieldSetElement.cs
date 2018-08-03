using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoFieldSetElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLFieldSetElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoFieldSetElement(nsISupports window, /* nsIDOMHTMLFieldSetElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoFormElement Form
        {
            get { /*return new GeckoFormElement(DOMHTMLElement.GetFormAttribute());*/throw new NotImplementedException(); }
        }
    }
}