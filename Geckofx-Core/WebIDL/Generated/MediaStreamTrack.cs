namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamTrack : WebIDLBase
    {
        
        public MediaStreamTrack(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Kind
        {
            get
            {
                return this.GetProperty<string>("kind");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
            set
            {
                this.SetProperty("enabled", value);
            }
        }
        
        public bool Muted
        {
            get
            {
                return this.GetProperty<bool>("muted");
            }
        }
        
        public MediaStreamTrackState ReadyState
        {
            get
            {
                return this.GetProperty<MediaStreamTrackState>("readyState");
            }
        }
        
        public nsISupports Clone()
        {
            return this.CallMethod<nsISupports>("clone");
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public object GetConstraints()
        {
            return this.CallMethod<object>("getConstraints");
        }
        
        public object GetSettings()
        {
            return this.CallMethod<object>("getSettings");
        }
        
        public Promise ApplyConstraints()
        {
            return this.CallMethod<Promise>("applyConstraints");
        }
        
        public Promise ApplyConstraints(object constraints)
        {
            return this.CallMethod<Promise>("applyConstraints", constraints);
        }
        
        public void MutedChanged(bool muted)
        {
            this.CallVoidMethod("mutedChanged", muted);
        }
    }
}
