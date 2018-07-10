namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceMotionEvent : WebIDLBase
    {
        
        public DeviceMotionEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Acceleration
        {
            get
            {
                return this.GetProperty<nsISupports>("acceleration");
            }
        }
        
        public nsISupports AccelerationIncludingGravity
        {
            get
            {
                return this.GetProperty<nsISupports>("accelerationIncludingGravity");
            }
        }
        
        public nsISupports RotationRate
        {
            get
            {
                return this.GetProperty<nsISupports>("rotationRate");
            }
        }
        
        public System.Nullable<double> Interval
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("interval");
            }
        }
        
        public void InitDeviceMotionEvent(string type)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type);
        }
        
        public void InitDeviceMotionEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble);
        }
        
        public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable);
        }
        
        public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, object acceleration)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable, acceleration);
        }
        
        public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, object acceleration, object accelerationIncludingGravity)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable, acceleration, accelerationIncludingGravity);
        }
        
        public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, object acceleration, object accelerationIncludingGravity, object rotationRate)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable, acceleration, accelerationIncludingGravity, rotationRate);
        }
        
        public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, object acceleration, object accelerationIncludingGravity, object rotationRate, System.Nullable<double> interval)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable, acceleration, accelerationIncludingGravity, rotationRate, interval);
        }
    }
}
