namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorConcurrentHardware : WebIDLBase
    {
        
        public NavigatorConcurrentHardware(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong HardwareConcurrency
        {
            get
            {
                return this.GetProperty<ulong>("hardwareConcurrency");
            }
        }
    }
}
