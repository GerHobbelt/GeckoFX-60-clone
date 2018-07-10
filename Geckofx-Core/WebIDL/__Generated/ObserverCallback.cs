namespace Gecko.WebIDL
{
    using System;
    
    
    public class ObserverCallback : WebIDLBase
    {
        
        public ObserverCallback(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent(nsISupports observer)
        {
            this.CallVoidMethod("handleEvent", observer);
        }
    }
}
