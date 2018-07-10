namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioDestinationNode : WebIDLBase
    {
        
        public AudioDestinationNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint MaxChannelCount
        {
            get
            {
                return this.GetProperty<uint>("maxChannelCount");
            }
        }
    }
}
