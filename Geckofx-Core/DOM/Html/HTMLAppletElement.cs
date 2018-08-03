using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoAppletElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLAppletElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoAppletElement(nsISupports window, /* nsIDOMHTMLAppletElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Alt
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAltAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAltAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Archive
        {
            get { /*return nsString.Get(DOMHTMLElement.GetArchiveAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetArchiveAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Code
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCodeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCodeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string CodeBase
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCodeBaseAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCodeBaseAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Height
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHeightAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHeightAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public int Hspace
        {
            get { /*return DOMHTMLElement.GetHspaceAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHspaceAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Object
        {
            get { /*return nsString.Get(DOMHTMLElement.GetObjectAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetObjectAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public int Vspace
        {
            get { /*return DOMHTMLElement.GetVspaceAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetVspaceAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Width
        {
            get { /*return nsString.Get(DOMHTMLElement.GetWidthAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}