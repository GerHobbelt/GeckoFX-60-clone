namespace Gecko.WebIDL
{
    using System;
    
    
    public class ErrorCallback : WebIDLBase
    {
        
        public ErrorCallback(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent(nsIDOMDOMException err)
        {
            this.CallVoidMethod("handleEvent", err);
        }
    }
}
