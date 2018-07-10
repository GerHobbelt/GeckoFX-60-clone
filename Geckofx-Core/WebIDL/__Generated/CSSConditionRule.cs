namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSConditionRule : WebIDLBase
    {
        
        public CSSConditionRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ConditionText
        {
            get
            {
                return this.GetProperty<string>("conditionText");
            }
            set
            {
                this.SetProperty("conditionText", value);
            }
        }
    }
}
