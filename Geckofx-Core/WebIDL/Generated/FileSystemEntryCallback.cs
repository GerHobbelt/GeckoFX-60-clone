namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystemEntryCallback : WebIDLBase
    {
        
        public FileSystemEntryCallback(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent(nsISupports entry)
        {
            this.CallVoidMethod("handleEvent", entry);
        }
    }
}
