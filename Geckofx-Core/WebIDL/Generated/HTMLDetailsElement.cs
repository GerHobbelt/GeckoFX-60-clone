namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDetailsElement : WebIDLBase
    {
        
        public HTMLDetailsElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Open
        {
            get
            {
                return this.GetProperty<bool>("open");
            }
            set
            {
                this.SetProperty("open", value);
            }
        }
    }
}
