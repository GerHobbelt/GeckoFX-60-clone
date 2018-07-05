namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCDTMFSender : WebIDLBase
    {
        
        public RTCDTMFSender(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ToneBuffer
        {
            get
            {
                return this.GetProperty<string>("toneBuffer");
            }
        }
        
        public void InsertDTMF(string tones)
        {
            this.CallVoidMethod("insertDTMF", tones);
        }
        
        public void InsertDTMF(string tones, uint duration)
        {
            this.CallVoidMethod("insertDTMF", tones, duration);
        }
        
        public void InsertDTMF(string tones, uint duration, uint interToneGap)
        {
            this.CallVoidMethod("insertDTMF", tones, duration, interToneGap);
        }
    }
}
