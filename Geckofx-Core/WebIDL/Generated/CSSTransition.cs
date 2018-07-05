namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSTransition : WebIDLBase
    {
        
        public CSSTransition(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string TransitionProperty
        {
            get
            {
                return this.GetProperty<string>("transitionProperty");
            }
        }
    }
}
