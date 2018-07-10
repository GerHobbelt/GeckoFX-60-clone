namespace Gecko.WebIDL
{
    using System;
    
    
    public class CredentialsContainer : WebIDLBase
    {
        
        public CredentialsContainer(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Get()
        {
            return this.CallMethod<Promise < nsISupports >>("get");
        }
        
        public Promise < nsISupports > Get(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("get", options);
        }
        
        public Promise < nsISupports > Create()
        {
            return this.CallMethod<Promise < nsISupports >>("create");
        }
        
        public Promise < nsISupports > Create(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("create", options);
        }
        
        public Promise < nsISupports > Store(nsISupports credential)
        {
            return this.CallMethod<Promise < nsISupports >>("store", credential);
        }
        
        public Promise PreventSilentAccess()
        {
            return this.CallMethod<Promise>("preventSilentAccess");
        }
    }
}
