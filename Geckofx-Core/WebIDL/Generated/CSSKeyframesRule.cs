namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSKeyframesRule : WebIDLBase
    {
        
        public CSSKeyframesRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsISupports CssRules
        {
            get
            {
                return this.GetProperty<nsISupports>("cssRules");
            }
        }
        
        public void AppendRule(string rule)
        {
            this.CallVoidMethod("appendRule", rule);
        }
        
        public void DeleteRule(string select)
        {
            this.CallVoidMethod("deleteRule", select);
        }
        
        public nsISupports FindRule(string select)
        {
            return this.CallMethod<nsISupports>("findRule", select);
        }
    }
}
