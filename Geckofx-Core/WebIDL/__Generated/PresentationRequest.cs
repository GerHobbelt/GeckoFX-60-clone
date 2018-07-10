namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationRequest : WebIDLBase
    {
        
        public PresentationRequest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Start()
        {
            return this.CallMethod<Promise < nsISupports >>("start");
        }
        
        public Promise < nsISupports > Reconnect(string presentationId)
        {
            return this.CallMethod<Promise < nsISupports >>("reconnect", presentationId);
        }
        
        public Promise < nsISupports > GetAvailability()
        {
            return this.CallMethod<Promise < nsISupports >>("getAvailability");
        }
        
        public Promise < nsISupports > StartWithDevice(string deviceId)
        {
            return this.CallMethod<Promise < nsISupports >>("startWithDevice", deviceId);
        }
    }
}
