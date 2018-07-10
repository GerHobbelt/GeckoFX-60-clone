namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasDrawImage : WebIDLBase
    {
        
        public CanvasDrawImage(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void DrawImage(WebIDLUnion<WebIDLUnion<nsIDOMHTMLImageElement,nsISupports>> image, double dx, double dy)
        {
            this.CallVoidMethod("drawImage", image, dx, dy);
        }
        
        public void DrawImage(WebIDLUnion<WebIDLUnion<nsIDOMHTMLImageElement,nsISupports>> image, double dx, double dy, double dw, double dh)
        {
            this.CallVoidMethod("drawImage", image, dx, dy, dw, dh);
        }
        
        public void DrawImage(WebIDLUnion<WebIDLUnion<nsIDOMHTMLImageElement,nsISupports>> image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh)
        {
            this.CallVoidMethod("drawImage", image, sx, sy, sw, sh, dx, dy, dw, dh);
        }
    }
}
