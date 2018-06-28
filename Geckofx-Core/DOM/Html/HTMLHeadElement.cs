using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoHeadElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLHeadElement */ nsISupports DOMHTMLElement;

        internal GeckoHeadElement(/* nsIDOMHTMLHeadElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoHeadElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLHeadElement */ nsISupports;
        }
    }
}