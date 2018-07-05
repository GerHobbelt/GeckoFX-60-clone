namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnectionList : WebIDLBase
    {
        
        public PresentationConnectionList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] Connections
        {
            get
            {
                return this.GetProperty<nsISupports[]>("connections");
            }
        }
    }
}
