namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasCaptureMediaStream : WebIDLBase
    {
        
        public CanvasCaptureMediaStream(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Canvas
        {
            get
            {
                return this.GetProperty<nsISupports>("canvas");
            }
        }
        
        public void RequestFrame()
        {
            this.CallVoidMethod("requestFrame");
        }
    }
}
