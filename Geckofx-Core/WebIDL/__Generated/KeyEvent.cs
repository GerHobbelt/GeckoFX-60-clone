namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyEvent : WebIDLBase
    {
        
        public KeyEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void InitKeyEvent(string type)
        {
            this.CallVoidMethod("initKeyEvent", type);
        }
        
        public void InitKeyEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey, bool shiftKey)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey, shiftKey);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey, shiftKey, metaKey);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, uint keyCode)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode);
        }
        
        public void InitKeyEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, uint keyCode, uint charCode)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode, charCode);
        }
    }
}
