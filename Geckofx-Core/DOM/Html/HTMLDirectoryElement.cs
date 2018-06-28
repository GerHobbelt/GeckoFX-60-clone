using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoDirectoryElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLDirectoryElement */ nsISupports DOMHTMLElement;

        internal GeckoDirectoryElement(/* nsIDOMHTMLDirectoryElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoDirectoryElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLDirectoryElement */ nsISupports;
        }
    }
}