namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaRecorderErrorEvent : WebIDLBase
    {
        
        public MediaRecorderErrorEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMDOMException Error
        {
            get
            {
                return this.GetProperty<nsIDOMDOMException>("error");
            }
        }
    }
}
