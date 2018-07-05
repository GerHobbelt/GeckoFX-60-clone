namespace Gecko.WebIDL
{
    using System;
    
    
    public class UserProximityEvent : WebIDLBase
    {
        
        public UserProximityEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Near
        {
            get
            {
                return this.GetProperty<bool>("near");
            }
        }
    }
}
