using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoInputElement : GeckoHtmlElement
    {
        private nsIDOMHTMLInputElement DOMHTMLElement;
        private Lazy<HTMLInputElement> _inputElement;

        internal GeckoInputElement(nsISupports window, nsIDOMHTMLInputElement element) : base(window, (nsIDOMElement)element)
        {
            this.DOMHTMLElement = element;
            _inputElement = new Lazy<HTMLInputElement>(() => new HTMLInputElement((mozIDOMWindowProxy)window, (nsISupports)element));
        }

        public GeckoInputElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as nsIDOMHTMLInputElement;
        }

        public string DefaultValue
        {
            get { return _inputElement.Value.DefaultValue; }
            set { _inputElement.Value.DefaultValue = value; }
        }

        public bool DefaultChecked
        {
            get { return _inputElement.Value.DefaultChecked; }
            set { _inputElement.Value.DefaultChecked = value; }
        }

        public GeckoFormElement Form => new GeckoFormElement(_window, (nsIDOMHTMLFormElement) _inputElement.Value.Form);

        public string Accept
        {
            get { return _inputElement.Value.Accept; }
            set { _inputElement.Value.Accept = value; }
        }

        public string Align
        {
            get { return _inputElement.Value.Align; }
            set { _inputElement.Value.Align = value; }
        }

        public string Alt
        {
            get { return _inputElement.Value.Alt; }
            set { _inputElement.Value.Alt = value; }
        }

        public bool Checked
        {
            get { return _inputElement.Value.Checked; }
            set { _inputElement.Value.Checked = value; }
        }

        public bool Disabled
        {
            get { return _inputElement.Value.Disabled; }
            set { _inputElement.Value.Disabled = value; }
        }

        public int MaxLength
        {
            get { return _inputElement.Value.MaxLength; }
            set { _inputElement.Value.MaxLength = value; }
        }

        public string Name
        {
            get { return _inputElement.Value.Name; }
            set { _inputElement.Value.Name = value; }
        }

        public bool ReadOnly
        {
            get { return _inputElement.Value.ReadOnly; }
            set { _inputElement.Value.ReadOnly = value; }
        }

        public uint Size
        {
            get { return _inputElement.Value.Size; }
            set { _inputElement.Value.Size = value; }
        }

        public string Src
        {
            get { return _inputElement.Value.Src; }
            set { _inputElement.Value.Src = value; }
        }

        public string Type
        {
            get { return _inputElement.Value.Type; }
            set { _inputElement.Value.Type = value; }
        }

        public string UseMap
        {
            get { return _inputElement.Value.UseMap; }
            set { _inputElement.Value.UseMap = value; }
        }

        public string Value
        {
            get { return _inputElement.Value.Value; }
            set { _inputElement.Value.Value = value; }
        }

        public int SelectionStart
        {
            get { return (int)(_inputElement.Value.SelectionStart ?? 0); }
            set { _inputElement.Value.SelectionStart = (uint)value; }
        }

        public int SelectionEnd
        {
            get { return (int)( _inputElement.Value.SelectionEnd ?? 0); }
            set { _inputElement.Value.SelectionEnd = (uint)value; }
        }

        public void Select()
        {
            _inputElement.Value.Select();
        }
    }
}