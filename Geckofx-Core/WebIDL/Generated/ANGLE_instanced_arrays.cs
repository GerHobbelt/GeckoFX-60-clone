namespace Gecko.WebIDL
{
    using System;
    
    
    public class ANGLE_instanced_arrays : WebIDLBase
    {
        
        public ANGLE_instanced_arrays(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void DrawArraysInstancedANGLE(uint mode, int first, int count, int primcount)
        {
            this.CallVoidMethod("drawArraysInstancedANGLE", mode, first, count, primcount);
        }
        
        public void DrawElementsInstancedANGLE(uint mode, int count, uint type, long offset, int primcount)
        {
            this.CallVoidMethod("drawElementsInstancedANGLE", mode, count, type, offset, primcount);
        }
        
        public void VertexAttribDivisorANGLE(uint index, uint divisor)
        {
            this.CallVoidMethod("vertexAttribDivisorANGLE", index, divisor);
        }
    }
}
