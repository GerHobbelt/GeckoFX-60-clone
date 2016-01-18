namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnection : WebIDLBase
    {
        
        public PresentationConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public PresentationConnectionState State
        {
            get
            {
                return this.GetProperty<PresentationConnectionState>("state");
            }
        }
        
        public void Send(nsAString data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Terminate()
        {
            this.CallVoidMethod("terminate");
        }
    }
}
