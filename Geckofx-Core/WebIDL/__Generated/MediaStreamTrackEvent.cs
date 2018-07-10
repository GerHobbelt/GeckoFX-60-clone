namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamTrackEvent : WebIDLBase
    {
        
        public MediaStreamTrackEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
    }
}
