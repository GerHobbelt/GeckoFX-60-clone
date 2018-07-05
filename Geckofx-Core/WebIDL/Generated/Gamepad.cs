namespace Gecko.WebIDL
{
    using System;
    
    
    public class Gamepad : WebIDLBase
    {
        
        public Gamepad(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public uint Index
        {
            get
            {
                return this.GetProperty<uint>("index");
            }
        }
        
        public GamepadMappingType Mapping
        {
            get
            {
                return this.GetProperty<GamepadMappingType>("mapping");
            }
        }
        
        public GamepadHand Hand
        {
            get
            {
                return this.GetProperty<GamepadHand>("hand");
            }
        }
        
        public uint DisplayId
        {
            get
            {
                return this.GetProperty<uint>("displayId");
            }
        }
        
        public bool Connected
        {
            get
            {
                return this.GetProperty<bool>("connected");
            }
        }
        
        public nsISupports[] Buttons
        {
            get
            {
                return this.GetProperty<nsISupports[]>("buttons");
            }
        }
        
        public double[] Axes
        {
            get
            {
                return this.GetProperty<double[]>("axes");
            }
        }
        
        public double Timestamp
        {
            get
            {
                return this.GetProperty<double>("timestamp");
            }
        }
        
        public nsISupports Pose
        {
            get
            {
                return this.GetProperty<nsISupports>("pose");
            }
        }
        
        public nsISupports[] HapticActuators
        {
            get
            {
                return this.GetProperty<nsISupports[]>("hapticActuators");
            }
        }
    }
}
