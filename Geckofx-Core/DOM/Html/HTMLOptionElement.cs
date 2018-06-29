using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoOptionElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLOptionElement */ nsISupports DOMHTMLElement;

        internal GeckoOptionElement(/* nsIDOMHTMLOptionElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoOptionElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLOptionElement */ nsISupports;
        }

        public GeckoFormElement Form
        {
            get { /*return new GeckoFormElement(DOMHTMLElement.GetFormAttribute());*/throw new NotImplementedException(); }
        }

        public bool DefaultSelected
        {
            get { /*return DOMHTMLElement.GetDefaultSelectedAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDefaultSelectedAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Text
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTextAttribute);*/throw new NotImplementedException(); }
        }

        public int Index
        {
            get { /*return DOMHTMLElement.GetIndexAttribute();*/throw new NotImplementedException(); }
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

        public bool Selected
        {
            get { /*return DOMHTMLElement.GetSelectedAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSelectedAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Value
        {
            get { /*return nsString.Get(DOMHTMLElement.GetValueAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetValueAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}