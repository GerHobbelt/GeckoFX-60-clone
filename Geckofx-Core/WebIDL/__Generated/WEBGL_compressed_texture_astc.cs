namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_compressed_texture_astc : WebIDLBase
    {
        
        public WEBGL_compressed_texture_astc(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string[] GetSupportedProfiles()
        {
            return this.CallMethod<string[]>("getSupportedProfiles");
        }
    }
}
