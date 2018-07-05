namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadServiceTest : WebIDLBase
    {
        
        public GamepadServiceTest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public GamepadMappingType NoMapping
        {
            get
            {
                return this.GetProperty<GamepadMappingType>("noMapping");
            }
        }
        
        public GamepadMappingType StandardMapping
        {
            get
            {
                return this.GetProperty<GamepadMappingType>("standardMapping");
            }
        }
        
        public GamepadHand NoHand
        {
            get
            {
                return this.GetProperty<GamepadHand>("noHand");
            }
        }
        
        public GamepadHand LeftHand
        {
            get
            {
                return this.GetProperty<GamepadHand>("leftHand");
            }
        }
        
        public GamepadHand RightHand
        {
            get
            {
                return this.GetProperty<GamepadHand>("rightHand");
            }
        }
        
        public Promise <uint> AddGamepad(string id, GamepadMappingType mapping, GamepadHand hand, uint numButtons, uint numAxes, uint numHaptics)
        {
            return this.CallMethod<Promise <uint>>("addGamepad", id, mapping, hand, numButtons, numAxes, numHaptics);
        }
        
        public void RemoveGamepad(uint index)
        {
            this.CallVoidMethod("removeGamepad", index);
        }
        
        public void NewButtonEvent(uint index, uint button, bool pressed, bool touched)
        {
            this.CallVoidMethod("newButtonEvent", index, button, pressed, touched);
        }
        
        public void NewButtonValueEvent(uint index, uint button, bool pressed, bool touched, double value)
        {
            this.CallVoidMethod("newButtonValueEvent", index, button, pressed, touched, value);
        }
        
        public void NewAxisMoveEvent(uint index, uint axis, double value)
        {
            this.CallVoidMethod("newAxisMoveEvent", index, axis, value);
        }
        
        public void NewPoseMove(uint index, IntPtr orient, IntPtr pos, IntPtr angVelocity, IntPtr angAcceleration, IntPtr linVelocity, IntPtr linAcceleration)
        {
            this.CallVoidMethod("newPoseMove", index, orient, pos, angVelocity, angAcceleration, linVelocity, linAcceleration);
        }
    }
}
