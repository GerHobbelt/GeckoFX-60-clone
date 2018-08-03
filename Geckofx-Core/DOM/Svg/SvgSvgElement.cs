namespace Gecko.DOM.Svg
{
    public class SvgSvgElement
        : SvgElement
    {
        protected SvgSvgElement(nsISupports window,/* nsIDOMSVGElement */ nsIDOMElement svgSvgElement)
            : base(window, svgSvgElement)
        {
        }

        public static SvgSvgElement CreateSvgSvgElementWrapper(nsISupports window, /* nsIDOMSVGElement */ nsIDOMElement svgSvgElement)
        {
            return svgSvgElement == null ? null : new SvgSvgElement(window, svgSvgElement);
        }
    }
}