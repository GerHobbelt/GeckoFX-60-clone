namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLCollection : WebIDLBase
    {
        
        public HTMLCollection(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public nsIDOMElement Item(uint index)
        {
            return this.CallMethod<nsIDOMElement>("item", index);
        }
        
        public nsIDOMElement NamedItem(string name)
        {
            return this.CallMethod<nsIDOMElement>("namedItem", name);
        }
    }
}
