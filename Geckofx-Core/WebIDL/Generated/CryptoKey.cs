namespace Gecko.WebIDL
{
    using System;
    
    
    public class CryptoKey : WebIDLBase
    {
        
        public CryptoKey(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
        
        public bool Extractable
        {
            get
            {
                return this.GetProperty<bool>("extractable");
            }
        }
        
        public object Algorithm
        {
            get
            {
                return this.GetProperty<object>("algorithm");
            }
        }
        
        public nsAString[] Usages
        {
            get
            {
                return this.GetProperty<nsAString[]>("usages");
            }
        }
    }
}
