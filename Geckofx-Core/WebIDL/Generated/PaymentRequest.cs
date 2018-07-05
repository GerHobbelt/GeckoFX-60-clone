namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentRequest : WebIDLBase
    {
        
        public PaymentRequest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
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
        
        public PaymentShippingType ShippingType
        {
            get
            {
                return this.GetProperty<PaymentShippingType>("shippingType");
            }
        }
        
        public Promise < nsISupports > Show()
        {
            return this.CallMethod<Promise < nsISupports >>("show");
        }
        
        public Promise Abort()
        {
            return this.CallMethod<Promise>("abort");
        }
        
        public Promise <bool> CanMakePayment()
        {
            return this.CallMethod<Promise <bool>>("canMakePayment");
        }
    }
}
