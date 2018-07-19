using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoBodyElement
        : GeckoHtmlElement
    {
        private /* nsIDOMHTMLBodyElement */ nsIDOMElement _domHtmlBodyElement;

        internal GeckoBodyElement(nsISupports window, /* nsIDOMHTMLBodyElement */ nsIDOMElement element)
            : base(window, element)
        {
            _domHtmlBodyElement = element;
        }

        public string ALink
        {
            get { /*return nsString.Get(_domHtmlBodyElement.GetALinkAttribute);*/throw new NotImplementedException(); }
            set {/* nsString.Set(_domHtmlBodyElement.SetALinkAttribute, value); */throw new NotImplementedException(); }
        }

        public string Background
        {
            get {/* return nsString.Get(_domHtmlBodyElement.GetBackgroundAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlBodyElement.SetBackgroundAttribute, value);*/throw new NotImplementedException(); }
        }

        public string BgColor
        {
            get { /*return nsString.Get(_domHtmlBodyElement.GetBgColorAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlBodyElement.SetBgColorAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Link
        {
            get {/* return nsString.Get(_domHtmlBodyElement.GetLinkAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlBodyElement.SetLinkAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Text
        {
            get { /*return nsString.Get(_domHtmlBodyElement.GetTextAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlBodyElement.SetTextAttribute, value);*/throw new NotImplementedException(); }
        }

        public string VLink
        {
            get { /*return nsString.Get(_domHtmlBodyElement.GetVLinkAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlBodyElement.SetVLinkAttribute, value);*/throw new NotImplementedException(); }
        }
    }
}