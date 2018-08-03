using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoTextAreaElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLTextAreaElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoTextAreaElement(nsISupports window, /* nsIDOMHTMLTextAreaElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        #region /* nsIDOMHTMLTextAreaElement */ nsISupports members

        public bool Autofocus
        {
            get { /*return DOMHTMLElement.GetAutofocusAttribute(); */throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAutofocusAttribute(value); */throw new NotImplementedException(); }
        }

        public uint Cols
        {
            get { /*return DOMHTMLElement.GetColsAttribute(); */throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetColsAttribute(value); */throw new NotImplementedException(); }
        }

        public bool Disabled
        {
            get { /*return DOMHTMLElement.GetDisabledAttribute(); */throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDisabledAttribute(value); */throw new NotImplementedException(); }
        }

        public GeckoFormElement Form
        {
            get { /*return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); */throw new NotImplementedException(); }
        }

        public int MaxLength
        {
            get { /*return DOMHTMLElement.GetMaxLengthAttribute(); */throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMaxLengthAttribute(value); */throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute); */throw new NotImplementedException(); }
            set { /*nsString.Set(DOMHTMLElement.SetNameAttribute, value); */throw new NotImplementedException(); }
        }

        public string Placeholder
        {
            get { /*return nsString.Get(DOMHTMLElement.GetPlaceholderAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(DOMHTMLElement.SetPlaceholderAttribute, value);*/throw new NotImplementedException(); }
        }

        public bool ReadOnly
        {
            get { /*return DOMHTMLElement.GetReadOnlyAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetReadOnlyAttribute(value); */throw new NotImplementedException(); }
        }

        public bool Required
        {
            get { /*return DOMHTMLElement.GetRequiredAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetRequiredAttribute(value);*/throw new NotImplementedException(); }
        }

        public uint Rows
        {
            get { /*return DOMHTMLElement.GetRowsAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetRowsAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Wrap
        {
            get { /*return nsString.Get(DOMHTMLElement.GetWrapAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(DOMHTMLElement.SetWrapAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
        }

        public string DefaultValue
        {
            get { /*return nsString.Get(DOMHTMLElement.GetDefaultValueAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(DOMHTMLElement.SetDefaultValueAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Value
        {
            get { /*return nsString.Get(DOMHTMLElement.GetValueAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(DOMHTMLElement.SetValueAttribute, value);*/throw new NotImplementedException(); }
        }

        public int TextLength
        {
            get { /*return DOMHTMLElement.GetTextLengthAttribute();*/throw new NotImplementedException(); }
        }

        public bool WillValidate
        {
            get { /*return DOMHTMLElement.GetWillValidateAttribute();*/throw new NotImplementedException(); }
        }

        public string ValidationMessage
        {
            get { /*return nsString.Get(DOMHTMLElement.GetValidationMessageAttribute);*/throw new NotImplementedException(); }
        }

        public bool CheckValidity()
        {
            //return DOMHTMLElement.CheckValidity();
            throw new NotImplementedException();
        }

        public void SetCustomValidity(string error)
        {
            //DOMHTMLElement.SetCustomValidity(new nsAString(error));
            throw new NotImplementedException();
        }

        public void Select()
        {
            //DOMHTMLElement.Select();
            throw new NotImplementedException();
        }

        public int SelectionStart
        {
            get { /*return DOMHTMLElement.GetSelectionStartAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSelectionStartAttribute(value);*/throw new NotImplementedException(); }
        }

        public int SelectionEnd
        {
            get { /*return DOMHTMLElement.GetSelectionEndAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSelectionEndAttribute(value);*/throw new NotImplementedException(); }
        }

        public void SetSelectionRange(int selectionStart, int selectionEnd, string direction)
        {
            //DOMHTMLElement.SetSelectionRange(selectionStart, selectionEnd, new nsAString(direction));
            throw new NotImplementedException();
        }

        public string SelectionDirection
        {
            get { /*return nsString.Get(DOMHTMLElement.GetSelectionDirectionAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(DOMHTMLElement.SetSelectionDirectionAttribute, value);*/throw new NotImplementedException(); }
        }

        #endregion
    }
}