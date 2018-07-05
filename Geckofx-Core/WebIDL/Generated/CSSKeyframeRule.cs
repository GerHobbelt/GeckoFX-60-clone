namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSKeyframeRule : WebIDLBase
    {
        
        public CSSKeyframeRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string KeyText
        {
            get
            {
                return this.GetProperty<string>("keyText");
            }
            set
            {
                this.SetProperty("keyText", value);
            }
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
