namespace Gecko.WebIDL
{
    using System;
    
    
    public class NamedNodeMap : WebIDLBase
    {
        
        public NamedNodeMap(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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

        public nsISupports Item(uint index)
        {
            return this.CallMethod<nsISupports>("item", index);
        }

        
        public nsISupports SetNamedItem(nsISupports arg)
        {
            return this.CallMethod<nsISupports>("setNamedItem", arg);
        }
        
        public nsISupports RemoveNamedItem(string name)
        {
            return this.CallMethod<nsISupports>("removeNamedItem", name);
        }

        public nsISupports GetNamedItem(string localName)
        {
            return this.CallMethod<nsISupports>("getNamedItem", localName);
        }

        public nsISupports GetNamedItemNS(string namespaceURI, string localName)
        {
            return this.CallMethod<nsISupports>("getNamedItemNS", namespaceURI, localName);
        }
        
        public nsISupports SetNamedItemNS(nsISupports arg)
        {
            return this.CallMethod<nsISupports>("setNamedItemNS", arg);
        }
        
        public nsISupports RemoveNamedItemNS(string namespaceURI, string localName)
        {
            return this.CallMethod<nsISupports>("removeNamedItemNS", namespaceURI, localName);
        }
    }
}
