namespace Gecko.WebIDL
{
    using System;
    
    
    public class OfflineAudioCompletionEvent : WebIDLBase
    {
        
        public OfflineAudioCompletionEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports RenderedBuffer
        {
            get
            {
                return this.GetProperty<nsISupports>("renderedBuffer");
            }
        }
    }
}
