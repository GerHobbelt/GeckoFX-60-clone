namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegLinetoVerticalRel : WebIDLBase
    {
        
        public SVGPathSegLinetoVerticalRel(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float Y
        {
            get
            {
                return this.GetProperty<float>("y");
            }
            set
            {
                this.SetProperty("y", value);
            }
        }
    }
}
