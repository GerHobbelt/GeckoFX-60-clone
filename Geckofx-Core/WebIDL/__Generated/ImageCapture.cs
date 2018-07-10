namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageCapture : WebIDLBase
    {
        
        public ImageCapture(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports VideoStreamTrack
        {
            get
            {
                return this.GetProperty<nsISupports>("videoStreamTrack");
            }
        }
        
        public void TakePhoto()
        {
            this.CallVoidMethod("takePhoto");
        }
    }
}
