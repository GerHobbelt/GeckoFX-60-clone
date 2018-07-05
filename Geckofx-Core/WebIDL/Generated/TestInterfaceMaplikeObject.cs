namespace Gecko.WebIDL
{
    using System;
    
    
    public class TestInterfaceMaplikeObject : WebIDLBase
    {
        
        public TestInterfaceMaplikeObject(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SetInternal(string aKey)
        {
            this.CallVoidMethod("setInternal", aKey);
        }
        
        public void ClearInternal()
        {
            this.CallVoidMethod("clearInternal");
        }
        
        public bool DeleteInternal(string aKey)
        {
            return this.CallMethod<bool>("deleteInternal", aKey);
        }
        
        public bool HasInternal(string aKey)
        {
            return this.CallMethod<bool>("hasInternal", aKey);
        }
    }
}
