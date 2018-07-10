namespace Gecko.WebIDL
{
    using System;
    
    
    public class OffscreenCanvas : WebIDLBase
    {
        
        public OffscreenCanvas(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public nsISupports GetContext(string contextId)
        {
            return this.CallMethod<nsISupports>("getContext", contextId);
        }
        
        public nsISupports GetContext(string contextId, object contextOptions)
        {
            return this.CallMethod<nsISupports>("getContext", contextId, contextOptions);
        }
        
        public nsISupports TransferToImageBitmap()
        {
            return this.CallMethod<nsISupports>("transferToImageBitmap");
        }
        
        public Promise < nsIDOMBlob > ToBlob()
        {
            return this.CallMethod<Promise < nsIDOMBlob >>("toBlob");
        }
        
        public Promise < nsIDOMBlob > ToBlob(string type)
        {
            return this.CallMethod<Promise < nsIDOMBlob >>("toBlob", type);
        }
        
        public Promise < nsIDOMBlob > ToBlob(string type, object encoderOptions)
        {
            return this.CallMethod<Promise < nsIDOMBlob >>("toBlob", type, encoderOptions);
        }
    }
}
