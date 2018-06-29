using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoMapElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLMapElement */ nsISupports DOMHTMLElement;

        internal GeckoMapElement(/* nsIDOMHTMLMapElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoMapElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLMapElement */ nsISupports;
        }

        public GeckoHtmlElementCollection Areas
        {
            get { /*return new GeckoHtmlElementCollection(DOMHTMLElement.GetAreasAttribute());*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}