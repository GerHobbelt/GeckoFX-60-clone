using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoLabelElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLLabelElement */ nsISupports DOMHTMLElement;

        internal GeckoLabelElement(/* nsIDOMHTMLLabelElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoLabelElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLLabelElement */ nsISupports;
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