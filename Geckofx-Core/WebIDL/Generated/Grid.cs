namespace Gecko.WebIDL
{
    using System;
    
    
    public class Grid : WebIDLBase
    {
        
        public Grid(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Rows
        {
            get
            {
                return this.GetProperty<nsISupports>("rows");
            }
        }
        
        public nsISupports Cols
        {
            get
            {
                return this.GetProperty<nsISupports>("cols");
            }
        }
        
        public nsISupports[] Areas
        {
            get
            {
                return this.GetProperty<nsISupports[]>("areas");
            }
        }
    }
}
