namespace Gecko.WebIDL
{
    using System;
    
    
    public class IntersectionObserverEntry : WebIDLBase
    {
        
        public IntersectionObserverEntry(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Time
        {
            get
            {
                return this.GetProperty<double>("time");
            }
        }
        
        public nsISupports RootBounds
        {
            get
            {
                return this.GetProperty<nsISupports>("rootBounds");
            }
        }
        
        public nsISupports BoundingClientRect
        {
            get
            {
                return this.GetProperty<nsISupports>("boundingClientRect");
            }
        }
        
        public nsISupports IntersectionRect
        {
            get
            {
                return this.GetProperty<nsISupports>("intersectionRect");
            }
        }
        
        public bool IsIntersecting
        {
            get
            {
                return this.GetProperty<bool>("isIntersecting");
            }
        }
        
        public double IntersectionRatio
        {
            get
            {
                return this.GetProperty<double>("intersectionRatio");
            }
        }
        
        public nsIDOMElement Target
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("target");
            }
        }
    }
}
