namespace Gecko.WebIDL
{
    using System;
    
    
    public class MIDIMessageEvent : WebIDLBase
    {
        
        public MIDIMessageEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
