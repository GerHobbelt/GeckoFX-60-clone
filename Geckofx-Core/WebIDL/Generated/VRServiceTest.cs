namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRServiceTest : WebIDLBase
    {
        
        public VRServiceTest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > AttachVRDisplay(string id)
        {
            return this.CallMethod<Promise < nsISupports >>("attachVRDisplay", id);
        }
        
        public Promise < nsISupports > AttachVRController(string id)
        {
            return this.CallMethod<Promise < nsISupports >>("attachVRController", id);
        }
    }
}
