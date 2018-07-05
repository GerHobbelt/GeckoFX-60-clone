namespace Gecko.WebIDL
{
    using System;
    
    
    public class Navigator : WebIDLBase
    {
        
        public Navigator(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Permissions
        {
            get
            {
                return this.GetProperty<nsISupports>("permissions");
            }
        }
        
        public nsISupports MimeTypes
        {
            get
            {
                return this.GetProperty<nsISupports>("mimeTypes");
            }
        }
        
        public nsISupports Plugins
        {
            get
            {
                return this.GetProperty<nsISupports>("plugins");
            }
        }
        
        public string DoNotTrack
        {
            get
            {
                return this.GetProperty<string>("doNotTrack");
            }
        }
        
        public Promise < nsISupports > GetBattery()
        {
            return this.CallMethod<Promise < nsISupports >>("getBattery");
        }
        
        public bool Vibrate(uint duration)
        {
            return this.CallMethod<bool>("vibrate", duration);
        }
        
        public bool Vibrate(uint[] pattern)
        {
            return this.CallMethod<bool>("vibrate", pattern);
        }
        
        public int MaxTouchPoints
        {
            get
            {
                return this.GetProperty<int>("maxTouchPoints");
            }
        }
        
        public void SetVibrationPermission(bool permitted)
        {
            this.CallVoidMethod("setVibrationPermission", permitted);
        }
        
        public void SetVibrationPermission(bool permitted, bool persistent)
        {
            this.CallVoidMethod("setVibrationPermission", permitted, persistent);
        }
        
        public string Oscpu
        {
            get
            {
                return this.GetProperty<string>("oscpu");
            }
        }
        
        public string Vendor
        {
            get
            {
                return this.GetProperty<string>("vendor");
            }
        }
        
        public string VendorSub
        {
            get
            {
                return this.GetProperty<string>("vendorSub");
            }
        }
        
        public string ProductSub
        {
            get
            {
                return this.GetProperty<string>("productSub");
            }
        }
        
        public bool CookieEnabled
        {
            get
            {
                return this.GetProperty<bool>("cookieEnabled");
            }
        }
        
        public string BuildID
        {
            get
            {
                return this.GetProperty<string>("buildID");
            }
        }
        
        public bool JavaEnabled()
        {
            return this.CallMethod<bool>("javaEnabled");
        }
        
        public void AddIdleObserver(nsISupports aIdleObserver)
        {
            this.CallVoidMethod("addIdleObserver", aIdleObserver);
        }
        
        public void RemoveIdleObserver(nsISupports aIdleObserver)
        {
            this.CallVoidMethod("removeIdleObserver", aIdleObserver);
        }
        
        public nsISupports Connection
        {
            get
            {
                return this.GetProperty<nsISupports>("connection");
            }
        }
        
        public nsISupports[] GetGamepads()
        {
            return this.CallMethod<nsISupports[]>("getGamepads");
        }
        
        public nsISupports RequestGamepadServiceTest()
        {
            return this.CallMethod<nsISupports>("requestGamepadServiceTest");
        }
        
        public nsISupports[] ActiveVRDisplays
        {
            get
            {
                return this.GetProperty<nsISupports[]>("activeVRDisplays");
            }
        }
        
        public bool IsWebVRContentDetected
        {
            get
            {
                return this.GetProperty<bool>("isWebVRContentDetected");
            }
        }
        
        public bool IsWebVRContentPresenting
        {
            get
            {
                return this.GetProperty<bool>("isWebVRContentPresenting");
            }
        }
        
        public Promise < nsISupports[] > GetVRDisplays()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getVRDisplays");
        }
        
        public void RequestVRPresentation(nsISupports display)
        {
            this.CallVoidMethod("requestVRPresentation", display);
        }
        
        public nsISupports RequestVRServiceTest()
        {
            return this.CallMethod<nsISupports>("requestVRServiceTest");
        }
        
        public Promise < nsISupports > RequestMIDIAccess()
        {
            return this.CallMethod<Promise < nsISupports >>("requestMIDIAccess");
        }
        
        public Promise < nsISupports > RequestMIDIAccess(object options)
        {
            return this.CallMethod<Promise < nsISupports >>("requestMIDIAccess", options);
        }
        
        public nsISupports MediaDevices
        {
            get
            {
                return this.GetProperty<nsISupports>("mediaDevices");
            }
        }
        
        public nsISupports ServiceWorker
        {
            get
            {
                return this.GetProperty<nsISupports>("serviceWorker");
            }
        }
        
        public bool SendBeacon(string url)
        {
            return this.CallMethod<bool>("sendBeacon", url);
        }
        
        public bool SendBeacon(string url, WebIDLUnion<nsIDOMBlob> data)
        {
            return this.CallMethod<bool>("sendBeacon", url, data);
        }
        
        public nsISupports Presentation
        {
            get
            {
                return this.GetProperty<nsISupports>("presentation");
            }
        }
        
        public nsISupports MozTCPSocket
        {
            get
            {
                return this.GetProperty<nsISupports>("mozTCPSocket");
            }
        }
        
        public Promise < nsISupports > RequestMediaKeySystemAccess(string keySystem, object[] supportedConfigurations)
        {
            return this.CallMethod<Promise < nsISupports >>("requestMediaKeySystemAccess", keySystem, supportedConfigurations);
        }
        
        public nsISupports Credentials
        {
            get
            {
                return this.GetProperty<nsISupports>("credentials");
            }
        }
    }
}
