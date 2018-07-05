namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorkerContainer : WebIDLBase
    {
        
        public ServiceWorkerContainer(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Controller
        {
            get
            {
                return this.GetProperty<nsISupports>("controller");
            }
        }
        
        public Promise < nsISupports > Ready
        {
            get
            {
                return this.GetProperty<Promise < nsISupports >>("ready");
            }
        }
        
        public Promise < nsISupports > Register(USVString scriptURL)
        {
            return this.CallMethod<Promise < nsISupports >>("register", scriptURL);
        }
        
        public Promise < nsISupports > Register(USVString scriptURL, object options)
        {
            return this.CallMethod<Promise < nsISupports >>("register", scriptURL, options);
        }
        
        public Promise <object> GetRegistration()
        {
            return this.CallMethod<Promise <object>>("getRegistration");
        }
        
        public Promise <object> GetRegistration(USVString documentURL)
        {
            return this.CallMethod<Promise <object>>("getRegistration", documentURL);
        }
        
        public Promise < nsISupports[] > GetRegistrations()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getRegistrations");
        }
        
        public string GetScopeForUrl(string url)
        {
            return this.CallMethod<string>("getScopeForUrl", url);
        }
    }
}
