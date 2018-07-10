namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSFontFaceRule : WebIDLBase
    {
        
        public CSSFontFaceRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMCSSStyleDeclaration Style
        {
            get
            {
                return this.GetProperty<nsIDOMCSSStyleDeclaration>("style");
            }
        }
    }
}
