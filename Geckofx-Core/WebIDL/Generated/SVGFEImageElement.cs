namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEImageElement : WebIDLBase
    {
        
        public SVGFEImageElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports PreserveAspectRatio
        {
            get
            {
                return this.GetProperty<nsISupports>("preserveAspectRatio");
            }
        }
    }
}
