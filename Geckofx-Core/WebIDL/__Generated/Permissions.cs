namespace Gecko.WebIDL
{
    using System;
    
    
    public class Permissions : WebIDLBase
    {
        
        public Permissions(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Query(object permission)
        {
            return this.CallMethod<Promise < nsISupports >>("query", permission);
        }
        
        public Promise < nsISupports > Revoke(object permission)
        {
            return this.CallMethod<Promise < nsISupports >>("revoke", permission);
        }
    }
}
