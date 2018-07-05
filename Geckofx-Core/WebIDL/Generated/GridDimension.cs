namespace Gecko.WebIDL
{
    using System;
    
    
    public class GridDimension : WebIDLBase
    {
        
        public GridDimension(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Lines
        {
            get
            {
                return this.GetProperty<nsISupports>("lines");
            }
        }
        
        public nsISupports Tracks
        {
            get
            {
                return this.GetProperty<nsISupports>("tracks");
            }
        }
    }
}
