namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGElement : WebIDLBase
    {
        
        public SVGElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public nsISupports ClassName
        {
            get
            {
                return this.GetProperty<nsISupports>("className");
            }
        }
        
        public /* nsIDOMCSSStyleDeclaration */ nsISupports Style
        {
            get
            {
                return this.GetProperty</* nsIDOMCSSStyleDeclaration */ nsISupports>("style");
            }
        }
        
        public nsISupports OwnerSVGElement
        {
            get
            {
                return this.GetProperty<nsISupports>("ownerSVGElement");
            }
        }
        
        public nsISupports ViewportElement
        {
            get
            {
                return this.GetProperty<nsISupports>("viewportElement");
            }
        }
    }
}
