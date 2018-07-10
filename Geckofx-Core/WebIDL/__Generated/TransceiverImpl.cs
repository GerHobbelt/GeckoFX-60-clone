namespace Gecko.WebIDL
{
    using System;
    
    
    public class TransceiverImpl : WebIDLBase
    {
        
        public TransceiverImpl(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports GetReceiveTrack()
        {
            return this.CallMethod<nsISupports>("getReceiveTrack");
        }
        
        public void SyncWithJS(nsISupports transceiver)
        {
            this.CallVoidMethod("syncWithJS", transceiver);
        }
    }
}
