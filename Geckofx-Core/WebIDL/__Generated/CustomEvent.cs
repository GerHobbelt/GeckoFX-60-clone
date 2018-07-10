namespace Gecko.WebIDL
{
    using System;
    
    
    public class CustomEvent : WebIDLBase
    {
        
        public CustomEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Detail
        {
            get
            {
                return this.GetProperty<object>("detail");
            }
        }
        
        public void InitCustomEvent(string type)
        {
            this.CallVoidMethod("initCustomEvent", type);
        }
        
        public void InitCustomEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initCustomEvent", type, canBubble);
        }
        
        public void InitCustomEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initCustomEvent", type, canBubble, cancelable);
        }
        
        public void InitCustomEvent(string type, bool canBubble, bool cancelable, object detail)
        {
            this.CallVoidMethod("initCustomEvent", type, canBubble, cancelable, detail);
        }
    }
}
