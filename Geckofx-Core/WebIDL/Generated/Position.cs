namespace Gecko.WebIDL
{
    using System;
    
    
    public class Position : WebIDLBase
    {
        
        public Position(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Coords
        {
            get
            {
                return this.GetProperty<nsISupports>("coords");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
    }
}
