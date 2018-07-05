namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozObserver : WebIDLBase
    {
        
        public MozObserver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
