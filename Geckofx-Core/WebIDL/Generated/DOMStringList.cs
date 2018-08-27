namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMStringList : WebIDLBase
    {
        
        public DOMStringList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public string Item(uint index)
        {
            return this.CallMethod<string>("item", index);
        }
        
        public bool Contains(string @string)
        {
            return this.CallMethod<bool>("contains", @string);
        }
    }
}
