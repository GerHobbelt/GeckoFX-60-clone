namespace Gecko.WebIDL
{
    using System;
    
    
    public class WEBGL_draw_buffers : WebIDLBase
    {
        
        public WEBGL_draw_buffers(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void DrawBuffersWEBGL(uint[] buffers)
        {
            this.CallVoidMethod("drawBuffersWEBGL", buffers);
        }
    }
}
