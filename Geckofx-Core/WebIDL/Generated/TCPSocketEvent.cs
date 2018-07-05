namespace Gecko.WebIDL
{
    using System;
    
    
    public class TCPSocketEvent : WebIDLBase
    {
        
        public TCPSocketEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
    }
}
