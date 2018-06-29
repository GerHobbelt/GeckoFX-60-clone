using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    public class GeckoCanvasElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLCanvasElement */ nsISupports DOMHTMLElement;

        internal GeckoCanvasElement(/* nsIDOMHTMLCanvasElement */ nsISupports element) : base(element)
        {
            this.DOMHTMLElement = element;
        }

        public GeckoCanvasElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            this.DOMHTMLElement = element as /* nsIDOMHTMLCanvasElement */ nsISupports;
        }

        public uint Width
        {
            get { /*return DOMHTMLElement.GetWidthAttribute();*/throw new NotImplementedException(); }
            set {/* DOMHTMLElement.SetWidthAttribute(value);*/throw new NotImplementedException(); }
        }

        public uint Height
        {
            get { /*return DOMHTMLElement.GetHeightAttribute();*/throw new NotImplementedException(); }
            set { /*DOMHTMLElement.SetHeightAttribute(value);*/throw new NotImplementedException(); }
        }

        public string ToDataURL(string type)
        {
            using (var context = new AutoJSContext(AutoJSContext.SafeJSContext))
            using (nsAString retval = new nsAString(), param = new nsAString(type))
            {
                JsVal js = default(JsVal);
                //DOMHTMLElement.ToDataURL(param, ref js, context.ContextPointer, retval);
                throw new NotImplementedException();
                return retval.ToString();
            }
        }
    }
}