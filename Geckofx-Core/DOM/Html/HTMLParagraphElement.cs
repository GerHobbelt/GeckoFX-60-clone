using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoParagraphElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLParagraphElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoParagraphElement(nsISupports window,/* nsIDOMHTMLParagraphElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}