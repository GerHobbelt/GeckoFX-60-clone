namespace Gecko.WebIDL
{
    using System;
    
    
    public class MouseEvent : WebIDLBase
    {
        
        public MouseEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int ScreenX
        {
            get
            {
                return this.GetProperty<int>("screenX");
            }
        }
        
        public int ScreenY
        {
            get
            {
                return this.GetProperty<int>("screenY");
            }
        }
        
        public int ClientX
        {
            get
            {
                return this.GetProperty<int>("clientX");
            }
        }
        
        public int ClientY
        {
            get
            {
                return this.GetProperty<int>("clientY");
            }
        }
        
        public int X
        {
            get
            {
                return this.GetProperty<int>("x");
            }
        }
        
        public int Y
        {
            get
            {
                return this.GetProperty<int>("y");
            }
        }
        
        public int OffsetX
        {
            get
            {
                return this.GetProperty<int>("offsetX");
            }
        }
        
        public int OffsetY
        {
            get
            {
                return this.GetProperty<int>("offsetY");
            }
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
        
        public short Button
        {
            get
            {
                return this.GetProperty<short>("button");
            }
        }
        
        public ushort Buttons
        {
            get
            {
                return this.GetProperty<ushort>("buttons");
            }
        }
        
        public nsISupports RelatedTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("relatedTarget");
            }
        }
        
        public string Region
        {
            get
            {
                return this.GetProperty<string>("region");
            }
        }
        
        public int MovementX
        {
            get
            {
                return this.GetProperty<int>("movementX");
            }
        }
        
        public int MovementY
        {
            get
            {
                return this.GetProperty<int>("movementY");
            }
        }
        
        public void InitMouseEvent(string typeArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg);
        }
        
        public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, nsISupports relatedTargetArg)
        {
            this.CallVoidMethod("initMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
        }
        
        public bool GetModifierState(string keyArg)
        {
            return this.CallMethod<bool>("getModifierState", keyArg);
        }
        
        public float MozPressure
        {
            get
            {
                return this.GetProperty<float>("mozPressure");
            }
        }
        
        public ushort MozInputSource
        {
            get
            {
                return this.GetProperty<ushort>("mozInputSource");
            }
        }
        
        public bool HitCluster
        {
            get
            {
                return this.GetProperty<bool>("hitCluster");
            }
        }
        
        public void InitNSMouseEvent(string typeArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg);
        }
        
        public void InitNSMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, nsISupports relatedTargetArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
        }
        
        public void InitNSMouseEvent(
                    string typeArg, 
                    bool canBubbleArg, 
                    bool cancelableArg, 
                    nsIDOMWindow viewArg, 
                    int detailArg, 
                    int screenXArg, 
                    int screenYArg, 
                    int clientXArg, 
                    int clientYArg, 
                    bool ctrlKeyArg, 
                    bool altKeyArg, 
                    bool shiftKeyArg, 
                    bool metaKeyArg, 
                    short buttonArg, 
                    nsISupports relatedTargetArg, 
                    float pressure)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, pressure);
        }
        
        public void InitNSMouseEvent(
                    string typeArg, 
                    bool canBubbleArg, 
                    bool cancelableArg, 
                    nsIDOMWindow viewArg, 
                    int detailArg, 
                    int screenXArg, 
                    int screenYArg, 
                    int clientXArg, 
                    int clientYArg, 
                    bool ctrlKeyArg, 
                    bool altKeyArg, 
                    bool shiftKeyArg, 
                    bool metaKeyArg, 
                    short buttonArg, 
                    nsISupports relatedTargetArg, 
                    float pressure, 
                    ushort inputSourceArg)
        {
            this.CallVoidMethod("initNSMouseEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, pressure, inputSourceArg);
        }
    }
}
