namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasRect : WebIDLBase
    {
        
        public CanvasRect(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void ClearRect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("clearRect", x, y, w, h);
        }
        
        public void FillRect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("fillRect", x, y, w, h);
        }
        
        public void StrokeRect(double x, double y, double w, double h)
        {
            this.CallVoidMethod("strokeRect", x, y, w, h);
        }
    }
}
