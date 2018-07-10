namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGStopElement : WebIDLBase
    {
        
        public SVGStopElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Offset
        {
            get
            {
                return this.GetProperty<nsISupports>("offset");
            }
        }
    }
}
