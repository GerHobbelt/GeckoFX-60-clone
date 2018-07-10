namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushSubscriptionOptions : WebIDLBase
    {
        
        public PushSubscriptionOptions(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr ApplicationServerKey
        {
            get
            {
                return this.GetProperty<IntPtr>("applicationServerKey");
            }
        }
    }
}
