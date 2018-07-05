namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSPageRule : WebIDLBase
    {
        
        public CSSPageRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Style
        {
            get
            {
                return this.GetProperty<nsISupports>("style");
            }
        }
    }
}
