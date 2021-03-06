using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoMetaElement : GeckoHtmlElement
    {
        internal GeckoMetaElement(mozIDOMWindowProxy window, /* nsIDOMHTMLMetaElement */ nsIDOMElement element) : base(window, element)
        {
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