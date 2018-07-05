namespace Gecko.WebIDL
{
    using System;
    
    
    public class LinkStyle : WebIDLBase
    {
        
        public LinkStyle(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Sheet
        {
            get
            {
                return this.GetProperty<nsISupports>("sheet");
            }
        }
    }
}
