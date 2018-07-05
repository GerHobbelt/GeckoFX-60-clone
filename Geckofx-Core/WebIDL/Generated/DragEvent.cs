namespace Gecko.WebIDL
{
    using System;
    
    
    public class DragEvent : WebIDLBase
    {
        
        public DragEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports DataTransfer
        {
            get
            {
                return this.GetProperty<nsISupports>("dataTransfer");
            }
        }
        
        public void InitDragEvent(string type)
        {
            this.CallVoidMethod("initDragEvent", type);
        }
        
        public void InitDragEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey, aMetaKey);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey, ushort aButton)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey, aMetaKey, aButton);
        }
        
        public void InitDragEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey, ushort aButton, nsISupports aRelatedTarget)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey, aMetaKey, aButton, aRelatedTarget);
        }
        
        public void InitDragEvent(
                    string type, 
                    bool canBubble, 
                    bool cancelable, 
                    nsIDOMWindow aView, 
                    int aDetail, 
                    int aScreenX, 
                    int aScreenY, 
                    int aClientX, 
                    int aClientY, 
                    bool aCtrlKey, 
                    bool aAltKey, 
                    bool aShiftKey, 
                    bool aMetaKey, 
                    ushort aButton, 
                    nsISupports aRelatedTarget, 
                    nsISupports aDataTransfer)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey, aMetaKey, aButton, aRelatedTarget, aDataTransfer);
        }
    }
}
