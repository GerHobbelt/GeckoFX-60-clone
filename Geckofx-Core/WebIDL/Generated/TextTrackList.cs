namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextTrackList : WebIDLBase
    {
        
        public TextTrackList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports IndexedGetter(uint index)
        {
            return this.CallMethod<nsISupports>("IndexedGetter", index);
        }
        
        public nsISupports GetTrackById(string id)
        {
            return this.CallMethod<nsISupports>("getTrackById", id);
        }
        
        public nsISupports MediaElement
        {
            get
            {
                return this.GetProperty<nsISupports>("mediaElement");
            }
        }
    }
}
