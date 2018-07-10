namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSStyleSheet : WebIDLBase
    {
        
        public CSSStyleSheet(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports OwnerRule
        {
            get
            {
                return this.GetProperty<nsISupports>("ownerRule");
            }
        }
        
        public nsISupports CssRules
        {
            get
            {
                return this.GetProperty<nsISupports>("cssRules");
            }
        }
        
        public CSSStyleSheetParsingMode ParsingMode
        {
            get
            {
                return this.GetProperty<CSSStyleSheetParsingMode>("parsingMode");
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
