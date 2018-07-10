namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasState : WebIDLBase
    {
        
        public CanvasState(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Save()
        {
            this.CallVoidMethod("save");
        }
        
        public void Restore()
        {
            this.CallVoidMethod("restore");
        }
    }
}
