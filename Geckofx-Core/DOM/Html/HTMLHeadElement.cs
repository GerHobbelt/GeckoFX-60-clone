using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoHeadElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLHeadElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoHeadElement(mozIDOMWindowProxy window, /* nsIDOMHTMLHeadElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }
    }
}