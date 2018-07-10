namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_lose_context : WebIDLBase
    {
        
        public WEBGL_lose_context(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void LoseContext()
        {
            this.CallVoidMethod("loseContext");
        }
        
        public void RestoreContext()
        {
            this.CallVoidMethod("restoreContext");
        }
    }
}
