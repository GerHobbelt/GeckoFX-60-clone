using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoMetaElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLMetaElement */ nsISupports DOMHTMLElement;

        internal GeckoMetaElement(/* nsIDOMHTMLMetaElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoMetaElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLMetaElement */ nsISupports;
        }

        public string Content
        {
            get { /*return nsString.Get(DOMHTMLElement.GetContentAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetContentAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string HttpEquiv
        {
            get { /*return nsString.Get(DOMHTMLElement.GetHttpEquivAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHttpEquivAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Scheme
        {
            get { /*return nsString.Get(DOMHTMLElement.GetSchemeAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSchemeAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }
    }
}