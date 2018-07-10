namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSeg : WebIDLBase
    {
        
        public SVGPathSeg(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort PathSegType
        {
            get
            {
                return this.GetProperty<ushort>("pathSegType");
            }
        }
        
        public string PathSegTypeAsLetter
        {
            get
            {
                return this.GetProperty<string>("pathSegTypeAsLetter");
            }
        }
    }
}
