using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoSelectElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLSelectElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoSelectElement(nsISupports window, /* nsIDOMHTMLSelectElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Type
        {
            get { /*return nsString.Get(DOMHTMLElement.GetTypeAttribute);*/throw new NotImplementedException(); }
        }

        public int SelectedIndex
        {
            get { /*return DOMHTMLElement.GetSelectedIndexAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSelectedIndexAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Value
        {
            get { /*return nsString.Get(DOMHTMLElement.GetValueAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetValueAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public uint Length
        {
            get { /*return DOMHTMLElement.GetLengthAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetLengthAttribute(value);*/throw new NotImplementedException(); }
        }

        public GeckoFormElement Form
        {
            get
            {
                //var formAttr = DOMHTMLElement.GetFormAttribute();
                //return formAttr == null ? null : new GeckoFormElement(formAttr);
                throw new NotImplementedException();
            }
        }

        public GeckoOptionsCollection Options
        {
            get
            {
                //var optionsAttr = DOMHTMLElement.GetOptionsAttribute();
                //return optionsAttr == null ? null : new GeckoOptionsCollection(optionsAttr);
                throw new NotImplementedException();
            }
        }

        public bool Disabled
        {
            get { /*return DOMHTMLElement.GetDisabledAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetDisabledAttribute(value);*/throw new NotImplementedException(); }
        }

        public bool Multiple
        {
            get { /*return DOMHTMLElement.GetMultipleAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetMultipleAttribute(value);*/throw new NotImplementedException(); }
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public uint Size
        {
            get { /*return DOMHTMLElement.GetSizeAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetSizeAttribute(value);*/throw new NotImplementedException(); }
        }

        public void add(GeckoHtmlElement element, GeckoHtmlElement before)
        {
            //DOMHTMLElement.Add(element.DomObject as /* /* nsIDOMHTMLElement*/nsISupports, before.DomObject as nsIVariant);
            throw new NotImplementedException();
        }

        public void remove(int index)
        {
            //DOMHTMLElement.Remove(index);
            throw new NotImplementedException();
        }
    }
}