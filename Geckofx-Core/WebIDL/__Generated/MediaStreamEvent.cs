namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamEvent : WebIDLBase
    {
        
        public MediaStreamEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Stream
        {
            get
            {
                return this.GetProperty<nsISupports>("stream");
            }
        }
    }
}
