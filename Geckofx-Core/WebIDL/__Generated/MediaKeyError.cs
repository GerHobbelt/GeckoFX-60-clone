namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeyError : WebIDLBase
    {
        
        public MediaKeyError(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint SystemCode
        {
            get
            {
                return this.GetProperty<uint>("systemCode");
            }
        }
    }
}
