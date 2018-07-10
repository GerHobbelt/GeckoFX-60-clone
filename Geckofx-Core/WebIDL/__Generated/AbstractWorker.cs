namespace Gecko.WebIDL
{
    using System;
    
    
    public class AbstractWorker : WebIDLBase
    {
        
        public AbstractWorker(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
