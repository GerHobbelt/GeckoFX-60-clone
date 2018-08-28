using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoTextAreaElement : GeckoHtmlElement
    {        
        private Lazy<HTMLTextAreaElement> _textArea;

        internal GeckoTextAreaElement(mozIDOMWindowProxy window, /* nsIDOMHTMLTextAreaElement */ nsIDOMElement element) : base(window, element)
        {            
            _textArea = new Lazy<HTMLTextAreaElement>(() => new HTMLTextAreaElement(Window, (nsISupports)element));
        }

        #region /* nsIDOMHTMLTextAreaElement */ nsISupports members

        public bool Autofocus
        {
            get { return _textArea.Value.Autofocus; }
            set { _textArea.Value.Autofocus = value; }
        }

        public uint Cols
        {
            get { return _textArea.Value.Cols; }
            set { _textArea.Value.Cols = value; }
        }

        public bool Disabled
        {
            get { return _textArea.Value.Disabled; }
            set { _textArea.Value.Disabled = value; }
        }

        public GeckoFormElement Form => new GeckoFormElement(Window, (nsIDOMHTMLFormElement)_textArea.Value.Form);

        public int MaxLength
        {
            get { return _textArea.Value.MaxLength; }
            set { _textArea.Value.MaxLength = value; }
        }

        public string Name
        {
            get { return _textArea.Value.Name; }
            set { _textArea.Value.Name = value; }
        }

        public string Placeholder
        {
            get { return _textArea.Value.Placeholder; }
            set { _textArea.Value.Placeholder = value; }
        }

        public bool ReadOnly
        {
            get { return _textArea.Value.ReadOnly; }
            set { _textArea.Value.ReadOnly = value; }
        }

        public bool Required
        {
            get { return _textArea.Value.Required; }
            set { _textArea.Value.Required = value; }
        }

        public uint Rows
        {
            get { return _textArea.Value.Rows; }
            set { _textArea.Value.Rows = value; }
        }

        public string Wrap
        {
            get { return _textArea.Value.Wrap; }
            set { _textArea.Value.Wrap = value; }
        }

        public string Type => _textArea.Value.Type;

        public string DefaultValue
        {
            get { return _textArea.Value.DefaultValue; }
            set { _textArea.Value.DefaultValue = value; }
        }

        public string Value
        {
            get { return _textArea.Value.Value; }
            set { _textArea.Value.Value = value; }
        }

        public uint TextLength => _textArea.Value.TextLength;

        public bool WillValidate => _textArea.Value.WillValidate;

        public string ValidationMessage => _textArea.Value.ValidationMessage;

        public bool CheckValidity()
        {
            return _textArea.Value.CheckValidity();            
        }

        public void SetCustomValidity(string error)
        {
            _textArea.Value.SetCustomValidity(error);            
        }

        public void Select()
        {
            _textArea.Value.Select();            
        }

        public uint SelectionStart
        {
            get { return (uint) _textArea.Value.SelectionStart; }
            set { _textArea.Value.SelectionStart = value; }
        }

        public uint SelectionEnd
        {
            get { return (uint) _textArea.Value.SelectionEnd; }
            set { _textArea.Value.SelectionEnd = value; }
        }

        public void SetSelectionRange(uint selectionStart, uint selectionEnd, string direction)
        {
            _textArea.Value.SetSelectionRange(selectionStart, selectionEnd, direction);            
        }

        public string SelectionDirection
        {
            get { return _textArea.Value.SelectionDirection; }
            set { _textArea.Value.SelectionDirection = value; }
        }

        #endregion
    }
}