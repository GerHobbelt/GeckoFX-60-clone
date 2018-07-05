namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScrollAreaEvent : WebIDLBase
    {
        
        public ScrollAreaEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float X
        {
            get
            {
                return this.GetProperty<float>("x");
            }
        }
        
        public float Y
        {
            get
            {
                return this.GetProperty<float>("y");
            }
        }
        
        public float Width
        {
            get
            {
                return this.GetProperty<float>("width");
            }
        }
        
        public float Height
        {
            get
            {
                return this.GetProperty<float>("height");
            }
        }
        
        public void InitScrollAreaEvent(string type)
        {
            this.CallVoidMethod("initScrollAreaEvent", type);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, float x)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail, x);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, float x, float y)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail, x, y);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, float x, float y, float width)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail, x, y, width);
        }
        
        public void InitScrollAreaEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, float x, float y, float width, float height)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail, x, y, width, height);
        }
    }
}
