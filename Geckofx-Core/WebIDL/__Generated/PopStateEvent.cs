namespace Gecko.WebIDL
{
    using System;
    
    
    public class PopStateEvent : WebIDLBase
    {
        
        public PopStateEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object State
        {
            get
            {
                return this.GetProperty<object>("state");
            }
        }
    }
}
