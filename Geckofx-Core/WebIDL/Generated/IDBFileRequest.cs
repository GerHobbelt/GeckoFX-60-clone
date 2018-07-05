namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBFileRequest : WebIDLBase
    {
        
        public IDBFileRequest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports FileHandle
        {
            get
            {
                return this.GetProperty<nsISupports>("fileHandle");
            }
        }
        
        public nsISupports LockedFile
        {
            get
            {
                return this.GetProperty<nsISupports>("lockedFile");
            }
        }
    }
}
