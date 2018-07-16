namespace Gecko.WebIDL
{
    using System;
    
    
    public class Body : WebIDLBase
    {
        
        public Body(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool BodyUsed
        {
            get
            {
                return this.GetProperty<bool>("bodyUsed");
            }
        }
        
        public Promise < IntPtr > ArrayBuffer()
        {
            return this.CallMethod<Promise < IntPtr >>("arrayBuffer");
        }
        
        public Promise < nsIDOMBlob > Blob()
        {
            return this.CallMethod<Promise < nsIDOMBlob >>("blob");
        }
        
        public Promise < nsIDOMFormData > FormData()
        {
            return this.CallMethod<Promise < nsIDOMFormData >>("formData");
        }
        
        public Promise < Object > Json()
        {
            return this.CallMethod<Promise < Object >>("json");
        }
        
        public Promise < USVString > Text()
        {
            return this.CallMethod<Promise < USVString >>("text");
        }
    }
}