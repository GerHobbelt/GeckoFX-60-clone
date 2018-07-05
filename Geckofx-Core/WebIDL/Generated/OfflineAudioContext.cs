namespace Gecko.WebIDL
{
    using System;
    
    
    public class OfflineAudioContext : WebIDLBase
    {
        
        public OfflineAudioContext(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public Promise < nsISupports > StartRendering()
        {
            return this.CallMethod<Promise < nsISupports >>("startRendering");
        }
    }
}
