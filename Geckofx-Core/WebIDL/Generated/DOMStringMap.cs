namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMStringMap : WebIDLBase
    {
        
        public DOMStringMap(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string NamedGetter(string name)
        {
            return this.CallMethod<string>("NamedGetter", name);
        }
    }
}
