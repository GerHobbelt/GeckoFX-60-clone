namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasPathDrawingStyles : WebIDLBase
    {
        
        public CanvasPathDrawingStyles(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double LineWidth
        {
            get
            {
                return this.GetProperty<double>("lineWidth");
            }
            set
            {
                this.SetProperty("lineWidth", value);
            }
        }
        
        public string LineCap
        {
            get
            {
                return this.GetProperty<string>("lineCap");
            }
            set
            {
                this.SetProperty("lineCap", value);
            }
        }
        
        public string LineJoin
        {
            get
            {
                return this.GetProperty<string>("lineJoin");
            }
            set
            {
                this.SetProperty("lineJoin", value);
            }
        }
        
        public double MiterLimit
        {
            get
            {
                return this.GetProperty<double>("miterLimit");
            }
            set
            {
                this.SetProperty("miterLimit", value);
            }
        }
        
        public double LineDashOffset
        {
            get
            {
                return this.GetProperty<double>("lineDashOffset");
            }
            set
            {
                this.SetProperty("lineDashOffset", value);
            }
        }
        
        public void SetLineDash(double[] segments)
        {
            this.CallVoidMethod("setLineDash", segments);
        }
        
        public double[] GetLineDash()
        {
            return this.CallMethod<double[]>("getLineDash");
        }
    }
}
