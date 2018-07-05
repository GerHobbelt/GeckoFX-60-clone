namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceResourceTiming : WebIDLBase
    {
        
        public PerformanceResourceTiming(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string InitiatorType
        {
            get
            {
                return this.GetProperty<string>("initiatorType");
            }
        }
        
        public string NextHopProtocol
        {
            get
            {
                return this.GetProperty<string>("nextHopProtocol");
            }
        }
        
        public double WorkerStart
        {
            get
            {
                return this.GetProperty<double>("workerStart");
            }
        }
        
        public double RedirectStart
        {
            get
            {
                return this.GetProperty<double>("redirectStart");
            }
        }
        
        public double RedirectEnd
        {
            get
            {
                return this.GetProperty<double>("redirectEnd");
            }
        }
        
        public double FetchStart
        {
            get
            {
                return this.GetProperty<double>("fetchStart");
            }
        }
        
        public double DomainLookupStart
        {
            get
            {
                return this.GetProperty<double>("domainLookupStart");
            }
        }
        
        public double DomainLookupEnd
        {
            get
            {
                return this.GetProperty<double>("domainLookupEnd");
            }
        }
        
        public double ConnectStart
        {
            get
            {
                return this.GetProperty<double>("connectStart");
            }
        }
        
        public double ConnectEnd
        {
            get
            {
                return this.GetProperty<double>("connectEnd");
            }
        }
        
        public double SecureConnectionStart
        {
            get
            {
                return this.GetProperty<double>("secureConnectionStart");
            }
        }
        
        public double RequestStart
        {
            get
            {
                return this.GetProperty<double>("requestStart");
            }
        }
        
        public double ResponseStart
        {
            get
            {
                return this.GetProperty<double>("responseStart");
            }
        }
        
        public double ResponseEnd
        {
            get
            {
                return this.GetProperty<double>("responseEnd");
            }
        }
        
        public ulong TransferSize
        {
            get
            {
                return this.GetProperty<ulong>("transferSize");
            }
        }
        
        public ulong EncodedBodySize
        {
            get
            {
                return this.GetProperty<ulong>("encodedBodySize");
            }
        }
        
        public ulong DecodedBodySize
        {
            get
            {
                return this.GetProperty<ulong>("decodedBodySize");
            }
        }
    }
}
