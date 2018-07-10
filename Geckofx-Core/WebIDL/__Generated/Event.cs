namespace Gecko.WebIDL
{
    using System;
    
    
    public class Event : WebIDLBase
    {
        
        public Event(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsISupports Target
        {
            get
            {
                return this.GetProperty<nsISupports>("target");
            }
        }
        
        public nsISupports SrcElement
        {
            get
            {
                return this.GetProperty<nsISupports>("srcElement");
            }
        }
        
        public nsISupports CurrentTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("currentTarget");
            }
        }
        
        public ushort EventPhase
        {
            get
            {
                return this.GetProperty<ushort>("eventPhase");
            }
        }
        
        public bool Bubbles
        {
            get
            {
                return this.GetProperty<bool>("bubbles");
            }
        }
        
        public bool Cancelable
        {
            get
            {
                return this.GetProperty<bool>("cancelable");
            }
        }
        
        public bool DefaultPrevented
        {
            get
            {
                return this.GetProperty<bool>("defaultPrevented");
            }
        }
        
        public bool DefaultPreventedByChrome
        {
            get
            {
                return this.GetProperty<bool>("defaultPreventedByChrome");
            }
        }
        
        public bool DefaultPreventedByContent
        {
            get
            {
                return this.GetProperty<bool>("defaultPreventedByContent");
            }
        }
        
        public bool Composed
        {
            get
            {
                return this.GetProperty<bool>("composed");
            }
        }
        
        public bool IsTrusted
        {
            get
            {
                return this.GetProperty<bool>("isTrusted");
            }
        }
        
        public Double TimeStamp
        {
            get
            {
                return this.GetProperty<Double>("timeStamp");
            }
        }
        
        public bool CancelBubble
        {
            get
            {
                return this.GetProperty<bool>("cancelBubble");
            }
            set
            {
                this.SetProperty("cancelBubble", value);
            }
        }
        
        public nsISupports[] ComposedPath()
        {
            return this.CallMethod<nsISupports[]>("composedPath");
        }
        
        public void StopPropagation()
        {
            this.CallVoidMethod("stopPropagation");
        }
        
        public void StopImmediatePropagation()
        {
            this.CallVoidMethod("stopImmediatePropagation");
        }
        
        public void PreventDefault()
        {
            this.CallVoidMethod("preventDefault");
        }
        
        public void InitEvent(string type)
        {
            this.CallVoidMethod("initEvent", type);
        }
        
        public void InitEvent(string type, bool bubbles)
        {
            this.CallVoidMethod("initEvent", type, bubbles);
        }
        
        public void InitEvent(string type, bool bubbles, bool cancelable)
        {
            this.CallVoidMethod("initEvent", type, bubbles, cancelable);
        }
        
        public nsISupports OriginalTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("originalTarget");
            }
        }
        
        public nsISupports ExplicitOriginalTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("explicitOriginalTarget");
            }
        }
        
        public nsISupports ComposedTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("composedTarget");
            }
        }
        
        public bool MultipleActionsPrevented
        {
            get
            {
                return this.GetProperty<bool>("multipleActionsPrevented");
            }
        }
        
        public bool IsSynthesized
        {
            get
            {
                return this.GetProperty<bool>("isSynthesized");
            }
        }
    }
}
