namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLRenderingContext : WebIDLBase
    {
        
        public WebGLRenderingContext(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void BufferData(uint target, long size, uint usage)
        {
            this.CallVoidMethod("bufferData", target, size, usage);
        }
        
        public void BufferData(uint target, IntPtr data, uint usage)
        {
            this.CallVoidMethod("bufferData", target, data, usage);
        }
        
        public void BufferSubData(uint target, long offset, IntPtr data)
        {
            this.CallVoidMethod("bufferSubData", target, offset, data);
        }
        
        public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, IntPtr data)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, data);
        }
        
        public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, IntPtr data)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, data);
        }
        
        public void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels)
        {
            this.CallVoidMethod("readPixels", x, y, width, height, format, type, pixels);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, uint format, uint type, nsISupports pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, pixels);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, nsISupports pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, pixels);
        }
        
        public void Uniform1fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform1fv", location, data);
        }
        
        public void Uniform2fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform2fv", location, data);
        }
        
        public void Uniform3fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform3fv", location, data);
        }
        
        public void Uniform4fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform4fv", location, data);
        }
        
        public void Uniform1iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform1iv", location, data);
        }
        
        public void Uniform2iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform2iv", location, data);
        }
        
        public void Uniform3iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform3iv", location, data);
        }
        
        public void Uniform4iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform4iv", location, data);
        }
        
        public void UniformMatrix2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, data);
        }
        
        public void UniformMatrix3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, data);
        }
        
        public void UniformMatrix4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, data);
        }
        
        public void Commit()
        {
            this.CallVoidMethod("commit");
        }
    }
}
