namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnectionAvailableEvent : WebIDLBase
    {
        
        public PresentationConnectionAvailableEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Connection
        {
            get
            {
                return this.GetProperty<nsISupports>("connection");
            }
        }
    }
}
