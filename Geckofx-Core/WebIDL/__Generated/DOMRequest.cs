namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRequest : WebIDLBase
    {
        
        public DOMRequest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Then()
        {
            return this.CallMethod<object>("then");
        }
        
        public void FireDetailedError(nsIDOMDOMException aError)
        {
            this.CallVoidMethod("fireDetailedError", aError);
        }
    }
}
