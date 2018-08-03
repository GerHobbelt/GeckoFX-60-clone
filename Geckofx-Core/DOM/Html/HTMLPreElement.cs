using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoPreElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLPreElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoPreElement(nsISupports window, /* nsIDOMHTMLPreElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public int Width
        {
            get { /*return DOMHTMLElement.GetWidthAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(value);*/throw new NotImplementedException(); }
        }
    }
}