namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRSubmitFrameResult : WebIDLBase
    {
        
        public VRSubmitFrameResult(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint FrameNum
        {
            get
            {
                return this.GetProperty<uint>("frameNum");
            }
        }
        
        public string Base64Image
        {
            get
            {
                return this.GetProperty<string>("base64Image");
            }
        }
    }
}
