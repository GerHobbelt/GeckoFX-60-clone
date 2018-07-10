namespace Gecko.WebIDL
{
    using System;
    
    
    public class PublicKeyCredential : WebIDLBase
    {
        
        public PublicKeyCredential(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr RawId
        {
            get
            {
                return this.GetProperty<IntPtr>("rawId");
            }
        }
        
        public nsISupports Response
        {
            get
            {
                return this.GetProperty<nsISupports>("response");
            }
        }
        
        public object GetClientExtensionResults()
        {
            return this.CallMethod<object>("getClientExtensionResults");
        }
    }
}
