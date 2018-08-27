namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLFormControlsCollection : WebIDLBase
    {
        
        public HTMLFormControlsCollection(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<nsISupports,nsIDOMElement> NamedItem(string name)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,nsIDOMElement>>("namedItem", name);
        }
    }
}
