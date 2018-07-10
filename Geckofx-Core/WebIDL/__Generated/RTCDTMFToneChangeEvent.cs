namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCDTMFToneChangeEvent : WebIDLBase
    {
        
        public RTCDTMFToneChangeEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Tone
        {
            get
            {
                return this.GetProperty<string>("tone");
            }
        }
    }
}
