namespace Gecko.WebIDL
{
    using System;
    
    
    public class HiddenPluginEvent : WebIDLBase
    {
        
        public HiddenPluginEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Tag
        {
            get
            {
                return this.GetProperty<nsISupports>("tag");
            }
        }
    }
}
