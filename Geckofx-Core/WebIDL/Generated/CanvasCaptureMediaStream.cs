namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasCaptureMediaStream : WebIDLBase
    {
        
        public CanvasCaptureMediaStream(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public /* nsIDOMHTMLCanvasElement */ nsISupports Canvas
        {
            get
            {
                return this.GetProperty</* nsIDOMHTMLCanvasElement */ nsISupports>("canvas");
            }
        }
        
        public void RequestFrame()
        {
            this.CallVoidMethod("requestFrame");
        }
    }
}
