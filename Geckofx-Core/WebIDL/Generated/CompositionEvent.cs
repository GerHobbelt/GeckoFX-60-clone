namespace Gecko.WebIDL
{
    using System;
    
    
    public class CompositionEvent : WebIDLBase
    {
        
        public CompositionEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Data
        {
            get
            {
                return this.GetProperty<string>("data");
            }
        }
        
        public string Locale
        {
            get
            {
                return this.GetProperty<string>("locale");
            }
        }
        
        public nsISupports[] Ranges
        {
            get
            {
                return this.GetProperty<nsISupports[]>("ranges");
            }
        }
        
        public void InitCompositionEvent(string typeArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg);
        }
        
        public void InitCompositionEvent(string typeArg, bool canBubbleArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg);
        }
        
        public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg);
        }
        
        public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg, viewArg);
        }
        
        public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, string dataArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg, viewArg, dataArg);
        }
        
        public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, string dataArg, string localeArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg, viewArg, dataArg, localeArg);
        }
    }
}
