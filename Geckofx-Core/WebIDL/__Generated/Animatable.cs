namespace Gecko.WebIDL
{
    using System;
    
    
    public class Animatable : WebIDLBase
    {
        
        public Animatable(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Animate(object keyframes)
        {
            return this.CallMethod<nsISupports>("animate", keyframes);
        }
        
        public nsISupports Animate(object keyframes, WebIDLUnion<Double,Object> options)
        {
            return this.CallMethod<nsISupports>("animate", keyframes, options);
        }
        
        public nsISupports[] GetAnimations()
        {
            return this.CallMethod<nsISupports[]>("getAnimations");
        }
        
        public nsISupports[] GetAnimations(object filter)
        {
            return this.CallMethod<nsISupports[]>("getAnimations", filter);
        }
    }
}
