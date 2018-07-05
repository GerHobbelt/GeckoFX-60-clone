namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessageEvent : WebIDLBase
    {
        
        public MessageEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public USVString Origin
        {
            get
            {
                return this.GetProperty<USVString>("origin");
            }
        }
        
        public string LastEventId
        {
            get
            {
                return this.GetProperty<string>("lastEventId");
            }
        }
        
        public WebIDLUnion<mozIDOMWindowProxy,nsISupports,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<mozIDOMWindowProxy,nsISupports,nsISupports>>("source");
            }
        }
        
        public nsISupports[] Ports
        {
            get
            {
                return this.GetProperty<nsISupports[]>("ports");
            }
        }
        
        public void InitMessageEvent(string type)
        {
            this.CallVoidMethod("initMessageEvent", type);
        }
        
        public void InitMessageEvent(string type, bool bubbles)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles);
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable);
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data);
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin);
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin, string lastEventId)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin, lastEventId);
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin, string lastEventId, WebIDLUnion<mozIDOMWindowProxy,nsISupports,nsISupports> source)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin, lastEventId, source);
        }
        
        public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin, string lastEventId, WebIDLUnion<mozIDOMWindowProxy,nsISupports,nsISupports> source, nsISupports[] ports)
        {
            this.CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin, lastEventId, source, ports);
        }
    }
}
