using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoImageElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLImageElement */ nsIDOMElement DOMHTMLElement;

        internal GeckoImageElement(mozIDOMWindowProxy window, /* nsIDOMHTMLImageElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
        }

        public string Name
        {
            get { /*return nsString.Get(DOMHTMLElement.GetNameAttribute); */throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetNameAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Align
        {
            get { /*return nsString.Get(DOMHTMLElement.GetAlignAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetAlignAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Alt
        {
            get {/* return nsString.Get(DOMHTMLElement.GetAltAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetAltAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Border
        {
            get {/* return nsString.Get(DOMHTMLElement.GetBorderAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetBorderAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public uint Height
        {
            get {/* return DOMHTMLElement.GetHeightAttribute(); */throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetHeightAttribute(value);*/throw new NotImplementedException(); }
        }

        public int Hspace
        {
            get { /*return DOMHTMLElement.GetHspaceAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHspaceAttribute(value);*/throw new NotImplementedException(); }
        }

        public bool IsMap
        {
            get { /*return DOMHTMLElement.GetIsMapAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetIsMapAttribute(value);*/ throw new NotImplementedException(); }
        }

        public string LongDesc
        {
            get {/* return nsString.Get(DOMHTMLElement.GetLongDescAttribute);*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetLongDescAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public string Src
        {
            get {/* return nsString.Get(DOMHTMLElement.GetSrcAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetSrcAttribute(new nsAString(value)); */throw new NotImplementedException(); }
        }

        public string UseMap
        {
            get { /*return nsString.Get(DOMHTMLElement.GetUseMapAttribute);*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetUseMapAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public int Vspace
        {
            get {/* return DOMHTMLElement.GetVspaceAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetVspaceAttribute(value);*/throw new NotImplementedException(); }
        }

        public uint Width
        {
            get { /*return DOMHTMLElement.GetWidthAttribute(); */throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetWidthAttribute(value);*/throw new NotImplementedException(); }
        }
    }
}