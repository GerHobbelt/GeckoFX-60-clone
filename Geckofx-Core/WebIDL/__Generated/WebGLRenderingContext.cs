namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLRenderingContext : WebIDLBase
    {
        
        public WebGLRenderingContext(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void BufferData(UInt32 target, Int64 size, UInt32 usage)
        {
            this.CallVoidMethod("bufferData", target, size, usage);
        }
        
        public void BufferData(UInt32 target, IntPtr data, UInt32 usage)
        {
            this.CallVoidMethod("bufferData", target, data, usage);
        }
        
        public void BufferSubData(UInt32 target, Int64 offset, IntPtr data)
        {
            this.CallVoidMethod("bufferSubData", target, offset, data);
        }
        
        public void CompressedTexImage2D(UInt32 target, Int32 level, UInt32 internalformat, Int32 width, Int32 height, Int32 border, IntPtr data)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, data);
        }
        
        public void CompressedTexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, UInt32 format, IntPtr data)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, data);
        }
        
        public void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("readPixels", x, y, width, height, format, type, pixels);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, Int32 internalformat, UInt32 format, UInt32 type, nsISupports pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, pixels);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, Int32 internalformat, UInt32 format, UInt32 type, nsIDOMHTMLImageElement image)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, image);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, Int32 internalformat, UInt32 format, UInt32 type, nsIDOMHTMLCanvasElement canvas)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, canvas);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, UInt32 format, UInt32 type, nsISupports pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, pixels);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, UInt32 format, UInt32 type, nsIDOMHTMLImageElement image)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, image);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, UInt32 format, UInt32 type, nsIDOMHTMLCanvasElement canvas)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, canvas);
        }
        
        public void Uniform1fv(nsISupports location, Float32List data)
        {
            this.CallVoidMethod("uniform1fv", location, data);
        }
        
        public void Uniform2fv(nsISupports location, Float32List data)
        {
            this.CallVoidMethod("uniform2fv", location, data);
        }
        
        public void Uniform3fv(nsISupports location, Float32List data)
        {
            this.CallVoidMethod("uniform3fv", location, data);
        }
        
        public void Uniform4fv(nsISupports location, Float32List data)
        {
            this.CallVoidMethod("uniform4fv", location, data);
        }
        
        public void Uniform1iv(nsISupports location, Int32List data)
        {
            this.CallVoidMethod("uniform1iv", location, data);
        }
        
        public void Uniform2iv(nsISupports location, Int32List data)
        {
            this.CallVoidMethod("uniform2iv", location, data);
        }
        
        public void Uniform3iv(nsISupports location, Int32List data)
        {
            this.CallVoidMethod("uniform3iv", location, data);
        }
        
        public void Uniform4iv(nsISupports location, Int32List data)
        {
            this.CallVoidMethod("uniform4iv", location, data);
        }
        
        public void UniformMatrix2fv(nsISupports location, Boolean transpose, Float32List data)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, data);
        }
        
        public void UniformMatrix3fv(nsISupports location, Boolean transpose, Float32List data)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, data);
        }
        
        public void UniformMatrix4fv(nsISupports location, Boolean transpose, Float32List data)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, data);
        }
        
        public void Commit()
        {
            this.CallVoidMethod("commit");
        }
    }
}
