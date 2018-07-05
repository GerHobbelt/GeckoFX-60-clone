namespace Gecko.WebIDL
{
    using System;
    
    
    public class PageTransitionEvent : WebIDLBase
    {
        
        public PageTransitionEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Persisted
        {
            get
            {
                return this.GetProperty<bool>("persisted");
            }
        }
        
        public bool InFrameSwap
        {
            get
            {
                return this.GetProperty<bool>("inFrameSwap");
            }
        }
    }
}
