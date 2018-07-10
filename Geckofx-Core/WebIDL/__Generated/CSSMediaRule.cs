namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSMediaRule : WebIDLBase
    {
        
        public CSSMediaRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Media
        {
            get
            {
                return this.GetProperty<nsISupports>("media");
            }
        }
    }
}
