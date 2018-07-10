namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceNavigationTiming : WebIDLBase
    {
        
        public PerformanceNavigationTiming(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Double UnloadEventStart
        {
            get
            {
                return this.GetProperty<Double>("unloadEventStart");
            }
        }
        
        public Double UnloadEventEnd
        {
            get
            {
                return this.GetProperty<Double>("unloadEventEnd");
            }
        }
        
        public Double DomInteractive
        {
            get
            {
                return this.GetProperty<Double>("domInteractive");
            }
        }
        
        public Double DomContentLoadedEventStart
        {
            get
            {
                return this.GetProperty<Double>("domContentLoadedEventStart");
            }
        }
        
        public Double DomContentLoadedEventEnd
        {
            get
            {
                return this.GetProperty<Double>("domContentLoadedEventEnd");
            }
        }
        
        public Double DomComplete
        {
            get
            {
                return this.GetProperty<Double>("domComplete");
            }
        }
        
        public Double LoadEventStart
        {
            get
            {
                return this.GetProperty<Double>("loadEventStart");
            }
        }
        
        public Double LoadEventEnd
        {
            get
            {
                return this.GetProperty<Double>("loadEventEnd");
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
