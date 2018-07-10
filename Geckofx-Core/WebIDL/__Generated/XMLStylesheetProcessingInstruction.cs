namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLStylesheetProcessingInstruction : WebIDLBase
    {
        
        public XMLStylesheetProcessingInstruction(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Sheet
        {
            get
            {
                return this.GetProperty<nsISupports>("sheet");
            }
        }
    }
}
