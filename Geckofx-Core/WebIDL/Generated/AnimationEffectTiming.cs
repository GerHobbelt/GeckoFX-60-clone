namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationEffectTiming : WebIDLBase
    {
        
        public AnimationEffectTiming(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Delay
        {
            get
            {
                return this.GetProperty<double>("delay");
            }
            set
            {
                this.SetProperty("delay", value);
            }
        }
        
        public double EndDelay
        {
            get
            {
                return this.GetProperty<double>("endDelay");
            }
            set
            {
                this.SetProperty("endDelay", value);
            }
        }
        
        public FillMode Fill
        {
            get
            {
                return this.GetProperty<FillMode>("fill");
            }
            set
            {
                this.SetProperty("fill", value);
            }
        }
        
        public double IterationStart
        {
            get
            {
                return this.GetProperty<double>("iterationStart");
            }
            set
            {
                this.SetProperty("iterationStart", value);
            }
        }
        
        public double Iterations
        {
            get
            {
                return this.GetProperty<double>("iterations");
            }
            set
            {
                this.SetProperty("iterations", value);
            }
        }
        
        public WebIDLUnion<System.Double,System.String> Duration
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.Double,System.String>>("duration");
            }
            set
            {
                this.SetProperty("duration", value);
            }
        }
        
        public PlaybackDirection Direction
        {
            get
            {
                return this.GetProperty<PlaybackDirection>("direction");
            }
            set
            {
                this.SetProperty("direction", value);
            }
        }
        
        public string Easing
        {
            get
            {
                return this.GetProperty<string>("easing");
            }
            set
            {
                this.SetProperty("easing", value);
            }
        }
    }
}
