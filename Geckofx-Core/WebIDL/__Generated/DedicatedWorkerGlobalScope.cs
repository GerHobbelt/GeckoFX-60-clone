namespace Gecko.WebIDL
{
    using System;
    
    
    public class DedicatedWorkerGlobalScope : WebIDLBase
    {
        
        public DedicatedWorkerGlobalScope(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void PostMessage(object message, object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, transfer);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
