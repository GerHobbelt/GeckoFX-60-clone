namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRFrameData : WebIDLBase
    {
        
        public VRFrameData(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Timestamp
        {
            get
            {
                return this.GetProperty<double>("timestamp");
            }
        }
        
        public IntPtr LeftProjectionMatrix
        {
            get
            {
                return this.GetProperty<IntPtr>("leftProjectionMatrix");
            }
        }
        
        public IntPtr LeftViewMatrix
        {
            get
            {
                return this.GetProperty<IntPtr>("leftViewMatrix");
            }
        }
        
        public IntPtr RightProjectionMatrix
        {
            get
            {
                return this.GetProperty<IntPtr>("rightProjectionMatrix");
            }
        }
        
        public IntPtr RightViewMatrix
        {
            get
            {
                return this.GetProperty<IntPtr>("rightViewMatrix");
            }
        }
        
        public nsISupports Pose
        {
            get
            {
                return this.GetProperty<nsISupports>("pose");
            }
        }
    }
}
