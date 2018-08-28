using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM.Svg
{
    public class SvgElement
        : GeckoElement
    {
        private /* nsIDOMSVGElement */ nsIDOMElement _svgElement;

        protected SvgElement(mozIDOMWindowProxy window, /* nsIDOMSVGElement */ nsIDOMElement svgElement)
            : base(window, svgElement)
        {
            _svgElement = svgElement;
        }

        public string ID
        {
            get { /*return nsString.Get(_svgElement.GetIdAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_svgElement.SetIdAttribute, value);*/throw new NotImplementedException(); }
        }

        public SvgSvgElement OwnerSvgElement
        {
            get { /*return _svgElement.GetOwnerSVGElementAttribute().Wrap(SvgSvgElement.CreateSvgSvgElementWrapper);*/throw new NotImplementedException(); }
        }

        public SvgElement ViewportElement
        {
            get { /*return _svgElement.GetViewportElementAttribute().Wrap(CreateSvgElementWrapper);*/throw new NotImplementedException(); }
        }

        public static SvgElement CreateSvgElementWrapper(mozIDOMWindowProxy window,/* nsIDOMSVGElement */ nsIDOMElement svgElement)
        {
            return svgElement == null ? null : new SvgElement(window, svgElement);
        }
    }
}