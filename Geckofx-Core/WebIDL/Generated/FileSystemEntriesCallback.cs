namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystemEntriesCallback : WebIDLBase
    {
        
        public FileSystemEntriesCallback(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent(nsISupports[] entries)
        {
            this.CallVoidMethod("handleEvent", entries);
        }
    }
}
