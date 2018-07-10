namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioContext : WebIDLBase
    {
        
        public AudioContext(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise Suspend()
        {
            return this.CallMethod<Promise>("suspend");
        }
        
        public Promise Close()
        {
            return this.CallMethod<Promise>("close");
        }
        
        public nsISupports CreateMediaElementSource(nsISupports mediaElement)
        {
            return this.CallMethod<nsISupports>("createMediaElementSource", mediaElement);
        }
        
        public nsISupports CreateMediaStreamSource(nsISupports mediaStream)
        {
            return this.CallMethod<nsISupports>("createMediaStreamSource", mediaStream);
        }
        
        public nsISupports CreateMediaStreamDestination()
        {
            return this.CallMethod<nsISupports>("createMediaStreamDestination");
        }
    }
}
