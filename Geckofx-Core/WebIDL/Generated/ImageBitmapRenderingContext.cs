namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageBitmapRenderingContext : WebIDLBase
    {
        
        public ImageBitmapRenderingContext(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void TransferFromImageBitmap(nsISupports bitmap)
        {
            this.CallVoidMethod("transferFromImageBitmap", bitmap);
        }
        
        public void TransferImageBitmap(nsISupports bitmap)
        {
            this.CallVoidMethod("transferImageBitmap", bitmap);
        }
    }
}
