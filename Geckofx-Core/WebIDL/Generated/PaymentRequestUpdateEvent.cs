namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentRequestUpdateEvent : WebIDLBase
    {
        
        public PaymentRequestUpdateEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void UpdateWith(Promise <object> detailsPromise)
        {
            this.CallVoidMethod("updateWith", detailsPromise);
        }
    }
}
