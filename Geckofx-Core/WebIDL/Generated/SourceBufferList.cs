namespace Gecko.WebIDL
{
    using System;
    
    
    public class SourceBufferList : WebIDLBase
    {
        
        public SourceBufferList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
    }
}
