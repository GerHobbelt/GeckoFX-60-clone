namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBRequest : WebIDLBase
    {
        
        public IDBRequest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Result
        {
            get
            {
                return this.GetProperty<object>("result");
            }
        }
        
        public nsIDOMDOMException Error
        {
            get
            {
                return this.GetProperty<nsIDOMDOMException>("error");
            }
        }
        
        public WebIDLUnion<nsISupports,nsISupports,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports,nsISupports>>("source");
            }
        }
        
        public nsISupports Transaction
        {
            get
            {
                return this.GetProperty<nsISupports>("transaction");
            }
        }
        
        public IDBRequestReadyState ReadyState
        {
            get
            {
                return this.GetProperty<IDBRequestReadyState>("readyState");
            }
        }
    }
}
