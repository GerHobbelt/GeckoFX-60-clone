namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSStyleRule : WebIDLBase
    {
        
        public CSSStyleRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string SelectorText
        {
            get
            {
                return this.GetProperty<string>("selectorText");
            }
            set
            {
                this.SetProperty("selectorText", value);
            }
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
