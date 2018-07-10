namespace Gecko.WebIDL
{
    using System;
    
    
    public class AuthenticatorAssertionResponse : WebIDLBase
    {
        
        public AuthenticatorAssertionResponse(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr AuthenticatorData
        {
            get
            {
                return this.GetProperty<IntPtr>("authenticatorData");
            }
        }
        
        public IntPtr Signature
        {
            get
            {
                return this.GetProperty<IntPtr>("signature");
            }
        }
        
        public IntPtr UserHandle
        {
            get
            {
                return this.GetProperty<IntPtr>("userHandle");
            }
        }
    }
}
