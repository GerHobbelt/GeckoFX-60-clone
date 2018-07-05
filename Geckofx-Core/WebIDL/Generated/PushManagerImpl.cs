namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushManagerImpl : WebIDLBase
    {
        
        public PushManagerImpl(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Subscribe()
        {
            return this.CallMethod<Promise < nsISupports >>("subscribe");
        }
        
        public Promise < nsISupports > Subscribe(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("subscribe", options);
        }
        
        public Promise < nsISupports > GetSubscription()
        {
            return this.CallMethod<Promise < nsISupports >>("getSubscription");
        }
        
        public Promise < PushPermissionState > PermissionState()
        {
            return this.CallMethod<Promise < PushPermissionState >>("permissionState");
        }
        
        public Promise < PushPermissionState > PermissionState(object options)
        {
            return this.CallMethod<Promise < PushPermissionState >>("permissionState", options);
        }
    }
}
