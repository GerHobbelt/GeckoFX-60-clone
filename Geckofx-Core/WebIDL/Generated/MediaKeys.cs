namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeys : WebIDLBase
    {
        
        public MediaKeys(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string KeySystem
        {
            get
            {
                return this.GetProperty<string>("keySystem");
            }
        }
        
        public nsISupports CreateSession()
        {
            return this.CallMethod<nsISupports>("createSession");
        }
        
        public nsISupports CreateSession(MediaKeySessionType sessionType)
        {
            return this.CallMethod<nsISupports>("createSession", sessionType);
        }
        
        public Promise SetServerCertificate(IntPtr serverCertificate)
        {
            return this.CallMethod<Promise>("setServerCertificate", serverCertificate);
        }
        
        public Promise < MediaKeyStatus > GetStatusForPolicy()
        {
            return this.CallMethod<Promise < MediaKeyStatus >>("getStatusForPolicy");
        }
        
        public Promise < MediaKeyStatus > GetStatusForPolicy(object policy)
        {
            return this.CallMethod<Promise < MediaKeyStatus >>("getStatusForPolicy", policy);
        }
    }
}
