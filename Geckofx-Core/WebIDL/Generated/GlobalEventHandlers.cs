namespace Gecko.WebIDL
{
    using System;
    
    
    public class GlobalEventHandlers : WebIDLBase
    {
        
        public GlobalEventHandlers(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
