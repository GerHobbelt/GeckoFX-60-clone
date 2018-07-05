namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyframeEffectReadOnly : WebIDLBase
    {
        
        public KeyframeEffectReadOnly(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<nsIDOMElement,nsISupports> Target
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsIDOMElement,nsISupports>>("target");
            }
        }
        
        public IterationCompositeOperation IterationComposite
        {
            get
            {
                return this.GetProperty<IterationCompositeOperation>("iterationComposite");
            }
        }
        
        public CompositeOperation Composite
        {
            get
            {
                return this.GetProperty<CompositeOperation>("composite");
            }
        }
        
        public object[] GetKeyframes()
        {
            return this.CallMethod<object[]>("getKeyframes");
        }
        
        public object[] GetProperties()
        {
            return this.CallMethod<object[]>("getProperties");
        }
    }
}
