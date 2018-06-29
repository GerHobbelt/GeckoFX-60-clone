using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoButtonElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLButtonElement */ nsISupports DOMHTMLElement;

        internal GeckoButtonElement(/* nsIDOMHTMLButtonElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoButtonElement(object element) : base(element as /* nsIDOMHTMLElement */nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLButtonElement */ nsISupports;
        }

        public GeckoFormElement Form
        {
            get {/* return new GeckoFormElement(DOMHTMLElement.GetFormAttribute());*/throw new NotImplementedException(); }
        }

        public bool Disabled
        {
            get { /*return DOMHTMLElement.GetDisabledAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDisabledAttribute(value); */throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
        }

        public string Value
        {
            get {/* return nsString.Get(DOMHTMLElement.GetValueAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetValueAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}