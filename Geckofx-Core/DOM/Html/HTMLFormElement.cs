using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoFormElement : GeckoHtmlElement
    {
        private readonly Lazy<HTMLFormElement> _formElement;

        internal GeckoFormElement(mozIDOMWindowProxy window, nsIDOMHTMLFormElement element) : base(window, (nsIDOMElement)element)
        {            
            _formElement = new Lazy<HTMLFormElement>(() => new HTMLFormElement((mozIDOMWindowProxy)Window, (nsISupports)element));
        }

        public GeckoHtmlElementCollection Elements => new GeckoHtmlElementCollection(Window, _formElement.Value.Elements);

        public int Length => _formElement.Value.Length;

        public string Name
        {
            get { return _formElement.Value.Name; }
            set { _formElement.Value.Name = value; }
        }

        public string AcceptCharset
        {
            get { return _formElement.Value.AcceptCharset; }
            set { _formElement.Value.AcceptCharset = value; }
        }

        public string Action
        {
            get { return _formElement.Value.Action; }
            set { _formElement.Value.Action = value; }
        }

        public string Enctype
        {
            get { return _formElement.Value.Enctype; }
            set { _formElement.Value.Enctype = value; }
        }

        public string Method
        {
            get { return _formElement.Value.Method; }
            set { _formElement.Value.Method = value; }
        }

        public string Target
        {
            get { return _formElement.Value.Target; }
            set { _formElement.Value.Target = value; }
        }

        public void Submit()
        {
            _formElement.Value.Submit();            
        }

        public void Reset()
        {
            _formElement.Value.Reset();            
        }
    }
}
