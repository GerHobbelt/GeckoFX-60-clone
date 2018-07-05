namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkletGlobalScope : WebIDLBase
    {
        
        public WorkletGlobalScope(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Dump()
        {
            this.CallVoidMethod("dump");
        }
        
        public void Dump(string str)
        {
            this.CallVoidMethod("dump", str);
        }
    }
}
