namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasFillStrokeStyles : WebIDLBase
    {
        
        public CanvasFillStrokeStyles(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<System.String,nsISupports,nsISupports> StrokeStyle
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.String,nsISupports,nsISupports>>("strokeStyle");
            }
            set
            {
                this.SetProperty("strokeStyle", value);
            }
        }
        
        public WebIDLUnion<System.String,nsISupports,nsISupports> FillStyle
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.String,nsISupports,nsISupports>>("fillStyle");
            }
            set
            {
                this.SetProperty("fillStyle", value);
            }
        }
        
        public nsISupports CreateLinearGradient(double x0, double y0, double x1, double y1)
        {
            return this.CallMethod<nsISupports>("createLinearGradient", x0, y0, x1, y1);
        }
        
        public nsISupports CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1)
        {
            return this.CallMethod<nsISupports>("createRadialGradient", x0, y0, r0, x1, y1, r1);
        }
        
        public nsISupports CreatePattern(WebIDLUnion<WebIDLUnion<nsIDOMHTMLImageElement,nsISupports>> image, string repetition)
        {
            return this.CallMethod<nsISupports>("createPattern", image, repetition);
        }
    }
}
