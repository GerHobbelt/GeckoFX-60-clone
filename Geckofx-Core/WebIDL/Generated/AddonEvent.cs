namespace Gecko.WebIDL
{
    using System;
    
    
    public class AddonEvent : WebIDLBase
    {
        
        public AddonEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public bool NeedsRestart
        {
            get
            {
                return this.GetProperty<bool>("needsRestart");
            }
        }
    }
}
