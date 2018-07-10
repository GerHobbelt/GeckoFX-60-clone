namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasTransform : WebIDLBase
    {
        
        public CanvasTransform(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Scale(double x, double y)
        {
            this.CallVoidMethod("scale", x, y);
        }
        
        public void Rotate(double angle)
        {
            this.CallVoidMethod("rotate", angle);
        }
        
        public void Translate(double x, double y)
        {
            this.CallVoidMethod("translate", x, y);
        }
        
        public void Transform(double a, double b, double c, double d, double e, double f)
        {
            this.CallVoidMethod("transform", a, b, c, d, e, f);
        }
        
        public void SetTransform(double a, double b, double c, double d, double e, double f)
        {
            this.CallVoidMethod("setTransform", a, b, c, d, e, f);
        }
        
        public void ResetTransform()
        {
            this.CallVoidMethod("resetTransform");
        }
    }
}
