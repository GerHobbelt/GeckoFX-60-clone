namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSPseudoElement : WebIDLBase
    {
        
        public CSSPseudoElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsIDOMElement ParentElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("parentElement");
            }
        }
    }
}
