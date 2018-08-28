namespace Gecko.DOM.Svg
{
    public class SvgSvgElement
        : SvgElement
    {
        protected SvgSvgElement(mozIDOMWindowProxy window,/* nsIDOMSVGElement */ nsIDOMElement svgSvgElement)
            : base(window, svgSvgElement)
        {
        }

        public static SvgSvgElement CreateSvgSvgElementWrapper(mozIDOMWindowProxy window, /* nsIDOMSVGElement */ nsIDOMElement svgSvgElement)
        {
            return svgSvgElement == null ? null : new SvgSvgElement(window, svgSvgElement);
        }
    }
}