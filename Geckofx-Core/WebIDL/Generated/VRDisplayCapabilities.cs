namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRDisplayCapabilities : WebIDLBase
    {
        
        public VRDisplayCapabilities(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool HasPosition
        {
            get
            {
                return this.GetProperty<bool>("hasPosition");
            }
        }
        
        public bool HasOrientation
        {
            get
            {
                return this.GetProperty<bool>("hasOrientation");
            }
        }
        
        public bool HasExternalDisplay
        {
            get
            {
                return this.GetProperty<bool>("hasExternalDisplay");
            }
        }
        
        public bool CanPresent
        {
            get
            {
                return this.GetProperty<bool>("canPresent");
            }
        }
        
        public uint MaxLayers
        {
            get
            {
                return this.GetProperty<uint>("maxLayers");
            }
        }
    }
}
