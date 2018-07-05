namespace Gecko.WebIDL
{
    using System;
    
    
    public class VREyeParameters : WebIDLBase
    {
        
        public VREyeParameters(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr Offset
        {
            get
            {
                return this.GetProperty<IntPtr>("offset");
            }
        }
        
        public nsISupports FieldOfView
        {
            get
            {
                return this.GetProperty<nsISupports>("fieldOfView");
            }
        }
        
        public uint RenderWidth
        {
            get
            {
                return this.GetProperty<uint>("renderWidth");
            }
        }
        
        public uint RenderHeight
        {
            get
            {
                return this.GetProperty<uint>("renderHeight");
            }
        }
    }
}
