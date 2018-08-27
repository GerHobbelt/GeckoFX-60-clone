namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSRuleList : WebIDLBase
    {
        
        public CSSRuleList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
    }
}
