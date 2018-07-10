namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasImageData : WebIDLBase
    {
        
        public CanvasImageData(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateImageData(double sw, double sh)
        {
            return this.CallMethod<nsISupports>("createImageData", sw, sh);
        }
        
        public nsISupports CreateImageData(nsISupports imagedata)
        {
            return this.CallMethod<nsISupports>("createImageData", imagedata);
        }
        
        public nsISupports GetImageData(double sx, double sy, double sw, double sh)
        {
            return this.CallMethod<nsISupports>("getImageData", sx, sy, sw, sh);
        }
        
        public void PutImageData(nsISupports imagedata, double dx, double dy)
        {
            this.CallVoidMethod("putImageData", imagedata, dx, dy);
        }
        
        public void PutImageData(nsISupports imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight)
        {
            this.CallVoidMethod("putImageData", imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
        }
    }
}
