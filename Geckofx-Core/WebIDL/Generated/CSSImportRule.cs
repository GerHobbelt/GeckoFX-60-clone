namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSImportRule : WebIDLBase
    {
        
        public CSSImportRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Href
        {
            get
            {
                return this.GetProperty<string>("href");
            }
        }
        
        public nsISupports Media
        {
            get
            {
                return this.GetProperty<nsISupports>("media");
            }
        }
        
        public nsISupports StyleSheet
        {
            get
            {
                return this.GetProperty<nsISupports>("styleSheet");
            }
        }
    }
}
