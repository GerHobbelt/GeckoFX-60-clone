namespace Gecko.WebIDL
{
    using System;
    
    
    public class Directory : WebIDLBase
    {
        
        public Directory(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Path
        {
            get
            {
                return this.GetProperty<string>("path");
            }
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> GetFilesAndDirectories()
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("getFilesAndDirectories");
        }
        
        public Promise < nsISupports[] > GetFiles()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getFiles");
        }
        
        public Promise < nsISupports[] > GetFiles(bool recursiveFlag)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getFiles", recursiveFlag);
        }
    }
}
