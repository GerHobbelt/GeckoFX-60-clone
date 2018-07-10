namespace Gecko.WebIDL
{
    using System;
    
    
    public class TestInterfaceMaplike : WebIDLBase
    {
        
        public TestInterfaceMaplike(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SetInternal(string aKey, int aValue)
        {
            this.CallVoidMethod("setInternal", aKey, aValue);
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
