namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadPose : WebIDLBase
    {
        
        public GamepadPose(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool HasOrientation
        {
            get
            {
                return this.GetProperty<bool>("hasOrientation");
            }
        }
        
        public bool HasPosition
        {
            get
            {
                return this.GetProperty<bool>("hasPosition");
            }
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
