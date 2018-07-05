namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystemDirectoryReader : WebIDLBase
    {
        
        public FileSystemDirectoryReader(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void ReadEntries(nsISupports successCallback)
        {
            this.CallVoidMethod("readEntries", successCallback);
        }
        
        public void ReadEntries(nsISupports successCallback, nsISupports errorCallback)
        {
            this.CallVoidMethod("readEntries", successCallback, errorCallback);
        }
    }
}
