namespace Gecko.WebIDL
{
    using System;
    
    
    public class GlobalU2F : WebIDLBase
    {
        
        public GlobalU2F(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports U2f
        {
            get
            {
                return this.GetProperty<nsISupports>("u2f");
            }
        }
    }
}
