using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoOptGroupElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLOListElement */ nsISupports DOMHTMLElement;

        internal GeckoOptGroupElement(/* nsIDOMHTMLOptGroupElement*/ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoOptGroupElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLOptGroupElement*/ nsISupports;
        }

        public bool Disabled
        {
            get { return DOMHTMLElement.GetDisabledAttribute(); }
            set { DOMHTMLElement.SetDisabledAttribute(value); }
        }

        public string Label
        {
            get { return nsString.Get(DOMHTMLElement.GetLabelAttribute); }
            set { DOMHTMLElement.SetLabelAttribute(new nsAString(value)); }
        }
    }
}