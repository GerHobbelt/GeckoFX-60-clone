namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushEvent : WebIDLBase
    {
        
        public PushEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Data
        {
            get
            {
                return this.GetProperty<nsISupports>("data");
            }
        }
    }
}
