namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaQueryList : WebIDLBase
    {
        
        public MediaQueryList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Media
        {
            get
            {
                return this.GetProperty<string>("media");
            }
        }
        
        public bool Matches
        {
            get
            {
                return this.GetProperty<bool>("matches");
            }
        }
        
        public void AddListener(nsISupports listener)
        {
            this.CallVoidMethod("addListener", listener);
        }
        
        public void RemoveListener(nsISupports listener)
        {
            this.CallVoidMethod("removeListener", listener);
        }
    }
}
