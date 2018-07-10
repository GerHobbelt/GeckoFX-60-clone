namespace Gecko.WebIDL
{
    using System;
    
    
    public class AuthenticatorResponse : WebIDLBase
    {
        
        public AuthenticatorResponse(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr ClientDataJSON
        {
            get
            {
                return this.GetProperty<IntPtr>("clientDataJSON");
            }
        }
    }
}
