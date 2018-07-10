namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystemEntry : WebIDLBase
    {
        
        public FileSystemEntry(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool IsFile
        {
            get
            {
                return this.GetProperty<bool>("isFile");
            }
        }
        
        public bool IsDirectory
        {
            get
            {
                return this.GetProperty<bool>("isDirectory");
            }
        }
        
        public USVString Name
        {
            get
            {
                return this.GetProperty<USVString>("name");
            }
        }
        
        public USVString FullPath
        {
            get
            {
                return this.GetProperty<USVString>("fullPath");
            }
        }
        
        public nsISupports Filesystem
        {
            get
            {
                return this.GetProperty<nsISupports>("filesystem");
            }
        }
        
        public void GetParent()
        {
            this.CallVoidMethod("getParent");
        }
        
        public void GetParent(nsISupports successCallback)
        {
            this.CallVoidMethod("getParent", successCallback);
        }
        
        public void GetParent(nsISupports successCallback, nsISupports errorCallback)
        {
            this.CallVoidMethod("getParent", successCallback, errorCallback);
        }
    }
}
