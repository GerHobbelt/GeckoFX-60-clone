namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioParam : WebIDLBase
    {
        
        public AudioParam(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float Value
        {
            get
            {
                return this.GetProperty<float>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public float DefaultValue
        {
            get
            {
                return this.GetProperty<float>("defaultValue");
            }
        }
        
        public float MinValue
        {
            get
            {
                return this.GetProperty<float>("minValue");
            }
        }
        
        public float MaxValue
        {
            get
            {
                return this.GetProperty<float>("maxValue");
            }
        }
        
        public nsISupports SetValueAtTime(float value, double startTime)
        {
            return this.CallMethod<nsISupports>("setValueAtTime", value, startTime);
        }
        
        public nsISupports LinearRampToValueAtTime(float value, double endTime)
        {
            return this.CallMethod<nsISupports>("linearRampToValueAtTime", value, endTime);
        }
        
        public nsISupports ExponentialRampToValueAtTime(float value, double endTime)
        {
            return this.CallMethod<nsISupports>("exponentialRampToValueAtTime", value, endTime);
        }
        
        public nsISupports SetTargetAtTime(float target, double startTime, double timeConstant)
        {
            return this.CallMethod<nsISupports>("setTargetAtTime", target, startTime, timeConstant);
        }
        
        public nsISupports SetValueCurveAtTime(IntPtr values, double startTime, double duration)
        {
            return this.CallMethod<nsISupports>("setValueCurveAtTime", values, startTime, duration);
        }
        
        public nsISupports CancelScheduledValues(double startTime)
        {
            return this.CallMethod<nsISupports>("cancelScheduledValues", startTime);
        }
        
        public uint ParentNodeId
        {
            get
            {
                return this.GetProperty<uint>("parentNodeId");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
    }
}
