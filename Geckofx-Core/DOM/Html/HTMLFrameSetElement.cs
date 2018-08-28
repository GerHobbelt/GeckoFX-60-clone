using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoFrameSetElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLFrameSetElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoFrameSetElement(mozIDOMWindowProxy window,/* nsIDOMHTMLFrameSetElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Cols
        {
            get { /*return nsString.Get(DOMHTMLElement.GetColsAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetColsAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Rows
        {
            get { /*return nsString.Get(DOMHTMLElement.GetRowsAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetRowsAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}