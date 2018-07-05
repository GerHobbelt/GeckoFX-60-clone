namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnectionCloseEvent : WebIDLBase
    {
        
        public PresentationConnectionCloseEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public PresentationConnectionClosedReason Reason
        {
            get
            {
                return this.GetProperty<PresentationConnectionClosedReason>("reason");
            }
        }
        
        public string Message
        {
            get
            {
                return this.GetProperty<string>("message");
            }
        }
    }
}
