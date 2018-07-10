namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCStatsReport : WebIDLBase
    {
        
        public RTCStatsReport(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string MozPcid
        {
            get
            {
                return this.GetProperty<string>("mozPcid");
            }
        }
    }
}
