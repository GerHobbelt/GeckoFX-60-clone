namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSGroupingRule : WebIDLBase
    {
        
        public CSSGroupingRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CssRules
        {
            get
            {
                return this.GetProperty<nsISupports>("cssRules");
            }
        }
        
        public uint InsertRule(string rule)
        {
            return this.CallMethod<uint>("insertRule", rule);
        }
        
        public uint InsertRule(string rule, uint index)
        {
            return this.CallMethod<uint>("insertRule", rule, index);
        }
        
        public void DeleteRule(uint index)
        {
            this.CallVoidMethod("deleteRule", index);
        }
    }
}
