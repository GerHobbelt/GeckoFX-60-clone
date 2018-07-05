namespace Gecko.WebIDL
{
    using System;
    
    
    public class FetchObserver : WebIDLBase
    {
        
        public FetchObserver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public FetchState State
        {
            get
            {
                return this.GetProperty<FetchState>("state");
            }
        }
    }
}
