namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnection : WebIDLBase
    {
        
        public PresentationConnection(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Url
        {
            get
            {
                return this.GetProperty<string>("url");
            }
        }
        
        public PresentationConnectionState State
        {
            get
            {
                return this.GetProperty<PresentationConnectionState>("state");
            }
        }
        
        public PresentationConnectionBinaryType BinaryType
        {
            get
            {
                return this.GetProperty<PresentationConnectionBinaryType>("binaryType");
            }
            set
            {
                this.SetProperty("binaryType", value);
            }
        }
        
        public void Send(string data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(nsIDOMBlob data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(IntPtr data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Terminate()
        {
            this.CallVoidMethod("terminate");
        }
    }
}
