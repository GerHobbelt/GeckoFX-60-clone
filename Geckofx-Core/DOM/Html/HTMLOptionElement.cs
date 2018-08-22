using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoOptionElement : GeckoHtmlElement
    {
        private Lazy<HTMLOptionElement> _optionElement;

        internal GeckoOptionElement(nsISupports window, /* nsIDOMHTMLOptionElement */ nsIDOMElement element) : base(window, element)
        {
            _optionElement = new Lazy<HTMLOptionElement>(() => new HTMLOptionElement((mozIDOMWindowProxy)Window, (nsISupports)element));
        }

        public GeckoFormElement Form => new GeckoFormElement(Window, (nsIDOMHTMLFormElement)_optionElement.Value.Form);

        public bool DefaultSelected
        {
            get { return _optionElement.Value.DefaultSelected; }
            set { _optionElement.Value.DefaultSelected = value; }
        }

        public string Text => _optionElement.Value.Text;

        public int Index => _optionElement.Value.Index;

        public bool Disabled
        {
            get { return _optionElement.Value.Disabled; }
            set { _optionElement.Value.Disabled = value; }
        }

        public string Label
        {
            get { return _optionElement.Value.Label; }
            set { _optionElement.Value.Label = value; }
        }

        public bool Selected
        {
            get { return _optionElement.Value.Selected; }
            set { _optionElement.Value.Selected = value; }
        }

        public string Value
        {
            get { return _optionElement.Value.Value; }
            set { _optionElement.Value.Value = value; }
        }
    }
}