using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoAnchorElement : GeckoHtmlElement
    {
        private readonly nsISupports _window;
        private /* nsIDOMHTMLAnchorElement */ nsIDOMElement DOMHTMLElement;
        private Lazy<HTMLAnchorElement> _anchorElement;
        private Lazy<HTMLLinkElement> _linkElement;

        internal GeckoAnchorElement(nsISupports window, /* nsIDOMHTMLAnchorElement */ nsIDOMElement element) : base(window, element)
        {
            _window = window;
            this.DOMHTMLElement = element;
            _anchorElement = new Lazy<HTMLAnchorElement>(() => new HTMLAnchorElement((mozIDOMWindowProxy)_window, (nsISupports)element));
            _linkElement = new Lazy<HTMLLinkElement>(() => new HTMLLinkElement((mozIDOMWindowProxy)_window, (nsISupports)element));
        }

        public string Charset
        {
            get { return _anchorElement.Value.Charset; }
            set { _anchorElement.Value.Charset = value; }
        }

        public string Coords
        {
            get { return _anchorElement.Value.Coords; }
            set { _anchorElement.Value.Coords = value; }
        }

        public string Href
        {
            get { return _linkElement.Value.Href; }
            set { _linkElement.Value.Href = value; }
        }

        public string Hreflang
        {
            get { return _linkElement.Value.Hreflang; }
            set { _linkElement.Value.Hreflang = value; }
        }

        public string Name
        {
            get { return _anchorElement.Value.Name; }
            set { _anchorElement.Value.Name = value; }
        }

        public string Rel
        {
            get { return _anchorElement.Value.Rel; }
            set { _anchorElement.Value.Rel = value; }
        }

        public string Rev
        {
            get { return _anchorElement.Value.Rev; }
            set { _anchorElement.Value.Rev = value; }
        }

        public string Shape
        {
            get { return _anchorElement.Value.Shape; }
            set { _anchorElement.Value.Shape = value; }
        }

        public string Target
        {
            get { return _anchorElement.Value.Target; }
            set { _anchorElement.Value.Target = value; }
        }

        public string Type
        {
            get { return _anchorElement.Value.Type; }
            set { _anchorElement.Value.Type = value; }
        }
    }
}