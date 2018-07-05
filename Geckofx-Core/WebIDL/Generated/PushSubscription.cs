namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushSubscription : WebIDLBase
    {
        
        public PushSubscription(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Endpoint
        {
            get
            {
                return this.GetProperty<USVString>("endpoint");
            }
        }
        
        public nsISupports Options
        {
            get
            {
                return this.GetProperty<nsISupports>("options");
            }
        }
        
        public IntPtr GetKey(PushEncryptionKeyName name)
        {
            return this.CallMethod<IntPtr>("getKey", name);
        }
        
        public Promise <bool> Unsubscribe()
        {
            return this.CallMethod<Promise <bool>>("unsubscribe");
        }
        
        public object ToJSON()
        {
            return this.CallMethod<object>("toJSON");
        }
    }
}
