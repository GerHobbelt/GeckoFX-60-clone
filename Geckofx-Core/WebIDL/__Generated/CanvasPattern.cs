namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasPattern : WebIDLBase
    {
        
        public CanvasPattern(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SetTransform(nsISupports matrix)
        {
            this.CallVoidMethod("setTransform", matrix);
        }
    }
}
