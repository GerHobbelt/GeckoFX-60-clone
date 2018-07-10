namespace Gecko.WebIDL
{
    using System;
    
    
    public class AddonManager : WebIDLBase
    {
        
        public AddonManager(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool PermissionPromptsEnabled
        {
            get
            {
                return this.GetProperty<bool>("permissionPromptsEnabled");
            }
        }
        
        public Promise < nsISupports > GetAddonByID(string id)
        {
            return this.CallMethod<Promise < nsISupports >>("getAddonByID", id);
        }
        
        public Promise < nsISupports > CreateInstall()
        {
            return this.CallMethod<Promise < nsISupports >>("createInstall");
        }
        
        public Promise < nsISupports > CreateInstall(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("createInstall", options);
        }
        
        public void EventListenerWasAdded(string type)
        {
            this.CallVoidMethod("eventListenerWasAdded", type);
        }
        
        public void EventListenerWasRemoved(string type)
        {
            this.CallVoidMethod("eventListenerWasRemoved", type);
        }
    }
}
