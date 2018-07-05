namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceEntry : WebIDLBase
    {
        
        public PerformanceEntry(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string EntryType
        {
            get
            {
                return this.GetProperty<string>("entryType");
            }
        }
        
        public double StartTime
        {
            get
            {
                return this.GetProperty<double>("startTime");
            }
        }
        
        public double Duration
        {
            get
            {
                return this.GetProperty<double>("duration");
            }
        }
    }
}
