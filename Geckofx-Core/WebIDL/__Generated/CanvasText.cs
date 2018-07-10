namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasText : WebIDLBase
    {
        
        public CanvasText(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void FillText(string text, double x, double y)
        {
            this.CallVoidMethod("fillText", text, x, y);
        }
        
        public void FillText(string text, double x, double y, double maxWidth)
        {
            this.CallVoidMethod("fillText", text, x, y, maxWidth);
        }
        
        public void StrokeText(string text, double x, double y)
        {
            this.CallVoidMethod("strokeText", text, x, y);
        }
        
        public void StrokeText(string text, double x, double y, double maxWidth)
        {
            this.CallVoidMethod("strokeText", text, x, y, maxWidth);
        }
        
        public nsISupports MeasureText(string text)
        {
            return this.CallMethod<nsISupports>("measureText", text);
        }
    }
}
