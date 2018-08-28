using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoLIElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLLIElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoLIElement(mozIDOMWindowProxy window, /* nsIDOMHTMLLIElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public int Value
        {
            get { /*return DOMHTMLElement.GetValueAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetValueAttribute(value);*/throw new NotImplementedException(); }
        }
    }
}