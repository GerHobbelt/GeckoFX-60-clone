namespace Gecko.WebIDL
{
    using System;
    
    
    public class TouchList : WebIDLBase
    {
        
        public TouchList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
