namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaymentAddress : WebIDLBase
    {
        
        public PaymentAddress(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Country
        {
            get
            {
                return this.GetProperty<string>("country");
            }
        }
        
        public string[] AddressLine
        {
            get
            {
                return this.GetProperty<string[]>("addressLine");
            }
        }
        
        public string Region
        {
            get
            {
                return this.GetProperty<string>("region");
            }
        }
        
        public string City
        {
            get
            {
                return this.GetProperty<string>("city");
            }
        }
        
        public string DependentLocality
        {
            get
            {
                return this.GetProperty<string>("dependentLocality");
            }
        }
        
        public string PostalCode
        {
            get
            {
                return this.GetProperty<string>("postalCode");
            }
        }
        
        public string SortingCode
        {
            get
            {
                return this.GetProperty<string>("sortingCode");
            }
        }
        
        public string LanguageCode
        {
            get
            {
                return this.GetProperty<string>("languageCode");
            }
        }
        
        public string Organization
        {
            get
            {
                return this.GetProperty<string>("organization");
            }
        }
        
        public string Recipient
        {
            get
            {
                return this.GetProperty<string>("recipient");
            }
        }
        
        public string Phone
        {
            get
            {
                return this.GetProperty<string>("phone");
            }
        }
    }
}
