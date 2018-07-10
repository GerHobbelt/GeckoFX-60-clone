namespace Gecko.WebIDL
{
    using System;
    
    
    public class WheelEvent : WebIDLBase
    {
        
        public WheelEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double DeltaX
        {
            get
            {
                return this.GetProperty<double>("deltaX");
            }
        }
        
        public double DeltaY
        {
            get
            {
                return this.GetProperty<double>("deltaY");
            }
        }
        
        public double DeltaZ
        {
            get
            {
                return this.GetProperty<double>("deltaZ");
            }
        }
        
        public uint DeltaMode
        {
            get
            {
                return this.GetProperty<uint>("deltaMode");
            }
        }
    }
}
