namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDataElement : WebIDLBase
    {
        
        public HTMLDataElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
    }
}
