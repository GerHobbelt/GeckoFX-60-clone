namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasFilters : WebIDLBase
    {
        
        public CanvasFilters(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Filter
        {
            get
            {
                return this.GetProperty<string>("filter");
            }
            set
            {
                this.SetProperty("filter", value);
            }
        }
    }
}
