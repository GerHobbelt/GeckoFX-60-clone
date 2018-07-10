namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystemDirectoryEntry : WebIDLBase
    {
        
        public FileSystemDirectoryEntry(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateReader()
        {
            return this.CallMethod<nsISupports>("createReader");
        }
        
        public void GetFile()
        {
            this.CallVoidMethod("getFile");
        }
        
        public void GetFile(USVString path)
        {
            this.CallVoidMethod("getFile", path);
        }
        
        public void GetFile(USVString path, object options)
        {
            this.CallVoidMethod("getFile", path, options);
        }
        
        public void GetFile(USVString path, object options, nsISupports successCallback)
        {
            this.CallVoidMethod("getFile", path, options, successCallback);
        }
        
        public void GetFile(USVString path, object options, nsISupports successCallback, nsISupports errorCallback)
        {
            this.CallVoidMethod("getFile", path, options, successCallback, errorCallback);
        }
        
        public void GetDirectory()
        {
            this.CallVoidMethod("getDirectory");
        }
        
        public void GetDirectory(USVString path)
        {
            this.CallVoidMethod("getDirectory", path);
        }
        
        public void GetDirectory(USVString path, object options)
        {
            this.CallVoidMethod("getDirectory", path, options);
        }
        
        public void GetDirectory(USVString path, object options, nsISupports successCallback)
        {
            this.CallVoidMethod("getDirectory", path, options, successCallback);
        }
        
        public void GetDirectory(USVString path, object options, nsISupports successCallback, nsISupports errorCallback)
        {
            this.CallVoidMethod("getDirectory", path, options, successCallback, errorCallback);
        }
    }
}
