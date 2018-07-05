namespace Gecko.WebIDL
{
    using System;
    
    
    public class IntersectionObserver : WebIDLBase
    {
        
        public IntersectionObserver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement Root
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("root");
            }
        }
        
        public string RootMargin
        {
            get
            {
                return this.GetProperty<string>("rootMargin");
            }
        }
        
        public double[] Thresholds
        {
            get
            {
                return this.GetProperty<double[]>("thresholds");
            }
        }
        
        public void Observe(nsIDOMElement target)
        {
            this.CallVoidMethod("observe", target);
        }
        
        public void Unobserve(nsIDOMElement target)
        {
            this.CallVoidMethod("unobserve", target);
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
        
        public nsISupports[] TakeRecords()
        {
            return this.CallMethod<nsISupports[]>("takeRecords");
        }
    }
}
