namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventTarget : WebIDLBase
    {
        
        public EventTarget(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddEventListener(string type, nsISupports listener)
        {
            this.CallVoidMethod("addEventListener", type, listener);
        }
        
        public void AddEventListener(string type, nsISupports listener, WebIDLUnion<System.Object,System.Boolean> options)
        {
            this.CallVoidMethod("addEventListener", type, listener, options);
        }
        
        public void AddEventListener(string type, nsISupports listener, WebIDLUnion<System.Object,System.Boolean> options, System.Nullable<bool> wantsUntrusted)
        {
            this.CallVoidMethod("addEventListener", type, listener, options, wantsUntrusted);
        }
        
        public void RemoveEventListener(string type, nsISupports listener)
        {
            this.CallVoidMethod("removeEventListener", type, listener);
        }
        
        public void RemoveEventListener(string type, nsISupports listener, WebIDLUnion<System.Object,System.Boolean> options)
        {
            this.CallVoidMethod("removeEventListener", type, listener, options);
        }
        
        public bool DispatchEvent(nsIDOMEvent @event)
        {
            return this.CallMethod<bool>("dispatchEvent", @event);
        }
        
        public mozIDOMWindowProxy OwnerGlobal
        {
            get
            {
                return this.GetProperty<mozIDOMWindowProxy>("ownerGlobal");
            }
        }
    }
}
