namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRStageParameters : WebIDLBase
    {
        
        public VRStageParameters(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr SittingToStandingTransform
        {
            get
            {
                return this.GetProperty<IntPtr>("sittingToStandingTransform");
            }
        }
        
        public float SizeX
        {
            get
            {
                return this.GetProperty<float>("sizeX");
            }
        }
        
        public float SizeZ
        {
            get
            {
                return this.GetProperty<float>("sizeZ");
            }
        }
    }
}
