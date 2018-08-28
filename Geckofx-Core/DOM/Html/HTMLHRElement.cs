using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoHRElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLHRElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoHRElement(mozIDOMWindowProxy window, /* nsIDOMHTMLHRElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public bool NoShade
        {
            get { /*return DOMHTMLElement.GetNoShadeAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNoShadeAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Size
        {
            get { /*return nsString.Get(DOMHTMLElement.GetSizeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSizeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Width
        {
            get { /*return nsString.Get(DOMHTMLElement.GetWidthAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}