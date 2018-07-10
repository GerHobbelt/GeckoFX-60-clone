namespace Gecko.WebIDL
{
    using System;
    
    
    public class NotificationEvent : WebIDLBase
    {
        
        public NotificationEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Notification
        {
            get
            {
                return this.GetProperty<nsISupports>("notification");
            }
        }
    }
}
