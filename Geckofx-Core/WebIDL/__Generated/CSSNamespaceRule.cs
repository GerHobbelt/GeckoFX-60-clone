namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSNamespaceRule : WebIDLBase
    {
        
        public CSSNamespaceRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string NamespaceURI
        {
            get
            {
                return this.GetProperty<string>("namespaceURI");
            }
        }
        
        public string Prefix
        {
            get
            {
                return this.GetProperty<string>("prefix");
            }
        }
    }
}
