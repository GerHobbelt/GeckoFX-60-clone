namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadHapticActuator : WebIDLBase
    {
        
        public GamepadHapticActuator(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public GamepadHapticActuatorType Type
        {
            get
            {
                return this.GetProperty<GamepadHapticActuatorType>("type");
            }
        }
        
        public Promise <bool> Pulse(double value, double duration)
        {
            return this.CallMethod<Promise <bool>>("pulse", value, duration);
        }
    }
}
