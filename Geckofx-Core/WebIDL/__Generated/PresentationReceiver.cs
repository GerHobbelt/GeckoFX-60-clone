namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationReceiver : WebIDLBase
    {
        
        public PresentationReceiver(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > ConnectionList
        {
            get
            {
                return this.GetProperty<Promise < nsISupports >>("connectionList");
            }
        }
    }
}
