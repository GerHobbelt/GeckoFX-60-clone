namespace Gecko.WebIDL
{
    using System;
    
    
    public class PromiseNativeHandler : WebIDLBase
    {
        
        public PromiseNativeHandler(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
