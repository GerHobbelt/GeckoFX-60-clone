namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCPeerConnection : WebIDLBase
    {
        
        public RTCPeerConnection(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports LocalDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("localDescription");
            }
        }
        
        public nsISupports CurrentLocalDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("currentLocalDescription");
            }
        }
        
        public nsISupports PendingLocalDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("pendingLocalDescription");
            }
        }
        
        public nsISupports RemoteDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("remoteDescription");
            }
        }
        
        public nsISupports CurrentRemoteDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("currentRemoteDescription");
            }
        }
        
        public nsISupports PendingRemoteDescription
        {
            get
            {
                return this.GetProperty<nsISupports>("pendingRemoteDescription");
            }
        }
        
        public RTCSignalingState SignalingState
        {
            get
            {
                return this.GetProperty<RTCSignalingState>("signalingState");
            }
        }
        
        public System.Nullable<bool> CanTrickleIceCandidates
        {
            get
            {
                return this.GetProperty<System.Nullable<bool>>("canTrickleIceCandidates");
            }
        }
        
        public RTCIceGatheringState IceGatheringState
        {
            get
            {
                return this.GetProperty<RTCIceGatheringState>("iceGatheringState");
            }
        }
        
        public RTCIceConnectionState IceConnectionState
        {
            get
            {
                return this.GetProperty<RTCIceConnectionState>("iceConnectionState");
            }
        }
        
        public Promise <object> PeerIdentity
        {
            get
            {
                return this.GetProperty<Promise <object>>("peerIdentity");
            }
        }
        
        public string IdpLoginUrl
        {
            get
            {
                return this.GetProperty<string>("idpLoginUrl");
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
        
        public void SetIdentityProvider(string provider)
        {
            this.CallVoidMethod("setIdentityProvider", provider);
        }
        
        public void SetIdentityProvider(string provider, string protocol)
        {
            this.CallVoidMethod("setIdentityProvider", provider, protocol);
        }
        
        public void SetIdentityProvider(string provider, string protocol, string username)
        {
            this.CallVoidMethod("setIdentityProvider", provider, protocol, username);
        }
        
        public Promise <string> GetIdentityAssertion()
        {
            return this.CallMethod<Promise <string>>("getIdentityAssertion");
        }
        
        public Promise <object> CreateOffer()
        {
            return this.CallMethod<Promise <object>>("createOffer");
        }
        
        public Promise <object> CreateOffer(object options)
        {
            return this.CallMethod<Promise <object>>("createOffer", options);
        }
        
        public Promise <object> CreateAnswer()
        {
            return this.CallMethod<Promise <object>>("createAnswer");
        }
        
        public Promise <object> CreateAnswer(object options)
        {
            return this.CallMethod<Promise <object>>("createAnswer", options);
        }
        
        public Promise SetLocalDescription(object description)
        {
            return this.CallMethod<Promise>("setLocalDescription", description);
        }
        
        public Promise SetRemoteDescription(object description)
        {
            return this.CallMethod<Promise>("setRemoteDescription", description);
        }
        
        public Promise AddIceCandidate(WebIDLUnion<System.Object,nsISupports> candidate)
        {
            return this.CallMethod<Promise>("addIceCandidate", candidate);
        }
        
        public object GetConfiguration()
        {
            return this.CallMethod<object>("getConfiguration");
        }
        
        public nsISupports[] GetLocalStreams()
        {
            return this.CallMethod<nsISupports[]>("getLocalStreams");
        }
        
        public nsISupports[] GetRemoteStreams()
        {
            return this.CallMethod<nsISupports[]>("getRemoteStreams");
        }
        
        public void AddStream(nsISupports stream)
        {
            this.CallVoidMethod("addStream", stream);
        }
        
        public nsISupports AddTrack(nsISupports track, nsISupports stream, nsISupports moreStreams)
        {
            return this.CallMethod<nsISupports>("addTrack", track, stream, moreStreams);
        }
        
        public void RemoveTrack(nsISupports sender)
        {
            this.CallVoidMethod("removeTrack", sender);
        }
        
        public nsISupports AddTransceiver(WebIDLUnion<nsISupports,System.String> trackOrKind)
        {
            return this.CallMethod<nsISupports>("addTransceiver", trackOrKind);
        }
        
        public nsISupports AddTransceiver(WebIDLUnion<nsISupports,System.String> trackOrKind, object init)
        {
            return this.CallMethod<nsISupports>("addTransceiver", trackOrKind, init);
        }
        
        public nsISupports[] GetSenders()
        {
            return this.CallMethod<nsISupports[]>("getSenders");
        }
        
        public nsISupports[] GetReceivers()
        {
            return this.CallMethod<nsISupports[]>("getReceivers");
        }
        
        public nsISupports[] GetTransceivers()
        {
            return this.CallMethod<nsISupports[]>("getTransceivers");
        }
        
        public Double MozGetNowInRtpSourceReferenceTime()
        {
            return this.CallMethod<Double>("mozGetNowInRtpSourceReferenceTime");
        }
        
        public void MozInsertAudioLevelForContributingSource(nsISupports receiver, uint source, Double timestamp, bool hasLevel, sbyte level)
        {
            this.CallVoidMethod("mozInsertAudioLevelForContributingSource", receiver, source, timestamp, hasLevel, level);
        }
        
        public void MozAddRIDExtension(nsISupports receiver, ushort extensionId)
        {
            this.CallVoidMethod("mozAddRIDExtension", receiver, extensionId);
        }
        
        public void MozAddRIDFilter(nsISupports receiver, string rid)
        {
            this.CallVoidMethod("mozAddRIDFilter", receiver, rid);
        }
        
        public void MozEnablePacketDump(uint level, MozPacketDumpType type, bool sending)
        {
            this.CallVoidMethod("mozEnablePacketDump", level, type, sending);
        }
        
        public void MozDisablePacketDump(uint level, MozPacketDumpType type, bool sending)
        {
            this.CallVoidMethod("mozDisablePacketDump", level, type, sending);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public Promise < nsISupports > GetStats()
        {
            return this.CallMethod<Promise < nsISupports >>("getStats");
        }
        
        public Promise < nsISupports > GetStats(nsISupports selector)
        {
            return this.CallMethod<Promise < nsISupports >>("getStats", selector);
        }
        
        public nsISupports CreateDataChannel(string label)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label);
        }
        
        public nsISupports CreateDataChannel(string label, object dataChannelDict)
        {
            return this.CallMethod<nsISupports>("createDataChannel", label, dataChannelDict);
        }
    }
}
