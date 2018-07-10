namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileSystem : WebIDLBase
    {
        
        public FileSystem(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Name
        {
            get
            {
                return this.GetProperty<USVString>("name");
            }
        }
        
        public nsISupports Root
        {
            get
            {
                return this.GetProperty<nsISupports>("root");
            }
        }
    }
}
