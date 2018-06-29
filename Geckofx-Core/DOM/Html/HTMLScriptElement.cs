using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoScriptElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLScriptElement */ nsISupports DOMHTMLElement;

        internal GeckoScriptElement(/* nsIDOMHTMLScriptElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoScriptElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLScriptElement */ nsISupports;
        }

        public string Text
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTextAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTextAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string HtmlFor
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHtmlForAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHtmlForAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Event
        {
            get { /*return nsString.Get(DOMHTMLElement.GetEventAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetEventAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Charset
        {
            get { /*return nsString.Get(DOMHTMLElement.GetCharsetAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetCharsetAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public bool Defer
        {
            get { /*return DOMHTMLElement.GetDeferAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDeferAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Src
        {
            get { /*return nsString.Get(DOMHTMLElement.GetSrcAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSrcAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetTypeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}