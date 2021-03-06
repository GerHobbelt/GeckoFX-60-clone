namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceLightEvent : WebIDLBase
    {
        
        public DeviceLightEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
        }
    }
}
