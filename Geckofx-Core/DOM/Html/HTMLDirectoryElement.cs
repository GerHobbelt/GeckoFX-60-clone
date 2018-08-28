using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoDirectoryElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLDirectoryElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoDirectoryElement(mozIDOMWindowProxy window, /* nsIDOMHTMLDirectoryElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }
    }
}