namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIdentityProviderRegistrar : WebIDLBase
    {
        
        public RTCIdentityProviderRegistrar(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool HasIdp
        {
            get
            {
                return this.GetProperty<bool>("hasIdp");
            }
        }
        
        public void Register(object idp)
        {
            this.CallVoidMethod("register", idp);
        }
        
        public Promise <object> GenerateAssertion(string contents, string origin)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin);
        }
        
        public Promise <object> GenerateAssertion(string contents, string origin, string usernameHint)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin, usernameHint);
        }
        
        public Promise <object> ValidateAssertion(string assertion, string origin)
        {
            return this.CallMethod<Promise <object>>("validateAssertion", assertion, origin);
        }
    }
}
