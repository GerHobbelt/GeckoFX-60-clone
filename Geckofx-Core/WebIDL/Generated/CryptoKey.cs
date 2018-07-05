namespace Gecko.WebIDL
{
    using System;
    
    
    public class CryptoKey : WebIDLBase
    {
        
        public CryptoKey(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
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
        
        public string[] Usages
        {
            get
            {
                return this.GetProperty<string[]>("usages");
            }
        }
    }
}
