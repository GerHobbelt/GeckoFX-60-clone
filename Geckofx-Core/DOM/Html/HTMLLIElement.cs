using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoLIElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLLIElement */ nsISupports DOMHTMLElement;

        internal GeckoLIElement(/* nsIDOMHTMLLIElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoLIElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLLIElement */ nsISupports;
        }

        public string Type
        {
            get { return nsString.Get(DOMHTMLElement.GetTypeAttribute); }
            set { DOMHTMLElement.SetTypeAttribute(new nsAString(value)); }
        }

        public int Value
        {
            get { return DOMHTMLElement.GetValueAttribute(); }
            set { DOMHTMLElement.SetValueAttribute(value); }
        }
    }
}