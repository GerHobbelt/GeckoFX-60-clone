using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoSelectElement : GeckoHtmlElement
    {
        private readonly nsISupports _window;
        private /* nsIDOMHTMLSelectElement */ nsIDOMElement DOMHTMLElement;
        private Lazy<WebIDL.HTMLSelectElement> _selectElement;

        internal GeckoSelectElement(nsISupports window, /* nsIDOMHTMLSelectElement */ nsIDOMElement element) : base(window, element)
        {
            _window = window;
            this.DOMHTMLElement = element;
            _selectElement = new Lazy<HTMLSelectElement>(() => new HTMLSelectElement((mozIDOMWindowProxy)_window, (nsISupports)element));
        }

        public string Type => _selectElement.Value.Type;

        public int SelectedIndex
        {
            get { return _selectElement.Value.SelectedIndex; }
            set { _selectElement.Value.SelectedIndex = value; }
        }

        public string Value
        {
            get { return _selectElement.Value.Value; }
            set { _selectElement.Value.Value = value; }
        }

        public uint Length
        {
            get { return _selectElement.Value.Length; }
            set { _selectElement.Value.Length = value; }
        }

        public GeckoFormElement Form => new GeckoFormElement(_window, (nsIDOMHTMLFormElement)_selectElement.Value.Form);

        public GeckoOptionsCollection Options => new GeckoOptionsCollection(_selectElement.Value.Options);

        public bool Disabled
        {
            get { return _selectElement.Value.Disabled; }
            set { _selectElement.Value.Disabled = value; }
        }

        public bool Multiple
        {
            get { return _selectElement.Value.Multiple; }
            set { _selectElement.Value.Multiple = value; }
        }

        public string Name
        {
            get { return _selectElement.Value.Name; }
            set { _selectElement.Value.Name = value; }
        }

        public uint Size
        {
            get { return _selectElement.Value.Size; }
            set { _selectElement.Value.Size = value; }
        }

        public void Add(GeckoHtmlElement element, GeckoHtmlElement before)
        {
            // TODO: FIXME: need to be able to use WebIDLUnion to use this method. PORTFF60
            //DOMHTMLElement.Add(element.DomObject as /* /* nsIDOMHTMLElement*/nsISupports, before.DomObject as nsIVariant);
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            _selectElement.Value.Remove(index);            
        }
    }
}