namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorkerGlobalScope : WebIDLBase
    {
        
        public ServiceWorkerGlobalScope(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Clients
        {
            get
            {
                return this.GetProperty<nsISupports>("clients");
            }
        }
        
        public nsISupports Registration
        {
            get
            {
                return this.GetProperty<nsISupports>("registration");
            }
        }
        
        public Promise SkipWaiting()
        {
            return this.CallMethod<Promise>("skipWaiting");
        }
    }
}
