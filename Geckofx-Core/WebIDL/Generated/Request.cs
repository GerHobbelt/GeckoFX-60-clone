namespace Gecko.WebIDL
{
    using System;
    
    
    public class Request : WebIDLBase
    {
        
        public Request(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ByteString Method
        {
            get
            {
                return this.GetProperty<ByteString>("method");
            }
        }
        
        public USVString Url
        {
            get
            {
                return this.GetProperty<USVString>("url");
            }
        }
        
        public nsISupports Headers
        {
            get
            {
                return this.GetProperty<nsISupports>("headers");
            }
        }
        
        public RequestContext Context
        {
            get
            {
                return this.GetProperty<RequestContext>("context");
            }
        }
        
        public USVString Referrer
        {
            get
            {
                return this.GetProperty<USVString>("referrer");
            }
        }
        
        public ReferrerPolicy ReferrerPolicy
        {
            get
            {
                return this.GetProperty<ReferrerPolicy>("referrerPolicy");
            }
        }
        
        public RequestMode Mode
        {
            get
            {
                return this.GetProperty<RequestMode>("mode");
            }
        }
        
        public RequestCredentials Credentials
        {
            get
            {
                return this.GetProperty<RequestCredentials>("credentials");
            }
        }
        
        public RequestCache Cache
        {
            get
            {
                return this.GetProperty<RequestCache>("cache");
            }
        }
        
        public RequestRedirect Redirect
        {
            get
            {
                return this.GetProperty<RequestRedirect>("redirect");
            }
        }
        
        public string Integrity
        {
            get
            {
                return this.GetProperty<string>("integrity");
            }
        }
        
        public bool MozErrors
        {
            get
            {
                return this.GetProperty<bool>("mozErrors");
            }
        }
        
        public nsISupports Signal
        {
            get
            {
                return this.GetProperty<nsISupports>("signal");
            }
        }
        
        public nsISupports Clone()
        {
            return this.CallMethod<nsISupports>("clone");
        }
        
        public void OverrideContentPolicyType(uint context)
        {
            this.CallVoidMethod("overrideContentPolicyType", context);
        }
    }
}
