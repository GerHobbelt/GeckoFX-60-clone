using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoBaseElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLBaseElement */ nsISupports DOMHTMLElement;

        internal GeckoBaseElement(/* nsIDOMHTMLBaseElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoBaseElement(object element) : base(element as /* nsIDOMHTMLElement */nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLBaseElement */ nsISupports;
        }

        public string Href
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHrefAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHrefAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Target
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTargetAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTargetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}