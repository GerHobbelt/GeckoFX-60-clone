namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyframeEffect : WebIDLBase
    {
        
        public KeyframeEffect(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<nsIDOMElement,nsISupports> Target
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsIDOMElement,nsISupports>>("target");
            }
            set
            {
                this.SetProperty("target", value);
            }
        }
        
        public IterationCompositeOperation IterationComposite
        {
            get
            {
                return this.GetProperty<IterationCompositeOperation>("iterationComposite");
            }
            set
            {
                this.SetProperty("iterationComposite", value);
            }
        }
        
        public CompositeOperation Composite
        {
            get
            {
                return this.GetProperty<CompositeOperation>("composite");
            }
            set
            {
                this.SetProperty("composite", value);
            }
        }
        
        public void SetKeyframes(object keyframes)
        {
            this.CallVoidMethod("setKeyframes", keyframes);
        }
    }
}
