namespace Gecko.WebIDL
{
    using System;
    
    
    public class GroupedHistoryEvent : WebIDLBase
    {
        
        public GroupedHistoryEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement OtherBrowser
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("otherBrowser");
            }
        }
    }
}
