namespace Gecko.WebIDL
{
    using System;
    
    
    public class StorageManager : WebIDLBase
    {
        
        public StorageManager(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <bool> Persisted()
        {
            return this.CallMethod<Promise <bool>>("persisted");
        }
        
        public Promise <bool> Persist()
        {
            return this.CallMethod<Promise <bool>>("persist");
        }
        
        public Promise <object> Estimate()
        {
            return this.CallMethod<Promise <object>>("estimate");
        }
    }
}
