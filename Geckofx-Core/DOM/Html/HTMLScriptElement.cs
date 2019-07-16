using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoScriptElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLScriptElement */ nsIDOMElement DOMHTMLElement;
        private Lazy<HTMLScriptElement> _scriptElement;

        internal GeckoScriptElement(mozIDOMWindowProxy window, /* nsIDOMHTMLScriptElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
            _scriptElement = new Lazy<HTMLScriptElement>(() => new HTMLScriptElement(Window, (nsISupports)element));
        }

        public string Text
        {
            get { return _scriptElement.Value.Text; }
            set { _scriptElement.Value.Text = value; }
        }

        public string HtmlFor
        {
            get { return _scriptElement.Value.HtmlFor; }
            set { _scriptElement.Value.HtmlFor = value; }
        }

        public string Event
        {
            get { return _scriptElement.Value.Event; }
            set { _scriptElement.Value.Event = value; }
        }

        public string Charset
        {
            get { return _scriptElement.Value.Charset; }
            set { _scriptElement.Value.Charset = value; }
        }

        public bool Defer
        {
            get { return _scriptElement.Value.Defer; }
            set { _scriptElement.Value.Defer = value; }
        }

        public string Src
        {
            get { return _scriptElement.Value.Src; }
            set { _scriptElement.Value.Src = value; }
        }

        public string Type
        {
            get { return _scriptElement.Value.Type; }
            set { _scriptElement.Value.Type = value; }
        }
    }
}