namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSValueList : WebIDLBase
    {
        
        public CSSValueList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
    }
}
