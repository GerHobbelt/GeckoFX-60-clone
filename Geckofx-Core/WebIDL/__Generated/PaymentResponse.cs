namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentResponse : WebIDLBase
    {
        
        public PaymentResponse(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string RequestId
        {
            get
            {
                return this.GetProperty<string>("requestId");
            }
        }
        
        public string MethodName
        {
            get
            {
                return this.GetProperty<string>("methodName");
            }
        }
        
        public object Details
        {
            get
            {
                return this.GetProperty<object>("details");
            }
        }
        
        public nsISupports ShippingAddress
        {
            get
            {
                return this.GetProperty<nsISupports>("shippingAddress");
            }
        }
        
        public string ShippingOption
        {
            get
            {
                return this.GetProperty<string>("shippingOption");
            }
        }
        
        public string PayerName
        {
            get
            {
                return this.GetProperty<string>("payerName");
            }
        }
        
        public string PayerEmail
        {
            get
            {
                return this.GetProperty<string>("payerEmail");
            }
        }
        
        public string PayerPhone
        {
            get
            {
                return this.GetProperty<string>("payerPhone");
            }
        }
        
        public Promise Complete()
        {
            return this.CallMethod<Promise>("complete");
        }
        
        public Promise Complete(PaymentComplete result)
        {
            return this.CallMethod<Promise>("complete", result);
        }
    }
}
