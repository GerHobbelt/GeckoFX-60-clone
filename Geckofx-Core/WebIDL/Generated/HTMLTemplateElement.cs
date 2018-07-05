namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTemplateElement : WebIDLBase
    {
        
        public HTMLTemplateElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Content
        {
            get
            {
                return this.GetProperty<nsISupports>("content");
            }
        }
    }
}
