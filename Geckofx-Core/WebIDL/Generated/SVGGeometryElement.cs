namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGGeometryElement : WebIDLBase
    {
        
        public SVGGeometryElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports PathLength
        {
            get
            {
                return this.GetProperty<nsISupports>("pathLength");
            }
        }
        
        public float GetTotalLength()
        {
            return this.CallMethod<float>("getTotalLength");
        }
        
        public nsISupports GetPointAtLength(float distance)
        {
            return this.CallMethod<nsISupports>("getPointAtLength", distance);
        }
    }
}
