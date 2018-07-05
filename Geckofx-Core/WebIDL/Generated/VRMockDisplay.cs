namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRMockDisplay : WebIDLBase
    {
        
        public VRMockDisplay(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SetEyeResolution(uint aRenderWidth, uint aRenderHeight)
        {
            this.CallVoidMethod("setEyeResolution", aRenderWidth, aRenderHeight);
        }
        
        public void SetEyeParameter(VREye eye, double offsetX, double offsetY, double offsetZ, double upDegree, double rightDegree, double downDegree, double leftDegree)
        {
            this.CallVoidMethod("setEyeParameter", eye, offsetX, offsetY, offsetZ, upDegree, rightDegree, downDegree, leftDegree);
        }
        
        public void SetPose(IntPtr position, IntPtr linearVelocity, IntPtr linearAcceleration, IntPtr orientation, IntPtr angularVelocity, IntPtr angularAcceleration)
        {
            this.CallVoidMethod("setPose", position, linearVelocity, linearAcceleration, orientation, angularVelocity, angularAcceleration);
        }
        
        public void SetMountState(bool isMounted)
        {
            this.CallVoidMethod("setMountState", isMounted);
        }
        
        public void Update()
        {
            this.CallVoidMethod("update");
        }
    }
}
