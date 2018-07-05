namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRPose : WebIDLBase
    {
        
        public VRPose(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr Position
        {
            get
            {
                return this.GetProperty<IntPtr>("position");
            }
        }
        
        public IntPtr LinearVelocity
        {
            get
            {
                return this.GetProperty<IntPtr>("linearVelocity");
            }
        }
        
        public IntPtr LinearAcceleration
        {
            get
            {
                return this.GetProperty<IntPtr>("linearAcceleration");
            }
        }
        
        public IntPtr Orientation
        {
            get
            {
                return this.GetProperty<IntPtr>("orientation");
            }
        }
        
        public IntPtr AngularVelocity
        {
            get
            {
                return this.GetProperty<IntPtr>("angularVelocity");
            }
        }
        
        public IntPtr AngularAcceleration
        {
            get
            {
                return this.GetProperty<IntPtr>("angularAcceleration");
            }
        }
    }
}
