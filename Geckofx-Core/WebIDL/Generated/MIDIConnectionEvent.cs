namespace Gecko.WebIDL
{
    using System;
    
    
    public class MIDIConnectionEvent : WebIDLBase
    {
        
        public MIDIConnectionEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Port
        {
            get
            {
                return this.GetProperty<nsISupports>("port");
            }
        }
    }
}
