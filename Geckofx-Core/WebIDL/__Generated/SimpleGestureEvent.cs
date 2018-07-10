namespace Gecko.WebIDL
{
    using System;
    
    
    public class SimpleGestureEvent : WebIDLBase
    {
        
        public SimpleGestureEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint AllowedDirections
        {
            get
            {
                return this.GetProperty<uint>("allowedDirections");
            }
            set
            {
                this.SetProperty("allowedDirections", value);
            }
        }
        
        public uint Direction
        {
            get
            {
                return this.GetProperty<uint>("direction");
            }
        }
        
        public double Delta
        {
            get
            {
                return this.GetProperty<double>("delta");
            }
        }
        
        public uint ClickCount
        {
            get
            {
                return this.GetProperty<uint>("clickCount");
            }
        }
        
        public void InitSimpleGestureEvent(string typeArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg);
        }
        
        public void InitSimpleGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, nsISupports relatedTargetArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
        }
        
        public void InitSimpleGestureEvent(
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
                    uint allowedDirectionsArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, allowedDirectionsArg);
        }
        
        public void InitSimpleGestureEvent(
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
                    uint allowedDirectionsArg, 
                    uint directionArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, allowedDirectionsArg, directionArg);
        }
        
        public void InitSimpleGestureEvent(
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
                    uint allowedDirectionsArg, 
                    uint directionArg, 
                    double deltaArg)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, allowedDirectionsArg, directionArg, deltaArg);
        }
        
        public void InitSimpleGestureEvent(
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
                    uint allowedDirectionsArg, 
                    uint directionArg, 
                    double deltaArg, 
                    uint clickCount)
        {
            this.CallVoidMethod("initSimpleGestureEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, allowedDirectionsArg, directionArg, deltaArg, clickCount);
        }
    }
}
