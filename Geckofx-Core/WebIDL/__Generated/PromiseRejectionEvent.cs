namespace Gecko.WebIDL
{
    using System;
    
    
    public class PromiseRejectionEvent : WebIDLBase
    {
        
        public PromiseRejectionEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> Promise
        {
            get
            {
                return this.GetProperty<Promise <object>>("promise");
            }
        }
        
        public object Reason
        {
            get
            {
                return this.GetProperty<object>("reason");
            }
        }
    }
}
