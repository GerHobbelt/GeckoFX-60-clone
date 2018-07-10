namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScrollViewChangeEvent : WebIDLBase
    {
        
        public ScrollViewChangeEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ScrollState State
        {
            get
            {
                return this.GetProperty<ScrollState>("state");
            }
        }
    }
}
