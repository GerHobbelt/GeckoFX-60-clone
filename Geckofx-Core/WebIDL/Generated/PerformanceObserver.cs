namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceObserver : WebIDLBase
    {
        
        public PerformanceObserver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Observe(object options)
        {
            this.CallVoidMethod("observe", options);
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
        
        public nsISupports[] TakeRecords()
        {
            return this.CallMethod<nsISupports[]>("takeRecords");
        }
    }
}
