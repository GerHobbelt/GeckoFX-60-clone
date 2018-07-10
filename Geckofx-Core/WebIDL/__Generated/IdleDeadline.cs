namespace Gecko.WebIDL
{
    using System;
    
    
    public class IdleDeadline : WebIDLBase
    {
        
        public IdleDeadline(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool DidTimeout
        {
            get
            {
                return this.GetProperty<bool>("didTimeout");
            }
        }
        
        public Double TimeRemaining()
        {
            return this.CallMethod<Double>("timeRemaining");
        }
    }
}
