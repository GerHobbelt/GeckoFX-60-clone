namespace Gecko.WebIDL
{
    using System;
    
    
    public class BlobEvent : WebIDLBase
    {
        
        public BlobEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMBlob Data
        {
            get
            {
                return this.GetProperty<nsIDOMBlob>("data");
            }
        }
    }
}
