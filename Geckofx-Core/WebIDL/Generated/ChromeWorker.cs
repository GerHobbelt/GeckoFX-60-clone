namespace Gecko.WebIDL
{
    using System;
    
    
    public class ChromeWorker : WebIDLBase
    {
        
        public ChromeWorker(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
