namespace Gecko.WebIDL
{
    using System;
    
    
    public class AbortSignal : WebIDLBase
    {
        
        public AbortSignal(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Aborted
        {
            get
            {
                return this.GetProperty<bool>("aborted");
            }
        }
    }
}
