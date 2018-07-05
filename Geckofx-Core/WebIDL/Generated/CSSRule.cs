namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSRule : WebIDLBase
    {
        
        public CSSRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort Type
        {
            get
            {
                return this.GetProperty<ushort>("type");
            }
        }
        
        public string CssText
        {
            get
            {
                return this.GetProperty<string>("cssText");
            }
            set
            {
                this.SetProperty("cssText", value);
            }
        }
        
        public nsISupports ParentRule
        {
            get
            {
                return this.GetProperty<nsISupports>("parentRule");
            }
        }
        
        public nsISupports ParentStyleSheet
        {
            get
            {
                return this.GetProperty<nsISupports>("parentStyleSheet");
            }
        }
    }
}
