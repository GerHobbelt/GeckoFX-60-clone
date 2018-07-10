namespace Gecko.WebIDL
{
    using System;
    
    
    public class FrameLoader : WebIDLBase
    {
        
        public FrameLoader(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports DocShell
        {
            get
            {
                return this.GetProperty<nsISupports>("docShell");
            }
        }
        
        public nsISupports TabParent
        {
            get
            {
                return this.GetProperty<nsISupports>("tabParent");
            }
        }
        
        public nsISupports LoadContext
        {
            get
            {
                return this.GetProperty<nsISupports>("loadContext");
            }
        }
        
        public bool DepthTooGreat
        {
            get
            {
                return this.GetProperty<bool>("depthTooGreat");
            }
        }
        
        public nsISupports MessageManager
        {
            get
            {
                return this.GetProperty<nsISupports>("messageManager");
            }
        }
        
        public uint EventMode
        {
            get
            {
                return this.GetProperty<uint>("eventMode");
            }
            set
            {
                this.SetProperty("eventMode", value);
            }
        }
        
        public bool ClipSubdocument
        {
            get
            {
                return this.GetProperty<bool>("clipSubdocument");
            }
            set
            {
                this.SetProperty("clipSubdocument", value);
            }
        }
        
        public bool ClampScrollPosition
        {
            get
            {
                return this.GetProperty<bool>("clampScrollPosition");
            }
            set
            {
                this.SetProperty("clampScrollPosition", value);
            }
        }
        
        public nsIDOMElement OwnerElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("ownerElement");
            }
        }
        
        public ulong ChildID
        {
            get
            {
                return this.GetProperty<ulong>("childID");
            }
        }
        
        public bool OwnerIsMozBrowserFrame
        {
            get
            {
                return this.GetProperty<bool>("ownerIsMozBrowserFrame");
            }
        }
        
        public uint LazyWidth
        {
            get
            {
                return this.GetProperty<uint>("lazyWidth");
            }
        }
        
        public uint LazyHeight
        {
            get
            {
                return this.GetProperty<uint>("lazyHeight");
            }
        }
        
        public bool IsDead
        {
            get
            {
                return this.GetProperty<bool>("isDead");
            }
        }
        
        public void LoadFrame()
        {
            this.CallVoidMethod("loadFrame");
        }
        
        public void LoadFrame(bool originalSrc)
        {
            this.CallVoidMethod("loadFrame", originalSrc);
        }
        
        public void LoadURI(nsISupports aURI)
        {
            this.CallVoidMethod("loadURI", aURI);
        }
        
        public void LoadURI(nsISupports aURI, bool originalSrc)
        {
            this.CallVoidMethod("loadURI", aURI, originalSrc);
        }
        
        public void AddProcessChangeBlockingPromise(Promise <object> aPromise)
        {
            this.CallVoidMethod("addProcessChangeBlockingPromise", aPromise);
        }
        
        public void Destroy()
        {
            this.CallVoidMethod("destroy");
        }
        
        public void ActivateRemoteFrame()
        {
            this.CallVoidMethod("activateRemoteFrame");
        }
        
        public void DeactivateRemoteFrame()
        {
            this.CallVoidMethod("deactivateRemoteFrame");
        }
        
        public void SendCrossProcessMouseEvent(string aType, float aX, float aY, int aButton, int aClickCount, int aModifiers)
        {
            this.CallVoidMethod("sendCrossProcessMouseEvent", aType, aX, aY, aButton, aClickCount, aModifiers);
        }
        
        public void SendCrossProcessMouseEvent(string aType, float aX, float aY, int aButton, int aClickCount, int aModifiers, bool aIgnoreRootScrollFrame)
        {
            this.CallVoidMethod("sendCrossProcessMouseEvent", aType, aX, aY, aButton, aClickCount, aModifiers, aIgnoreRootScrollFrame);
        }
        
        public void ActivateFrameEvent(string aType, bool capture)
        {
            this.CallVoidMethod("activateFrameEvent", aType, capture);
        }
        
        public void RequestNotifyAfterRemotePaint()
        {
            this.CallVoidMethod("requestNotifyAfterRemotePaint");
        }
        
        public void RequestFrameLoaderClose()
        {
            this.CallVoidMethod("requestFrameLoaderClose");
        }
        
        public void RequestUpdatePosition()
        {
            this.CallVoidMethod("requestUpdatePosition");
        }
        
        public void Print(ulong aOuterWindowID, nsISupports aPrintSettings)
        {
            this.CallVoidMethod("print", aOuterWindowID, aPrintSettings);
        }
        
        public void Print(ulong aOuterWindowID, nsISupports aPrintSettings, nsISupports aProgressListener)
        {
            this.CallVoidMethod("print", aOuterWindowID, aPrintSettings, aProgressListener);
        }
    }
}
