namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathElement : WebIDLBase
    {
        
        public SVGPathElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint GetPathSegAtLength(float distance)
        {
            return this.CallMethod<uint>("getPathSegAtLength", distance);
        }
    }
}
