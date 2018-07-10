namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGURIReference : WebIDLBase
    {
        
        public SVGURIReference(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Href
        {
            get
            {
                return this.GetProperty<nsISupports>("href");
            }
        }
    }
}
