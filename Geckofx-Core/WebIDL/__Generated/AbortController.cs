namespace Gecko.WebIDL
{
    using System;
    
    
    public class AbortController : WebIDLBase
    {
        
        public AbortController(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Signal
        {
            get
            {
                return this.GetProperty<nsISupports>("signal");
            }
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
    }
}
