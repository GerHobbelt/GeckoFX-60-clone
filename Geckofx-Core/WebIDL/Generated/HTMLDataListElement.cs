namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDataListElement : WebIDLBase
    {
        
        public HTMLDataListElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Options
        {
            get
            {
                return this.GetProperty<nsISupports>("options");
            }
        }
    }
}
