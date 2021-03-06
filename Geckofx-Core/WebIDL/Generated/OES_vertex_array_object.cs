namespace Gecko.WebIDL
{
    using System;
    
    
    public class OES_vertex_array_object : WebIDLBase
    {
        
        public OES_vertex_array_object(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateVertexArrayOES()
        {
            return this.CallMethod<nsISupports>("createVertexArrayOES");
        }
        
        public void DeleteVertexArrayOES(nsISupports arrayObject)
        {
            this.CallVoidMethod("deleteVertexArrayOES", arrayObject);
        }
        
        public bool IsVertexArrayOES(nsISupports arrayObject)
        {
            return this.CallMethod<bool>("isVertexArrayOES", arrayObject);
        }
        
        public void BindVertexArrayOES(nsISupports arrayObject)
        {
            this.CallVoidMethod("bindVertexArrayOES", arrayObject);
        }
    }
}
