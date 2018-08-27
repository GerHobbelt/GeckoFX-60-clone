namespace Gecko.WebIDL
{
    using System;
    
    
    public class MimeTypeArray : WebIDLBase
    {
        
        public MimeTypeArray(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports NamedItem(string name)
        {
            return this.CallMethod<nsISupports>("namedItem", name);
        }
    }
}
