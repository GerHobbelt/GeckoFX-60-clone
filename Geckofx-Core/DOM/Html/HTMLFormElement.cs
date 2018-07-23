using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoFormElement : GeckoHtmlElement
    {
        private nsIDOMHTMLFormElement DOMHTMLElement;

        internal GeckoFormElement(nsISupports window, nsIDOMHTMLFormElement element) : base(window, (nsIDOMElement)element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoFormElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as nsIDOMHTMLFormElement;
        }

        public GeckoHtmlElementCollection Elements
        {
            get { /*return new GeckoHtmlElementCollection(DOMHTMLElement.GetElementsAttribute());*/throw new NotImplementedException(); }
        }

        public int Length
        {
            get { /*return DOMHTMLElement.GetLengthAttribute();*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string AcceptCharset
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAcceptCharsetAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetAcceptCharsetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Action
        {
            get {/* return nsString.Get(DOMHTMLElement.GetActionAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetActionAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Enctype
        {
            get { /*return nsString.Get(DOMHTMLElement.GetEnctypeAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetEnctypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Method
        {
            get { /*return nsString.Get(DOMHTMLElement.GetMethodAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMethodAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Target
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTargetAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTargetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public void submit()
        {
            //DOMHTMLElement.Submit();
            throw new NotImplementedException();
        }

        public void reset()
        {
            //DOMHTMLElement.Reset();
            throw new NotImplementedException();
        }
    }
}