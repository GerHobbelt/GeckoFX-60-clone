namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationEffectTimingReadOnly : WebIDLBase
    {
        
        public AnimationEffectTimingReadOnly(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Delay
        {
            get
            {
                return this.GetProperty<double>("delay");
            }
        }
        
        public double EndDelay
        {
            get
            {
                return this.GetProperty<double>("endDelay");
            }
        }
        
        public FillMode Fill
        {
            get
            {
                return this.GetProperty<FillMode>("fill");
            }
        }
        
        public double IterationStart
        {
            get
            {
                return this.GetProperty<double>("iterationStart");
            }
        }
        
        public double Iterations
        {
            get
            {
                return this.GetProperty<double>("iterations");
            }
        }
        
        public WebIDLUnion<System.Double,System.String> Duration
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.Double,System.String>>("duration");
            }
        }
        
        public PlaybackDirection Direction
        {
            get
            {
                return this.GetProperty<PlaybackDirection>("direction");
            }
        }
        
        public string Easing
        {
            get
            {
                return this.GetProperty<string>("easing");
            }
        }
    }
}
