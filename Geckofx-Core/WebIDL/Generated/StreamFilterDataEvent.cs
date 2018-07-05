namespace Gecko.WebIDL
{
    using System;
    
    
    public class StreamFilterDataEvent : WebIDLBase
    {
        
        public StreamFilterDataEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr Data
        {
            get
            {
                return this.GetProperty<IntPtr>("data");
            }
        }
    }
}
