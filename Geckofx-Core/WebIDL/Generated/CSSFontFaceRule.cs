namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSFontFaceRule : WebIDLBase
    {
        
        public CSSFontFaceRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
