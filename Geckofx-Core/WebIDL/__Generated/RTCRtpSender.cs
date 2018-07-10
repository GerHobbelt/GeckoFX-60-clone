namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCRtpSender : WebIDLBase
    {
        
        public RTCRtpSender(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Dtmf
        {
            get
            {
                return this.GetProperty<nsISupports>("dtmf");
            }
        }
        
        public Promise SetParameters()
        {
            return this.CallMethod<Promise>("setParameters");
        }
        
        public Promise SetParameters(object parameters)
        {
            return this.CallMethod<Promise>("setParameters", parameters);
        }
        
        public object GetParameters()
        {
            return this.CallMethod<object>("getParameters");
        }
        
        public Promise ReplaceTrack(nsISupports withTrack)
        {
            return this.CallMethod<Promise>("replaceTrack", withTrack);
        }
        
        public Promise < nsISupports > GetStats()
        {
            return this.CallMethod<Promise < nsISupports >>("getStats");
        }
        
        public nsISupports[] GetStreams()
        {
            return this.CallMethod<nsISupports[]>("getStreams");
        }
        
        public void SetStreams(nsISupports[] streams)
        {
            this.CallVoidMethod("setStreams", streams);
        }
        
        public void SetTrack(nsISupports track)
        {
            this.CallVoidMethod("setTrack", track);
        }
        
        public void CheckWasCreatedByPc(nsISupports pc)
        {
            this.CallVoidMethod("checkWasCreatedByPc", pc);
        }
    }
}
