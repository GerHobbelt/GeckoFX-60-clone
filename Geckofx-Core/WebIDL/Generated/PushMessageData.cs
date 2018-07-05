namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushMessageData : WebIDLBase
    {
        
        public PushMessageData(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr ArrayBuffer()
        {
            return this.CallMethod<IntPtr>("arrayBuffer");
        }
        
        public nsIDOMBlob Blob()
        {
            return this.CallMethod<nsIDOMBlob>("blob");
        }
        
        public object Json()
        {
            return this.CallMethod<object>("json");
        }
        
        public USVString Text()
        {
            return this.CallMethod<USVString>("text");
        }
    }
}
