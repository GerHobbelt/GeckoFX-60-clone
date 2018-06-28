namespace Gecko.DOM.Svg
{
    public class SvgSvgElement
        : SvgElement
    {
        protected SvgSvgElement(/* nsIDOMSVGElement */ nsISupports svgSvgElement)
            : base(svgSvgElement)
        {
        }

        public static SvgSvgElement CreateSvgSvgElementWrapper(/* nsIDOMSVGElement */ nsISupports svgSvgElement)
        {
            return svgSvgElement == null ? null : new SvgSvgElement(svgSvgElement);
        }
    }
}