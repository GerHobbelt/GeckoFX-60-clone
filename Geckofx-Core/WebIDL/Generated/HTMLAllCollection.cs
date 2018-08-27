namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAllCollection : WebIDLBase
    {
        
        public HTMLAllCollection(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsIDOMNode IndexedGetter(uint index)
        {
            return this.CallMethod<nsIDOMNode>("IndexedGetter", index);
        }
        
        public nsIDOMNode Item(uint index)
        {
            return this.CallMethod<nsIDOMNode>("item", index);
        }
        
        public WebIDLUnion<nsIDOMNode,nsISupports> Item(string name)
        {
            return this.CallMethod<WebIDLUnion<nsIDOMNode,nsISupports>>("item", name);
        }
        
        public WebIDLUnion<nsIDOMNode,nsISupports> NamedItem(string name)
        {
            return this.CallMethod<WebIDLUnion<nsIDOMNode,nsISupports>>("namedItem", name);
        }
    }
}
