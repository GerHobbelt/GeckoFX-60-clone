namespace Gecko.WebIDL
{
    using System;
    
    
    public class HashChangeEvent : WebIDLBase
    {
        
        public HashChangeEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string OldURL
        {
            get
            {
                return this.GetProperty<string>("oldURL");
            }
        }
        
        public string NewURL
        {
            get
            {
                return this.GetProperty<string>("newURL");
            }
        }
        
        public void InitHashChangeEvent(string typeArg)
        {
            this.CallVoidMethod("initHashChangeEvent", typeArg);
        }
        
        public void InitHashChangeEvent(string typeArg, bool canBubbleArg)
        {
            this.CallVoidMethod("initHashChangeEvent", typeArg, canBubbleArg);
        }
        
        public void InitHashChangeEvent(string typeArg, bool canBubbleArg, bool cancelableArg)
        {
            this.CallVoidMethod("initHashChangeEvent", typeArg, canBubbleArg, cancelableArg);
        }
        
        public void InitHashChangeEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string oldURLArg)
        {
            this.CallVoidMethod("initHashChangeEvent", typeArg, canBubbleArg, cancelableArg, oldURLArg);
        }
        
        public void InitHashChangeEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string oldURLArg, string newURLArg)
        {
            this.CallVoidMethod("initHashChangeEvent", typeArg, canBubbleArg, cancelableArg, oldURLArg, newURLArg);
        }
    }
}
