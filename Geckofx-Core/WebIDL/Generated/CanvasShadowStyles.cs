namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasShadowStyles : WebIDLBase
    {
        
        public CanvasShadowStyles(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double ShadowOffsetX
        {
            get
            {
                return this.GetProperty<double>("shadowOffsetX");
            }
            set
            {
                this.SetProperty("shadowOffsetX", value);
            }
        }
        
        public double ShadowOffsetY
        {
            get
            {
                return this.GetProperty<double>("shadowOffsetY");
            }
            set
            {
                this.SetProperty("shadowOffsetY", value);
            }
        }
        
        public double ShadowBlur
        {
            get
            {
                return this.GetProperty<double>("shadowBlur");
            }
            set
            {
                this.SetProperty("shadowBlur", value);
            }
        }
        
        public string ShadowColor
        {
            get
            {
                return this.GetProperty<string>("shadowColor");
            }
            set
            {
                this.SetProperty("shadowColor", value);
            }
        }
    }
}
