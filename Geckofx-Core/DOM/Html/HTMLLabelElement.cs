using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoLabelElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLLabelElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoLabelElement(nsISupports window, /* nsIDOMHTMLLabelElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoFormElement Form
        {
            get {/* return new GeckoFormElement(DOMHTMLElement.GetFormAttribute());*/throw new NotImplementedException(); }
        }

        public string HtmlFor
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHtmlForAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHtmlForAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}