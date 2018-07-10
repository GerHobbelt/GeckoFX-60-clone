namespace Gecko.WebIDL
{
    using System;
    
    
    public class AuthenticatorAttestationResponse : WebIDLBase
    {
        
        public AuthenticatorAttestationResponse(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr AttestationObject
        {
            get
            {
                return this.GetProperty<IntPtr>("attestationObject");
            }
        }
    }
}
