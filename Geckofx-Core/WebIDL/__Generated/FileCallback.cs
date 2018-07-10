namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileCallback : WebIDLBase
    {
        
        public FileCallback(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent(nsISupports file)
        {
            this.CallVoidMethod("handleEvent", file);
        }
    }
}
