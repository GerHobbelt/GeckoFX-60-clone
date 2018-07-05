namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystemFileEntry : WebIDLBase
    {
        
        public FileSystemFileEntry(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void File(nsISupports successCallback)
        {
            this.CallVoidMethod("file", successCallback);
        }
        
        public void File(nsISupports successCallback, nsISupports errorCallback)
        {
            this.CallVoidMethod("file", successCallback, errorCallback);
        }
    }
}
