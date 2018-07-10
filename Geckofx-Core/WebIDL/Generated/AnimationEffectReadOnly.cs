namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnimationEffectReadOnly : WebIDLBase
    {
        
        public AnimationEffectReadOnly(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Timing
        {
            get
            {
                return this.GetProperty<nsISupports>("timing");
            }
        }
        
        public object GetComputedTiming()
        {
            return this.CallMethod<object>("getComputedTiming");
        }
    }
}
