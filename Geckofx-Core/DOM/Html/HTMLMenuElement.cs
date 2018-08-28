using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoMenuElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLMenuElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoMenuElement(mozIDOMWindowProxy window, /* nsIDOMHTMLMenuElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public bool Compact
        {
            get { /*return DOMHTMLElement.GetCompactAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCompactAttribute(value);*/throw new NotImplementedException(); }
        }
    }
}