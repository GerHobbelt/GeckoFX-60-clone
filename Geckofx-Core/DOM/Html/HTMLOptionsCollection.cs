using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoOptionsCollection
    {
        private /* nsIDOMHTMLOptionsCollection */ nsISupports DOMHTMLElement;

        internal GeckoOptionsCollection(/* nsIDOMHTMLOptionsCollection */ nsISupports element)
        {
            this.DOMHTMLElement = element;
        }

        public uint Length
        {
            get { /*return DOMHTMLElement.GetLengthAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetLengthAttribute(value);*/throw new NotImplementedException(); }
        }

        public GeckoOptionElement item(uint index)
        {
            //return new GeckoOptionElement(DOMHTMLElement.Item(index));
            throw new NotImplementedException();
        }

        public GeckoOptionElement namedItem(string name)
        {
            //return new GeckoOptionElement(DOMHTMLElement.NamedItem(new nsAString(name)));
            throw new NotImplementedException();
        }
    }
}