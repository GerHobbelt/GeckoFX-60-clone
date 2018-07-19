using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoCanvasElement : GeckoHtmlElement
    {
        private /* nsIDOMHTMLCanvasElement */ nsIDOMElement DOMHTMLElement;
        private Lazy<HTMLCanvasElement> _canvasElement;

        internal GeckoCanvasElement(nsISupports window, /* nsIDOMHTMLCanvasElement */ nsIDOMElement element) : base(window, element)
        {
            this.DOMHTMLElement = element;
            _canvasElement = new Lazy<HTMLCanvasElement>(() => new HTMLCanvasElement((mozIDOMWindowProxy)window, (nsISupports)DOMHTMLElement));
        }

        public GeckoCanvasElement(object element) : base(element as /* /* nsIDOMHTMLElement*/nsISupports)
        {
            throw new NotImplementedException("use other constructor");
        }

        public uint Width
        {
            get { return _canvasElement.Value.Width; }
            set { _canvasElement.Value.Width = value; }
        }

        public uint Height
        {
            get { return _canvasElement.Value.Height; }
            set { _canvasElement.Value.Height = value; }
        }

        public string ToDataURL(string type)
        {
            return _canvasElement.Value.ToDataURL(type);
        }
    }
}