namespace Gecko.WebIDL
{
    using System;
    
    
    public class TestInterfaceJSMaplike : WebIDLBase
    {
        
        public TestInterfaceJSMaplike(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
    }
}
