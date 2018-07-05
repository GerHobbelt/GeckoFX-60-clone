namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRDisplay : WebIDLBase
    {
        
        public VRDisplay(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint PresentingGroups
        {
            get
            {
                return this.GetProperty<uint>("presentingGroups");
            }
        }
        
        public uint GroupMask
        {
            get
            {
                return this.GetProperty<uint>("groupMask");
            }
            set
            {
                this.SetProperty("groupMask", value);
            }
        }
        
        public bool IsConnected
        {
            get
            {
                return this.GetProperty<bool>("isConnected");
            }
        }
        
        public bool IsPresenting
        {
            get
            {
                return this.GetProperty<bool>("isPresenting");
            }
        }
        
        public nsISupports Capabilities
        {
            get
            {
                return this.GetProperty<nsISupports>("capabilities");
            }
        }
        
        public nsISupports StageParameters
        {
            get
            {
                return this.GetProperty<nsISupports>("stageParameters");
            }
        }
        
        public uint DisplayId
        {
            get
            {
                return this.GetProperty<uint>("displayId");
            }
        }
        
        public string DisplayName
        {
            get
            {
                return this.GetProperty<string>("displayName");
            }
        }
        
        public double DepthNear
        {
            get
            {
                return this.GetProperty<double>("depthNear");
            }
            set
            {
                this.SetProperty("depthNear", value);
            }
        }
        
        public double DepthFar
        {
            get
            {
                return this.GetProperty<double>("depthFar");
            }
            set
            {
                this.SetProperty("depthFar", value);
            }
        }
        
        public nsISupports GetEyeParameters(VREye whichEye)
        {
            return this.CallMethod<nsISupports>("getEyeParameters", whichEye);
        }
        
        public bool GetFrameData(nsISupports frameData)
        {
            return this.CallMethod<bool>("getFrameData", frameData);
        }
        
        public nsISupports GetPose()
        {
            return this.CallMethod<nsISupports>("getPose");
        }
        
        public bool GetSubmitFrameResult(nsISupports result)
        {
            return this.CallMethod<bool>("getSubmitFrameResult", result);
        }
        
        public void ResetPose()
        {
            this.CallVoidMethod("resetPose");
        }
        
        public void CancelAnimationFrame(int handle)
        {
            this.CallVoidMethod("cancelAnimationFrame", handle);
        }
        
        public Promise RequestPresent(object[] layers)
        {
            return this.CallMethod<Promise>("requestPresent", layers);
        }
        
        public Promise ExitPresent()
        {
            return this.CallMethod<Promise>("exitPresent");
        }
        
        public object[] GetLayers()
        {
            return this.CallMethod<object[]>("getLayers");
        }
        
        public void SubmitFrame()
        {
            this.CallVoidMethod("submitFrame");
        }
    }
}
