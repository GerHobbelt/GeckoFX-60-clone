namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceEntryEvent : WebIDLBase
    {
        
        public PerformanceEntryEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public double Epoch
        {
            get
            {
                return this.GetProperty<double>("epoch");
            }
        }
        
        public string Origin
        {
            get
            {
                return this.GetProperty<string>("origin");
            }
        }
    }
}
