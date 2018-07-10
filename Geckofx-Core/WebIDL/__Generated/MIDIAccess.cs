namespace Gecko.WebIDL
{
    using System;
    
    
    public class MIDIAccess : WebIDLBase
    {
        
        public MIDIAccess(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Inputs
        {
            get
            {
                return this.GetProperty<nsISupports>("inputs");
            }
        }
        
        public nsISupports Outputs
        {
            get
            {
                return this.GetProperty<nsISupports>("outputs");
            }
        }
        
        public bool SysexEnabled
        {
            get
            {
                return this.GetProperty<bool>("sysexEnabled");
            }
        }
    }
}
