namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowRoot : WebIDLBase
    {
        
        public WindowRoot(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
