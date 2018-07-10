namespace Gecko.WebIDL
{
    using System;
    
    
    public class VoidCallback : WebIDLBase
    {
        
        public VoidCallback(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent()
        {
            this.CallVoidMethod("handleEvent");
        }
    }
}
