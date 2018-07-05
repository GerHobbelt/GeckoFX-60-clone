namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathNSResolver : WebIDLBase
    {
        
        public XPathNSResolver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string LookupNamespaceURI(string prefix)
        {
            return this.CallMethod<string>("lookupNamespaceURI", prefix);
        }
    }
}
