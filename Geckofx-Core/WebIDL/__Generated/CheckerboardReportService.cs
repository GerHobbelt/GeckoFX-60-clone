namespace Gecko.WebIDL
{
    using System;
    
    
    public class CheckerboardReportService : WebIDLBase
    {
        
        public CheckerboardReportService(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object[] GetReports()
        {
            return this.CallMethod<object[]>("getReports");
        }
        
        public bool IsRecordingEnabled()
        {
            return this.CallMethod<bool>("isRecordingEnabled");
        }
        
        public void SetRecordingEnabled(bool aEnabled)
        {
            this.CallVoidMethod("setRecordingEnabled", aEnabled);
        }
        
        public void FlushActiveReports()
        {
            this.CallVoidMethod("flushActiveReports");
        }
    }
}
