using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoMapElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLMapElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoMapElement(nsISupports window, /* nsIDOMHTMLMapElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
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