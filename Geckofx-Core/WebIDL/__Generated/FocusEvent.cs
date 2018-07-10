namespace Gecko.WebIDL
{
    using System;
    
    
    public class FocusEvent : WebIDLBase
    {
        
        public FocusEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports RelatedTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("relatedTarget");
            }
        }
    }
}
