namespace Gecko.WebIDL
{
    using System;
    
    
    public class TestFunctions : WebIDLBase
    {
        
        public TestFunctions(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SetStringData(string arg)
        {
            this.CallVoidMethod("setStringData", arg);
        }
        
        public string GetStringDataAsAString()
        {
            return this.CallMethod<string>("getStringDataAsAString");
        }
        
        public string GetStringDataAsAString(uint length)
        {
            return this.CallMethod<string>("getStringDataAsAString", length);
        }
        
        public string GetStringDataAsDOMString()
        {
            return this.CallMethod<string>("getStringDataAsDOMString");
        }
        
        public string GetStringDataAsDOMString(uint length)
        {
            return this.CallMethod<string>("getStringDataAsDOMString", length);
        }
        
        public void TestThrowNsresult()
        {
            this.CallVoidMethod("testThrowNsresult");
        }
        
        public void TestThrowNsresultFromNative()
        {
            this.CallVoidMethod("testThrowNsresultFromNative");
        }
    }
}
