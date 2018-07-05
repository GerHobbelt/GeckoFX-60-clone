namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceNavigation : WebIDLBase
    {
        
        public PerformanceNavigation(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort Type
        {
            get
            {
                return this.GetProperty<ushort>("type");
            }
        }
        
        public ushort RedirectCount
        {
            get
            {
                return this.GetProperty<ushort>("redirectCount");
            }
        }
    }
}
