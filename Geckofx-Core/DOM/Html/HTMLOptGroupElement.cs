using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoOptGroupElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLOListElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoOptGroupElement(nsISupports window, /* nsIDOMHTMLOptGroupElement*/ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public bool Disabled
        {
            get { /*return DOMHTMLElement.GetDisabledAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDisabledAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Label
        {
            get { /*return nsString.Get(DOMHTMLElement.GetLabelAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetLabelAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}