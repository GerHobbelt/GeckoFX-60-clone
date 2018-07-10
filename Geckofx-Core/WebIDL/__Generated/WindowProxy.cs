namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowProxy : WebIDLBase
    {
        
        public WindowProxy(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
