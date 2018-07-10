namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegLinetoVerticalAbs : WebIDLBase
    {
        
        public SVGPathSegLinetoVerticalAbs(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
