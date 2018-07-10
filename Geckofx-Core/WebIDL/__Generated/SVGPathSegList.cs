namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegList : WebIDLBase
    {
        
        public SVGPathSegList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint NumberOfItems
        {
            get
            {
                return this.GetProperty<uint>("numberOfItems");
            }
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
