namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasUserInterface : WebIDLBase
    {
        
        public CanvasUserInterface(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void DrawFocusIfNeeded(nsIDOMElement element)
        {
            this.CallVoidMethod("drawFocusIfNeeded", element);
        }
        
        public bool DrawCustomFocusRing(nsIDOMElement element)
        {
            return this.CallMethod<bool>("drawCustomFocusRing", element);
        }
    }
}
