using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoFrameSetElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLFrameSetElement */ nsISupports DOMHTMLElement;

        internal GeckoFrameSetElement(/* nsIDOMHTMLFrameSetElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoFrameSetElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLFrameSetElement */ nsISupports;
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