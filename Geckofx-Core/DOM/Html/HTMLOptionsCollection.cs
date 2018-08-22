using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoOptionsCollection
    {
        private readonly nsISupports _window;
        private Lazy<NamedNodeMap> _optionsCollection;

        internal GeckoOptionsCollection(nsISupports window, /* nsIDOMHTMLOptionsCollection */ nsISupports element)
        {
            _window = window;
            _optionsCollection = new Lazy<NamedNodeMap>(() => new NamedNodeMap((mozIDOMWindowProxy)window, element));
        }

        public uint Length => _optionsCollection.Value.Length;

        public GeckoOptionElement Item(uint index)
        {
            return new GeckoOptionElement(_window, (nsIDOMElement)_optionsCollection.Value.Item(index));
        }

        public GeckoOptionElement NamedItem(string name)
        {
            return new GeckoOptionElement(_window, (nsIDOMElement)_optionsCollection.Value.GetNamedItem(name));
        }
    }
}