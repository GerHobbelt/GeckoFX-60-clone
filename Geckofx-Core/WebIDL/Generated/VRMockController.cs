namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRMockController : WebIDLBase
    {
        
        public VRMockController(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void NewButtonEvent(uint button, bool pressed)
        {
            this.CallVoidMethod("newButtonEvent", button, pressed);
        }
        
        public void NewAxisMoveEvent(uint axis, double value)
        {
            this.CallVoidMethod("newAxisMoveEvent", axis, value);
        }
        
        public void NewPoseMove(IntPtr position, IntPtr linearVelocity, IntPtr linearAcceleration, IntPtr orientation, IntPtr angularVelocity, IntPtr angularAcceleration)
        {
            this.CallVoidMethod("newPoseMove", position, linearVelocity, linearAcceleration, orientation, angularVelocity, angularAcceleration);
        }
    }
}
