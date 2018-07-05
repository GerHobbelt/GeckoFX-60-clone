namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCTrackEvent : WebIDLBase
    {
        
        public RTCTrackEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Receiver
        {
            get
            {
                return this.GetProperty<nsISupports>("receiver");
            }
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
        
        public nsISupports[] Streams
        {
            get
            {
                return this.GetProperty<nsISupports[]>("streams");
            }
        }
        
        public nsISupports Transceiver
        {
            get
            {
                return this.GetProperty<nsISupports>("transceiver");
            }
        }
    }
}
