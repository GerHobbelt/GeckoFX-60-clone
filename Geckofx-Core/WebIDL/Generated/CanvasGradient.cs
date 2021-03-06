namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasGradient : WebIDLBase
    {
        
        public CanvasGradient(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddColorStop(float offset, string color)
        {
            this.CallVoidMethod("addColorStop", offset, color);
        }
    }
}
