namespace Gecko.WebIDL
{
    using System;
    
    
    public class GridTracks : WebIDLBase
    {
        
        public GridTracks(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
    }
}
