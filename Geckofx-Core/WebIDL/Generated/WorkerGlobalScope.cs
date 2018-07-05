namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkerGlobalScope : WebIDLBase
    {
        
        public WorkerGlobalScope(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Self
        {
            get
            {
                return this.GetProperty<nsISupports>("self");
            }
        }
        
        public nsISupports Location
        {
            get
            {
                return this.GetProperty<nsISupports>("location");
            }
        }
        
        public nsISupports Navigator
        {
            get
            {
                return this.GetProperty<nsISupports>("navigator");
            }
        }
        
        public void ImportScripts(string urls)
        {
            this.CallVoidMethod("importScripts", urls);
        }
        
        public nsISupports Performance
        {
            get
            {
                return this.GetProperty<nsISupports>("performance");
            }
        }
        
        public void Dump()
        {
            this.CallVoidMethod("dump");
        }
        
        public void Dump(string str)
        {
            this.CallVoidMethod("dump", str);
        }
        
        public object GetJSTestingFunctions()
        {
            return this.CallMethod<object>("getJSTestingFunctions");
        }
    }
}
