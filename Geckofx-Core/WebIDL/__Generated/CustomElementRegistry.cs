namespace Gecko.WebIDL
{
    using System;
    
    
    public class CustomElementRegistry : WebIDLBase
    {
        
        public CustomElementRegistry(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Get(string name)
        {
            return this.CallMethod<object>("get", name);
        }
        
        public Promise WhenDefined(string name)
        {
            return this.CallMethod<Promise>("whenDefined", name);
        }
    }
}
