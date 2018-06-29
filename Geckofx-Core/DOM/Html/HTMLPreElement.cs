using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoPreElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLPreElement */ nsISupports DOMHTMLElement;

        internal GeckoPreElement(/* nsIDOMHTMLPreElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoPreElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLPreElement */ nsISupports;
        }

        public int Width
        {
            get { /*return DOMHTMLElement.GetWidthAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(value);*/throw new NotImplementedException(); }
        }
    }
}