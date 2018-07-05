namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorOnLine : WebIDLBase
    {
        
        public NavigatorOnLine(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool OnLine
        {
            get
            {
                return this.GetProperty<bool>("onLine");
            }
        }
    }
}
