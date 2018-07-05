namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGViewElement : WebIDLBase
    {
        
        public SVGViewElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ViewTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("viewTarget");
            }
        }
    }
}
