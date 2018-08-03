using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoTableCellElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLTableCellElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoTableCellElement(nsISupports window, /* nsIDOMHTMLTableCellElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public int CellIndex
        {
            get { /*return DOMHTMLElement.GetCellIndexAttribute();*/throw new NotImplementedException(); }
        }

        public string Abbr
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAbbrAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAbbrAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Axis
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAxisAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAxisAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string BgColor
        {
            get { /*return nsString.Get(DOMHTMLElement.GetBgColorAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetBgColorAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Ch
        {
            get { /*return nsString.Get(DOMHTMLElement.GetChAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetChAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string ChOff
        {
            get { /*return nsString.Get(DOMHTMLElement.GetChOffAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetChOffAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public int ColSpan
        {
            get { /*return DOMHTMLElement.GetColSpanAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetColSpanAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Headers
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHeadersAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHeadersAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Height
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHeightAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHeightAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public bool NoWrap
        {
            get { /*return DOMHTMLElement.GetNoWrapAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNoWrapAttribute(value);*/throw new NotImplementedException(); }
        }

        public int RowSpan
        {
            get { /*return DOMHTMLElement.GetRowSpanAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetRowSpanAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Scope
        {
            get { /*return nsString.Get(DOMHTMLElement.GetScopeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetScopeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string VAlign
        {
            get { /*return nsString.Get(DOMHTMLElement.GetVAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetVAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Width
        {
            get { /*return nsString.Get(DOMHTMLElement.GetWidthAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}