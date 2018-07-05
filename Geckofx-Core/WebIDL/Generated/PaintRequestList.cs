namespace Gecko.WebIDL
{
    using System;
    
    
    public class PaintRequestList : WebIDLBase
    {
        
        public PaintRequestList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
