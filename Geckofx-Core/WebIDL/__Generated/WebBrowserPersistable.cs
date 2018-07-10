namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebBrowserPersistable : WebIDLBase
    {
        
        public WebBrowserPersistable(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void StartPersistence(ulong aOuterWindowID, nsISupports aRecv)
        {
            this.CallVoidMethod("startPersistence", aOuterWindowID, aRecv);
        }
    }
}
