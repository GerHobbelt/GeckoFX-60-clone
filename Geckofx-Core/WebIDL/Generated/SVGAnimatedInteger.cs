namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedInteger : WebIDLBase
    {
        
        public SVGAnimatedInteger(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int BaseVal
        {
            get
            {
                return this.GetProperty<int>("baseVal");
            }
            set
            {
                this.SetProperty("baseVal", value);
            }
        }
        
        public int AnimVal
        {
            get
            {
                return this.GetProperty<int>("animVal");
            }
        }
    }
}
