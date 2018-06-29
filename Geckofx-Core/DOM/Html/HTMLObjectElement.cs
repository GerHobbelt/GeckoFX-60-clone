using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoObjectElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLObjectElement */ nsISupports DOMHTMLElement;

        internal GeckoObjectElement(/* nsIDOMHTMLObjectElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoObjectElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLObjectElement */ nsISupports;
        }

        public GeckoFormElement Form
        {
            get { /*return new GeckoFormElement(DOMHTMLElement.GetFormAttribute());*/throw new NotImplementedException(); }
        }

        public string Code
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCodeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCodeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Archive
        {
            get { /*return nsString.Get(DOMHTMLElement.GetArchiveAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetArchiveAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Border
        {
            get { /*return nsString.Get(DOMHTMLElement.GetBorderAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetBorderAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string CodeBase
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCodeBaseAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCodeBaseAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string CodeType
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCodeTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCodeTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Data
        {
            get { /*return nsString.Get(DOMHTMLElement.GetDataAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDataAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public bool Declare
        {
            get { /*return DOMHTMLElement.GetDeclareAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDeclareAttribute(value);*/throw new NotImplementedException(); }
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

        public string Standby
        {
            get { /*return nsString.Get(DOMHTMLElement.GetStandbyAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetStandbyAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string UseMap
        {
            get { /*return nsString.Get(DOMHTMLElement.GetUseMapAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetUseMapAttribute(new nsAString(value));*/throw new NotImplementedException(); }
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

        public GeckoDocument ContentDocument
        {
            get
            {
                //var doc = DOMHTMLElement.GetContentDocumentAttribute() as nsIDOMHTMLDocument;
                //return (doc == null) ? null : new GeckoDocument(doc);
                throw new NotImplementedException();
            }
        }
    }
}