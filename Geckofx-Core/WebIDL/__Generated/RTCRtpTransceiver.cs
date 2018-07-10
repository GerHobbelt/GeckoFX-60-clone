namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCRtpTransceiver : WebIDLBase
    {
        
        public RTCRtpTransceiver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Mid
        {
            get
            {
                return this.GetProperty<string>("mid");
            }
        }
        
        public nsISupports Sender
        {
            get
            {
                return this.GetProperty<nsISupports>("sender");
            }
        }
        
        public nsISupports Receiver
        {
            get
            {
                return this.GetProperty<nsISupports>("receiver");
            }
        }
        
        public bool Stopped
        {
            get
            {
                return this.GetProperty<bool>("stopped");
            }
        }
        
        public RTCRtpTransceiverDirection Direction
        {
            get
            {
                return this.GetProperty<RTCRtpTransceiverDirection>("direction");
            }
            set
            {
                this.SetProperty("direction", value);
            }
        }
        
        public RTCRtpTransceiverDirection CurrentDirection
        {
            get
            {
                return this.GetProperty<RTCRtpTransceiverDirection>("currentDirection");
            }
        }
        
        public bool AddTrackMagic
        {
            get
            {
                return this.GetProperty<bool>("addTrackMagic");
            }
        }
        
        public bool ShouldRemove
        {
            get
            {
                return this.GetProperty<bool>("shouldRemove");
            }
            set
            {
                this.SetProperty("shouldRemove", value);
            }
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void SetRemoteTrackId(string trackId)
        {
            this.CallVoidMethod("setRemoteTrackId", trackId);
        }
        
        public bool RemoteTrackIdIs(string trackId)
        {
            return this.CallMethod<bool>("remoteTrackIdIs", trackId);
        }
        
        public string GetRemoteTrackId()
        {
            return this.CallMethod<string>("getRemoteTrackId");
        }
        
        public void SetAddTrackMagic()
        {
            this.CallVoidMethod("setAddTrackMagic");
        }
        
        public void SetCurrentDirection(RTCRtpTransceiverDirection direction)
        {
            this.CallVoidMethod("setCurrentDirection", direction);
        }
        
        public void SetDirectionInternal(RTCRtpTransceiverDirection direction)
        {
            this.CallVoidMethod("setDirectionInternal", direction);
        }
        
        public void SetMid(string mid)
        {
            this.CallVoidMethod("setMid", mid);
        }
        
        public void UnsetMid()
        {
            this.CallVoidMethod("unsetMid");
        }
        
        public void SetStopped()
        {
            this.CallVoidMethod("setStopped");
        }
        
        public string GetKind()
        {
            return this.CallMethod<string>("getKind");
        }
        
        public bool HasBeenUsedToSend()
        {
            return this.CallMethod<bool>("hasBeenUsedToSend");
        }
        
        public void Sync()
        {
            this.CallVoidMethod("sync");
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
