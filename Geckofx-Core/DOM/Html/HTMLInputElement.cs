using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoInputElement : GeckoHtmlElement
    {
        private nsIDOMHTMLInputElement DOMHTMLElement;

        internal GeckoInputElement(nsISupports window, nsIDOMHTMLInputElement element) : base(window, (nsIDOMElement)element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoInputElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as nsIDOMHTMLInputElement;
        }

        public string DefaultValue
        {
            get { /*return nsString.Get(DOMHTMLElement.GetDefaultValueAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDefaultValueAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public bool DefaultChecked
        {
            get { /*return DOMHTMLElement.GetDefaultCheckedAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDefaultCheckedAttribute(value);*/throw new NotImplementedException(); }
        }

        public GeckoFormElement Form
        {
            get
            {
                //nsIDOMHTMLFormElement formElement = DOMHTMLElement.GetFormAttribute();

                //if (formElement == null)
                //    return null;
                //else
                //    return new GeckoFormElement(formElement);
                throw new NotImplementedException();
            }
        }

        public string Accept
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAcceptAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetAcceptAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Alt
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAltAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAltAttribute(new nsAString(value));*/ throw new NotImplementedException(); }
        }

        public bool Checked
        {
            get { /*return DOMHTMLElement.GetCheckedAttribute();*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetCheckedAttribute(value);*/throw new NotImplementedException(); }
        }

        public bool Disabled
        {
            get {/* return DOMHTMLElement.GetDisabledAttribute();*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetDisabledAttribute(value);*/throw new NotImplementedException(); }
        }

        public int MaxLength
        {
            get { /*return DOMHTMLElement.GetMaxLengthAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMaxLengthAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public bool ReadOnly
        {
            get { /*return DOMHTMLElement.GetReadOnlyAttribute(); */throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetReadOnlyAttribute(value);*/throw new NotImplementedException(); }
        }

        public uint Size
        {
            get { /*return DOMHTMLElement.GetSizeAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSizeAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Src
        {
            get { /*return nsString.Get(DOMHTMLElement.GetSrcAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetSrcAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute); */throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetTypeAttribute(new nsAString(value)); */throw new NotImplementedException(); }
        }

        public string UseMap
        {
            get { /*return nsString.Get(DOMHTMLElement.GetUseMapAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetUseMapAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Value
        {
            get { /*return nsString.Get(DOMHTMLElement.GetValueAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetValueAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public int SelectionStart
        {
            get { /*return DOMHTMLElement.GetSelectionStartAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSelectionStartAttribute(value);*/throw new NotImplementedException(); }
        }

        public int SelectionEnd
        {
            get {/* return DOMHTMLElement.GetSelectionEndAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSelectionEndAttribute(value);*/throw new NotImplementedException(); }
        }

        public void select()
        {
            //DOMHTMLElement.Select();
            throw new NotImplementedException();
        }
    }
}