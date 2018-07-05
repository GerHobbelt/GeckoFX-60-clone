namespace Gecko.WebIDL
{
    using System;
    
    
    public class PeerConnectionImpl : WebIDLBase
    {
        
        public PeerConnectionImpl(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Certificate
        {
            get
            {
                return this.GetProperty<nsISupports>("certificate");
            }
            set
            {
                this.SetProperty("certificate", value);
            }
        }
        
        public string Fingerprint
        {
            get
            {
                return this.GetProperty<string>("fingerprint");
            }
        }
        
        public string LocalDescription
        {
            get
            {
                return this.GetProperty<string>("localDescription");
            }
        }
        
        public string CurrentLocalDescription
        {
            get
            {
                return this.GetProperty<string>("currentLocalDescription");
            }
        }
        
        public string PendingLocalDescription
        {
            get
            {
                return this.GetProperty<string>("pendingLocalDescription");
            }
        }
        
        public string RemoteDescription
        {
            get
            {
                return this.GetProperty<string>("remoteDescription");
            }
        }
        
        public string CurrentRemoteDescription
        {
            get
            {
                return this.GetProperty<string>("currentRemoteDescription");
            }
        }
        
        public string PendingRemoteDescription
        {
            get
            {
                return this.GetProperty<string>("pendingRemoteDescription");
            }
        }
        
        public PCImplIceConnectionState IceConnectionState
        {
            get
            {
                return this.GetProperty<PCImplIceConnectionState>("iceConnectionState");
            }
        }
        
        public PCImplIceGatheringState IceGatheringState
        {
            get
            {
                return this.GetProperty<PCImplIceGatheringState>("iceGatheringState");
            }
        }
        
        public PCImplSignalingState SignalingState
        {
            get
            {
                return this.GetProperty<PCImplSignalingState>("signalingState");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public string PeerIdentity
        {
            get
            {
                return this.GetProperty<string>("peerIdentity");
            }
            set
            {
                this.SetProperty("peerIdentity", value);
            }
        }
        
        public bool PrivacyRequested
        {
            get
            {
                return this.GetProperty<bool>("privacyRequested");
            }
        }
        
        public void Initialize(nsISupports observer, nsIDOMWindow window, object iceServers, nsISupports thread)
        {
            this.CallVoidMethod("initialize", observer, window, iceServers, thread);
        }
        
        public void CreateOffer()
        {
            this.CallVoidMethod("createOffer");
        }
        
        public void CreateOffer(object options)
        {
            this.CallVoidMethod("createOffer", options);
        }
        
        public void CreateAnswer()
        {
            this.CallVoidMethod("createAnswer");
        }
        
        public void SetLocalDescription(int action, string sdp)
        {
            this.CallVoidMethod("setLocalDescription", action, sdp);
        }
        
        public void SetRemoteDescription(int action, string sdp)
        {
            this.CallVoidMethod("setRemoteDescription", action, sdp);
        }
        
        public void GetStats(nsISupports selector)
        {
            this.CallVoidMethod("getStats", selector);
        }
        
        public nsISupports CreateTransceiverImpl(string kind, nsISupports track)
        {
            return this.CallMethod<nsISupports>("createTransceiverImpl", kind, track);
        }
        
        public bool CheckNegotiationNeeded()
        {
            return this.CallMethod<bool>("checkNegotiationNeeded");
        }
        
        public void InsertDTMF(nsISupports transceiver, string tones)
        {
            this.CallVoidMethod("insertDTMF", transceiver, tones);
        }
        
        public void InsertDTMF(nsISupports transceiver, string tones, uint duration)
        {
            this.CallVoidMethod("insertDTMF", transceiver, tones, duration);
        }
        
        public void InsertDTMF(nsISupports transceiver, string tones, uint duration, uint interToneGap)
        {
            this.CallVoidMethod("insertDTMF", transceiver, tones, duration, interToneGap);
        }
        
        public string GetDTMFToneBuffer(nsISupports sender)
        {
            return this.CallMethod<string>("getDTMFToneBuffer", sender);
        }
        
        public object[] GetRtpSources(nsISupports track, double rtpSourceNow)
        {
            return this.CallMethod<object[]>("getRtpSources", track, rtpSourceNow);
        }
        
        public double GetNowInRtpSourceReferenceTime()
        {
            return this.CallMethod<double>("getNowInRtpSourceReferenceTime");
        }
        
        public void ReplaceTrackNoRenegotiation(nsISupports transceiverImpl, nsISupports withTrack)
        {
            this.CallVoidMethod("replaceTrackNoRenegotiation", transceiverImpl, withTrack);
        }
        
        public void CloseStreams()
        {
            this.CallVoidMethod("closeStreams");
        }
        
        public void AddRIDExtension(nsISupports recvTrack, ushort extensionId)
        {
            this.CallVoidMethod("addRIDExtension", recvTrack, extensionId);
        }
        
        public void AddRIDFilter(nsISupports recvTrack, string rid)
        {
            this.CallVoidMethod("addRIDFilter", recvTrack, rid);
        }
        
        public void InsertAudioLevelForContributingSource(nsISupports recvTrack, uint source, double timestamp, bool hasLevel, sbyte level)
        {
            this.CallVoidMethod("insertAudioLevelForContributingSource", recvTrack, source, timestamp, hasLevel, level);
        }
        
        public void EnablePacketDump(uint level, MozPacketDumpType type, bool sending)
        {
            this.CallVoidMethod("enablePacketDump", level, type, sending);
        }
        
        public void DisablePacketDump(uint level, MozPacketDumpType type, bool sending)
        {
            this.CallVoidMethod("disablePacketDump", level, type, sending);
        }
        
        public void AddIceCandidate(string candidate, string mid, ushort level)
        {
            this.CallVoidMethod("addIceCandidate", candidate, mid, level);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public bool PluginCrash(ulong pluginId, string name)
        {
            return this.CallMethod<bool>("pluginCrash", pluginId, name);
        }
        
        public nsISupports CreateDataChannel(string label, string protocol, ushort type, bool ordered, ushort maxTime, ushort maxNum, bool externalNegotiated, ushort stream)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label, protocol, type, ordered, maxTime, maxNum, externalNegotiated, stream);
        }
    }
}
