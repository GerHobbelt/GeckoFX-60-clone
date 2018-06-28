using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoMenuElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLMenuElement */ nsISupports DOMHTMLElement;

        internal GeckoMenuElement(/* nsIDOMHTMLMenuElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoMenuElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLMenuElement */ nsISupports;
        }

        public bool Compact
        {
            get { return DOMHTMLElement.GetCompactAttribute(); }
            set { DOMHTMLElement.SetCompactAttribute(value); }
        }
    }
}