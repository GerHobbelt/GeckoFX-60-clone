namespace Gecko.WebIDL
{
    using System;
    
    
    public class XULCommandEvent : WebIDLBase
    {
        
        public XULCommandEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool CtrlKey
        {
            get
            {
                return this.GetProperty<bool>("ctrlKey");
            }
        }
        
        public bool ShiftKey
        {
            get
            {
                return this.GetProperty<bool>("shiftKey");
            }
        }
        
        public bool AltKey
        {
            get
            {
                return this.GetProperty<bool>("altKey");
            }
        }
        
        public bool MetaKey
        {
            get
            {
                return this.GetProperty<bool>("metaKey");
            }
        }
        
        public ushort InputSource
        {
            get
            {
                return this.GetProperty<ushort>("inputSource");
            }
        }
        
        public nsIDOMEvent SourceEvent
        {
            get
            {
                return this.GetProperty<nsIDOMEvent>("sourceEvent");
            }
        }
        
        public void InitCommandEvent(string type)
        {
            this.CallVoidMethod("initCommandEvent", type);
        }
        
        public void InitCommandEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, nsIDOMEvent sourceEvent)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey, sourceEvent);
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, nsIDOMEvent sourceEvent, ushort inputSource)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey, sourceEvent, inputSource);
        }
    }
}
