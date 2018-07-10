namespace Gecko.WebIDL
{
    using System;
    
    
    public class GridLines : WebIDLBase
    {
        
        public GridLines(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
