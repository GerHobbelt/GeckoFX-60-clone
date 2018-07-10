namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorStorage : WebIDLBase
    {
        
        public NavigatorStorage(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Storage
        {
            get
            {
                return this.GetProperty<nsISupports>("storage");
            }
        }
    }
}
