namespace Gecko.WebIDL
{
    using System;
    
    
    public class SharedWorkerGlobalScope : WebIDLBase
    {
        
        public SharedWorkerGlobalScope(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
