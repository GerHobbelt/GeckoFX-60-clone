namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceNavigationTiming : WebIDLBase
    {
        
        public PerformanceNavigationTiming(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double UnloadEventStart
        {
            get
            {
                return this.GetProperty<double>("unloadEventStart");
            }
        }
        
        public double UnloadEventEnd
        {
            get
            {
                return this.GetProperty<double>("unloadEventEnd");
            }
        }
        
        public double DomInteractive
        {
            get
            {
                return this.GetProperty<double>("domInteractive");
            }
        }
        
        public double DomContentLoadedEventStart
        {
            get
            {
                return this.GetProperty<double>("domContentLoadedEventStart");
            }
        }
        
        public double DomContentLoadedEventEnd
        {
            get
            {
                return this.GetProperty<double>("domContentLoadedEventEnd");
            }
        }
        
        public double DomComplete
        {
            get
            {
                return this.GetProperty<double>("domComplete");
            }
        }
        
        public double LoadEventStart
        {
            get
            {
                return this.GetProperty<double>("loadEventStart");
            }
        }
        
        public double LoadEventEnd
        {
            get
            {
                return this.GetProperty<double>("loadEventEnd");
            }
        }
        
        public NavigationType Type
        {
            get
            {
                return this.GetProperty<NavigationType>("type");
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
