namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMCursor : WebIDLBase
    {
        
        public DOMCursor(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Done
        {
            get
            {
                return this.GetProperty<bool>("done");
            }
        }
        
        public void Continue()
        {
            this.CallVoidMethod("continue");
        }
    }
}
