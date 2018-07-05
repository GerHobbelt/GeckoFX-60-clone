namespace Gecko.WebIDL
{
    using System;
    
    
    public class File : WebIDLBase
    {
        
        public File(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public long LastModified
        {
            get
            {
                return this.GetProperty<long>("lastModified");
            }
        }
        
        public IntPtr LastModifiedDate
        {
            get
            {
                return this.GetProperty<IntPtr>("lastModifiedDate");
            }
        }
        
        public USVString WebkitRelativePath
        {
            get
            {
                return this.GetProperty<USVString>("webkitRelativePath");
            }
        }
        
        public string MozFullPath
        {
            get
            {
                return this.GetProperty<string>("mozFullPath");
            }
        }
    }
}
