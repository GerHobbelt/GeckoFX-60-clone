namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRDisplayEvent : WebIDLBase
    {
        
        public VRDisplayEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Display
        {
            get
            {
                return this.GetProperty<nsISupports>("display");
            }
        }
        
        public VRDisplayEventReason Reason
        {
            get
            {
                return this.GetProperty<VRDisplayEventReason>("reason");
            }
        }
    }
}
