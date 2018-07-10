namespace Gecko.WebIDL
{
    using System;
    
    
    public class MouseScrollEvent : WebIDLBase
    {
        
        public MouseScrollEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int Axis
        {
            get
            {
                return this.GetProperty<int>("axis");
            }
        }
        
        public void InitMouseScrollEvent(string type)
        {
            this.CallVoidMethod("initMouseScrollEvent", type);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, short button)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button);
        }
        
        public void InitMouseScrollEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, short button, nsISupports relatedTarget)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget);
        }
        
        public void InitMouseScrollEvent(
                    string type, 
                    bool canBubble, 
                    bool cancelable, 
                    nsIDOMWindow view, 
                    int detail, 
                    int screenX, 
                    int screenY, 
                    int clientX, 
                    int clientY, 
                    bool ctrlKey, 
                    bool altKey, 
                    bool shiftKey, 
                    bool metaKey, 
                    short button, 
                    nsISupports relatedTarget, 
                    int axis)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget, axis);
        }
    }
}
