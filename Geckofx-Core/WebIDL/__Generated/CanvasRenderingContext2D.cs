namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasRenderingContext2D : WebIDLBase
    {
        
        public CanvasRenderingContext2D(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMHTMLCanvasElement Canvas
        {
            get
            {
                return this.GetProperty<nsIDOMHTMLCanvasElement>("canvas");
            }
        }
        
        public object MozCurrentTransform
        {
            get
            {
                return this.GetProperty<object>("mozCurrentTransform");
            }
            set
            {
                this.SetProperty("mozCurrentTransform", value);
            }
        }
        
        public object MozCurrentTransformInverse
        {
            get
            {
                return this.GetProperty<object>("mozCurrentTransformInverse");
            }
            set
            {
                this.SetProperty("mozCurrentTransformInverse", value);
            }
        }
        
        public string MozTextStyle
        {
            get
            {
                return this.GetProperty<string>("mozTextStyle");
            }
            set
            {
                this.SetProperty("mozTextStyle", value);
            }
        }
        
        public bool MozImageSmoothingEnabled
        {
            get
            {
                return this.GetProperty<bool>("mozImageSmoothingEnabled");
            }
            set
            {
                this.SetProperty("mozImageSmoothingEnabled", value);
            }
        }
        
        public void DrawWindow(nsIDOMWindow window, double x, double y, double w, double h, string bgColor)
        {
            this.CallVoidMethod("drawWindow", window, x, y, w, h, bgColor);
        }
        
        public void DrawWindow(nsIDOMWindow window, double x, double y, double w, double h, string bgColor, uint flags)
        {
            this.CallVoidMethod("drawWindow", window, x, y, w, h, bgColor, flags);
        }
        
        public void Demote()
        {
            this.CallVoidMethod("demote");
        }
    }
}
