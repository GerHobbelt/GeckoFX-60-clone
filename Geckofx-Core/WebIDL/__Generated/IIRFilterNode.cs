namespace Gecko.WebIDL
{
    using System;
    
    
    public class IIRFilterNode : WebIDLBase
    {
        
        public IIRFilterNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void GetFrequencyResponse(IntPtr frequencyHz, IntPtr magResponse, IntPtr phaseResponse)
        {
            this.CallVoidMethod("getFrequencyResponse", frequencyHz, magResponse, phaseResponse);
        }
    }
}
