namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCDataChannelEvent : WebIDLBase
    {
        
        public RTCDataChannelEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
    }
}
