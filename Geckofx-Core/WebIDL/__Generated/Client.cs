namespace Gecko.WebIDL
{
    using System;
    
    
    public class Client : WebIDLBase
    {
        
        public Client(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Url
        {
            get
            {
                return this.GetProperty<USVString>("url");
            }
        }
        
        public FrameType FrameType
        {
            get
            {
                return this.GetProperty<FrameType>("frameType");
            }
        }
        
        public ClientType Type
        {
            get
            {
                return this.GetProperty<ClientType>("type");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void PostMessage(object message, object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, transfer);
        }
    }
}
