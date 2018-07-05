namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasDrawPath : WebIDLBase
    {
        
        public CanvasDrawPath(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void BeginPath()
        {
            this.CallVoidMethod("beginPath");
        }
        
        public void Fill()
        {
            this.CallVoidMethod("fill");
        }
        
        public void Fill(CanvasWindingRule winding)
        {
            this.CallVoidMethod("fill", winding);
        }
        
        public void Fill(nsISupports path)
        {
            this.CallVoidMethod("fill", path);
        }
        
        public void Fill(nsISupports path, CanvasWindingRule winding)
        {
            this.CallVoidMethod("fill", path, winding);
        }
        
        public void Stroke()
        {
            this.CallVoidMethod("stroke");
        }
        
        public void Stroke(nsISupports path)
        {
            this.CallVoidMethod("stroke", path);
        }
        
        public void Clip()
        {
            this.CallVoidMethod("clip");
        }
        
        public void Clip(CanvasWindingRule winding)
        {
            this.CallVoidMethod("clip", winding);
        }
        
        public void Clip(nsISupports path)
        {
            this.CallVoidMethod("clip", path);
        }
        
        public void Clip(nsISupports path, CanvasWindingRule winding)
        {
            this.CallVoidMethod("clip", path, winding);
        }
        
        public bool IsPointInPath(double x, double y)
        {
            return this.CallMethod<bool>("isPointInPath", x, y);
        }
        
        public bool IsPointInPath(double x, double y, CanvasWindingRule winding)
        {
            return this.CallMethod<bool>("isPointInPath", x, y, winding);
        }
        
        public bool IsPointInPath(nsISupports path, double x, double y)
        {
            return this.CallMethod<bool>("isPointInPath", path, x, y);
        }
        
        public bool IsPointInPath(nsISupports path, double x, double y, CanvasWindingRule winding)
        {
            return this.CallMethod<bool>("isPointInPath", path, x, y, winding);
        }
        
        public bool IsPointInStroke(double x, double y)
        {
            return this.CallMethod<bool>("isPointInStroke", x, y);
        }
        
        public bool IsPointInStroke(nsISupports path, double x, double y)
        {
            return this.CallMethod<bool>("isPointInStroke", path, x, y);
        }
    }
}
