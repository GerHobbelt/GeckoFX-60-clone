namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCRtpReceiver : WebIDLBase
    {
        
        public RTCRtpReceiver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
        
        public Promise < nsISupports > GetStats()
        {
            return this.CallMethod<Promise < nsISupports >>("getStats");
        }
        
        public object[] GetContributingSources()
        {
            return this.CallMethod<object[]>("getContributingSources");
        }
        
        public object[] GetSynchronizationSources()
        {
            return this.CallMethod<object[]>("getSynchronizationSources");
        }
        
        public void SetStreamIds(string[] streamIds)
        {
            this.CallVoidMethod("setStreamIds", streamIds);
        }
        
        public void SetRemoteSendBit(bool sendBit)
        {
            this.CallVoidMethod("setRemoteSendBit", sendBit);
        }
        
        public void ProcessTrackAdditionsAndRemovals(nsISupports transceiver, object postProcessing)
        {
            this.CallVoidMethod("processTrackAdditionsAndRemovals", transceiver, postProcessing);
        }
    }
}
