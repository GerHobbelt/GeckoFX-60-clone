using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoParagraphElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLParagraphElement */ nsISupports DOMHTMLElement;

        internal GeckoParagraphElement(/* nsIDOMHTMLParagraphElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoParagraphElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLParagraphElement */ nsISupports;
        }

        public string Align
        {
            get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
            set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
        }
    }
}