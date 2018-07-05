namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadButton : WebIDLBase
    {
        
        public GamepadButton(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Pressed
        {
            get
            {
                return this.GetProperty<bool>("pressed");
            }
        }
        
        public bool Touched
        {
            get
            {
                return this.GetProperty<bool>("touched");
            }
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
        }
    }
}
