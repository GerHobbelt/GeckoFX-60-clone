namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextTrackCueList : WebIDLBase
    {
        
        public TextTrackCueList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports GetCueById(string id)
        {
            return this.CallMethod<nsISupports>("getCueById", id);
        }
    }
}
