namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGL2RenderingContextBase : WebIDLBase
    {
        
        public WebGL2RenderingContextBase(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void BufferData(uint target, long size, uint usage)
        {
            this.CallVoidMethod("bufferData", target, size, usage);
        }
        
        public void BufferData(uint target, IntPtr srcData, uint usage)
        {
            this.CallVoidMethod("bufferData", target, srcData, usage);
        }
        
        public void BufferSubData(uint target, long offset, IntPtr srcData)
        {
            this.CallVoidMethod("bufferSubData", target, offset, srcData);
        }
        
        public void BufferData(uint target, IntPtr srcData, uint usage, uint srcOffset)
        {
            this.CallVoidMethod("bufferData", target, srcData, usage, srcOffset);
        }
        
        public void BufferData(uint target, IntPtr srcData, uint usage, uint srcOffset, uint length)
        {
            this.CallVoidMethod("bufferData", target, srcData, usage, srcOffset, length);
        }
        
        public void BufferSubData(uint target, long dstByteOffset, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("bufferSubData", target, dstByteOffset, srcData, srcOffset);
        }
        
        public void BufferSubData(uint target, long dstByteOffset, IntPtr srcData, uint srcOffset, uint length)
        {
            this.CallVoidMethod("bufferSubData", target, dstByteOffset, srcData, srcOffset, length);
        }
        
        public void CopyBufferSubData(uint readTarget, uint writeTarget, long readOffset, long writeOffset, long size)
        {
            this.CallVoidMethod("copyBufferSubData", readTarget, writeTarget, readOffset, writeOffset, size);
        }
        
        public void GetBufferSubData(uint target, long srcByteOffset, IntPtr dstData)
        {
            this.CallVoidMethod("getBufferSubData", target, srcByteOffset, dstData);
        }
        
        public void GetBufferSubData(uint target, long srcByteOffset, IntPtr dstData, uint dstOffset)
        {
            this.CallVoidMethod("getBufferSubData", target, srcByteOffset, dstData, dstOffset);
        }
        
        public void GetBufferSubData(uint target, long srcByteOffset, IntPtr dstData, uint dstOffset, uint length)
        {
            this.CallVoidMethod("getBufferSubData", target, srcByteOffset, dstData, dstOffset, length);
        }
        
        public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
        {
            this.CallVoidMethod("blitFramebuffer", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        public void FramebufferTextureLayer(uint target, uint attachment, nsISupports texture, int level, int layer)
        {
            this.CallVoidMethod("framebufferTextureLayer", target, attachment, texture, level, layer);
        }
        
        public void InvalidateFramebuffer(uint target, uint[] attachments)
        {
            this.CallVoidMethod("invalidateFramebuffer", target, attachments);
        }
        
        public void InvalidateSubFramebuffer(uint target, uint[] attachments, int x, int y, int width, int height)
        {
            this.CallVoidMethod("invalidateSubFramebuffer", target, attachments, x, y, width, height);
        }
        
        public void ReadBuffer(uint src)
        {
            this.CallVoidMethod("readBuffer", src);
        }
        
        public object GetInternalformatParameter(uint target, uint internalformat, uint pname)
        {
            return this.CallMethod<object>("getInternalformatParameter", target, internalformat, pname);
        }
        
        public void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
        {
            this.CallVoidMethod("renderbufferStorageMultisample", target, samples, internalformat, width, height);
        }
        
        public void TexStorage2D(uint target, int levels, uint internalformat, int width, int height)
        {
            this.CallVoidMethod("texStorage2D", target, levels, internalformat, width, height);
        }
        
        public void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
        {
            this.CallVoidMethod("texStorage3D", target, levels, internalformat, width, height, depth);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, uint format, uint type, nsISupports source)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, source);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, nsISupports source)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, source);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, long pboOffset)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, pboOffset);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nsISupports source)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, source);
        }
        
        public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, srcData, srcOffset);
        }
        
        public void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, long pboOffset)
        {
            this.CallVoidMethod("texImage3D", target, level, internalformat, width, height, depth, border, format, type, pboOffset);
        }
        
        public void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nsISupports source)
        {
            this.CallVoidMethod("texImage3D", target, level, internalformat, width, height, depth, border, format, type, source);
        }
        
        public void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr srcData)
        {
            this.CallVoidMethod("texImage3D", target, level, internalformat, width, height, depth, border, format, type, srcData);
        }
        
        public void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("texImage3D", target, level, internalformat, width, height, depth, border, format, type, srcData, srcOffset);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, long pboOffset)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, pboOffset);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nsISupports source)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, source);
        }
        
        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, srcData, srcOffset);
        }
        
        public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, long pboOffset)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pboOffset);
        }
        
        public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nsISupports source)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, source);
        }
        
        public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr srcData)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, srcData);
        }
        
        public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, srcData, srcOffset);
        }
        
        public void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            this.CallVoidMethod("copyTexSubImage3D", target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, long offset)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, imageSize, offset);
        }
        
        public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, IntPtr srcData)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, srcData);
        }
        
        public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, srcData, srcOffset);
        }
        
        public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, IntPtr srcData, uint srcOffset, uint srcLengthOverride)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, srcData, srcOffset, srcLengthOverride);
        }
        
        public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, long offset)
        {
            this.CallVoidMethod("compressedTexImage3D", target, level, internalformat, width, height, depth, border, imageSize, offset);
        }
        
        public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, IntPtr srcData)
        {
            this.CallVoidMethod("compressedTexImage3D", target, level, internalformat, width, height, depth, border, srcData);
        }
        
        public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("compressedTexImage3D", target, level, internalformat, width, height, depth, border, srcData, srcOffset);
        }
        
        public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, IntPtr srcData, uint srcOffset, uint srcLengthOverride)
        {
            this.CallVoidMethod("compressedTexImage3D", target, level, internalformat, width, height, depth, border, srcData, srcOffset, srcLengthOverride);
        }
        
        public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, long offset)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, imageSize, offset);
        }
        
        public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, IntPtr srcData)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, srcData);
        }
        
        public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, srcData, srcOffset);
        }
        
        public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, IntPtr srcData, uint srcOffset, uint srcLengthOverride)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, srcData, srcOffset, srcLengthOverride);
        }
        
        public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, long offset)
        {
            this.CallVoidMethod("compressedTexSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, offset);
        }
        
        public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, IntPtr srcData)
        {
            this.CallVoidMethod("compressedTexSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, srcData);
        }
        
        public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, IntPtr srcData, uint srcOffset)
        {
            this.CallVoidMethod("compressedTexSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, srcData, srcOffset);
        }
        
        public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, IntPtr srcData, uint srcOffset, uint srcLengthOverride)
        {
            this.CallVoidMethod("compressedTexSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, srcData, srcOffset, srcLengthOverride);
        }
        
        public int GetFragDataLocation(nsISupports program, string name)
        {
            return this.CallMethod<int>("getFragDataLocation", program, name);
        }
        
        public void Uniform1ui(nsISupports location, uint v0)
        {
            this.CallVoidMethod("uniform1ui", location, v0);
        }
        
        public void Uniform2ui(nsISupports location, uint v0, uint v1)
        {
            this.CallVoidMethod("uniform2ui", location, v0, v1);
        }
        
        public void Uniform3ui(nsISupports location, uint v0, uint v1, uint v2)
        {
            this.CallVoidMethod("uniform3ui", location, v0, v1, v2);
        }
        
        public void Uniform4ui(nsISupports location, uint v0, uint v1, uint v2, uint v3)
        {
            this.CallVoidMethod("uniform4ui", location, v0, v1, v2, v3);
        }
        
        public void Uniform1fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform1fv", location, data);
        }
        
        public void Uniform1fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform1fv", location, data, srcOffset);
        }
        
        public void Uniform1fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform1fv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform2fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform2fv", location, data);
        }
        
        public void Uniform2fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform2fv", location, data, srcOffset);
        }
        
        public void Uniform2fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform2fv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform3fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform3fv", location, data);
        }
        
        public void Uniform3fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform3fv", location, data, srcOffset);
        }
        
        public void Uniform3fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform3fv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform4fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniform4fv", location, data);
        }
        
        public void Uniform4fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform4fv", location, data, srcOffset);
        }
        
        public void Uniform4fv(nsISupports location, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform4fv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform1iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform1iv", location, data);
        }
        
        public void Uniform1iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform1iv", location, data, srcOffset);
        }
        
        public void Uniform1iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform1iv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform2iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform2iv", location, data);
        }
        
        public void Uniform2iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform2iv", location, data, srcOffset);
        }
        
        public void Uniform2iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform2iv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform3iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform3iv", location, data);
        }
        
        public void Uniform3iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform3iv", location, data, srcOffset);
        }
        
        public void Uniform3iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform3iv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform4iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data)
        {
            this.CallVoidMethod("uniform4iv", location, data);
        }
        
        public void Uniform4iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform4iv", location, data, srcOffset);
        }
        
        public void Uniform4iv(nsISupports location, WebIDLUnion<IntPtr,System.Int32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform4iv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform1uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data)
        {
            this.CallVoidMethod("uniform1uiv", location, data);
        }
        
        public void Uniform1uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform1uiv", location, data, srcOffset);
        }
        
        public void Uniform1uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform1uiv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform2uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data)
        {
            this.CallVoidMethod("uniform2uiv", location, data);
        }
        
        public void Uniform2uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform2uiv", location, data, srcOffset);
        }
        
        public void Uniform2uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform2uiv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform3uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data)
        {
            this.CallVoidMethod("uniform3uiv", location, data);
        }
        
        public void Uniform3uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform3uiv", location, data, srcOffset);
        }
        
        public void Uniform3uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform3uiv", location, data, srcOffset, srcLength);
        }
        
        public void Uniform4uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data)
        {
            this.CallVoidMethod("uniform4uiv", location, data);
        }
        
        public void Uniform4uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniform4uiv", location, data, srcOffset);
        }
        
        public void Uniform4uiv(nsISupports location, WebIDLUnion<IntPtr,System.UInt32[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniform4uiv", location, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, data);
        }
        
        public void UniformMatrix2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix3x2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix3x2fv", location, transpose, data);
        }
        
        public void UniformMatrix3x2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix3x2fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix3x2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix3x2fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix4x2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix4x2fv", location, transpose, data);
        }
        
        public void UniformMatrix4x2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix4x2fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix4x2fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix4x2fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix2x3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix2x3fv", location, transpose, data);
        }
        
        public void UniformMatrix2x3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix2x3fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix2x3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix2x3fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, data);
        }
        
        public void UniformMatrix3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix4x3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix4x3fv", location, transpose, data);
        }
        
        public void UniformMatrix4x3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix4x3fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix4x3fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix4x3fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix2x4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix2x4fv", location, transpose, data);
        }
        
        public void UniformMatrix2x4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix2x4fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix2x4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix2x4fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix3x4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix3x4fv", location, transpose, data);
        }
        
        public void UniformMatrix3x4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix3x4fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix3x4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix3x4fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void UniformMatrix4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, data);
        }
        
        public void UniformMatrix4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, data, srcOffset);
        }
        
        public void UniformMatrix4fv(nsISupports location, bool transpose, WebIDLUnion<IntPtr,System.Single[]> data, uint srcOffset, uint srcLength)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, data, srcOffset, srcLength);
        }
        
        public void VertexAttribI4i(uint index, int x, int y, int z, int w)
        {
            this.CallVoidMethod("vertexAttribI4i", index, x, y, z, w);
        }
        
        public void VertexAttribI4iv(uint index, WebIDLUnion<IntPtr,System.Int32[]> values)
        {
            this.CallVoidMethod("vertexAttribI4iv", index, values);
        }
        
        public void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
        {
            this.CallVoidMethod("vertexAttribI4ui", index, x, y, z, w);
        }
        
        public void VertexAttribI4uiv(uint index, WebIDLUnion<IntPtr,System.UInt32[]> values)
        {
            this.CallVoidMethod("vertexAttribI4uiv", index, values);
        }
        
        public void VertexAttribIPointer(uint index, int size, uint type, int stride, long offset)
        {
            this.CallVoidMethod("vertexAttribIPointer", index, size, type, stride, offset);
        }
        
        public void VertexAttribDivisor(uint index, uint divisor)
        {
            this.CallVoidMethod("vertexAttribDivisor", index, divisor);
        }
        
        public void DrawArraysInstanced(uint mode, int first, int count, int instanceCount)
        {
            this.CallVoidMethod("drawArraysInstanced", mode, first, count, instanceCount);
        }
        
        public void DrawElementsInstanced(uint mode, int count, uint type, long offset, int instanceCount)
        {
            this.CallVoidMethod("drawElementsInstanced", mode, count, type, offset, instanceCount);
        }
        
        public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, long offset)
        {
            this.CallVoidMethod("drawRangeElements", mode, start, end, count, type, offset);
        }
        
        public void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr dstData)
        {
            this.CallVoidMethod("readPixels", x, y, width, height, format, type, dstData);
        }
        
        public void ReadPixels(int x, int y, int width, int height, uint format, uint type, long offset)
        {
            this.CallVoidMethod("readPixels", x, y, width, height, format, type, offset);
        }
        
        public void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr dstData, uint dstOffset)
        {
            this.CallVoidMethod("readPixels", x, y, width, height, format, type, dstData, dstOffset);
        }
        
        public void DrawBuffers(uint[] buffers)
        {
            this.CallVoidMethod("drawBuffers", buffers);
        }
        
        public void ClearBufferfv(uint buffer, int drawbuffer, WebIDLUnion<IntPtr,System.Single[]> values)
        {
            this.CallVoidMethod("clearBufferfv", buffer, drawbuffer, values);
        }
        
        public void ClearBufferfv(uint buffer, int drawbuffer, WebIDLUnion<IntPtr,System.Single[]> values, uint srcOffset)
        {
            this.CallVoidMethod("clearBufferfv", buffer, drawbuffer, values, srcOffset);
        }
        
        public void ClearBufferiv(uint buffer, int drawbuffer, WebIDLUnion<IntPtr,System.Int32[]> values)
        {
            this.CallVoidMethod("clearBufferiv", buffer, drawbuffer, values);
        }
        
        public void ClearBufferiv(uint buffer, int drawbuffer, WebIDLUnion<IntPtr,System.Int32[]> values, uint srcOffset)
        {
            this.CallVoidMethod("clearBufferiv", buffer, drawbuffer, values, srcOffset);
        }
        
        public void ClearBufferuiv(uint buffer, int drawbuffer, WebIDLUnion<IntPtr,System.UInt32[]> values)
        {
            this.CallVoidMethod("clearBufferuiv", buffer, drawbuffer, values);
        }
        
        public void ClearBufferuiv(uint buffer, int drawbuffer, WebIDLUnion<IntPtr,System.UInt32[]> values, uint srcOffset)
        {
            this.CallVoidMethod("clearBufferuiv", buffer, drawbuffer, values, srcOffset);
        }
        
        public void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
        {
            this.CallVoidMethod("clearBufferfi", buffer, drawbuffer, depth, stencil);
        }
        
        public nsISupports CreateQuery()
        {
            return this.CallMethod<nsISupports>("createQuery");
        }
        
        public void DeleteQuery(nsISupports query)
        {
            this.CallVoidMethod("deleteQuery", query);
        }
        
        public bool IsQuery(nsISupports query)
        {
            return this.CallMethod<bool>("isQuery", query);
        }
        
        public void BeginQuery(uint target, nsISupports query)
        {
            this.CallVoidMethod("beginQuery", target, query);
        }
        
        public void EndQuery(uint target)
        {
            this.CallVoidMethod("endQuery", target);
        }
        
        public object GetQuery(uint target, uint pname)
        {
            return this.CallMethod<object>("getQuery", target, pname);
        }
        
        public object GetQueryParameter(nsISupports query, uint pname)
        {
            return this.CallMethod<object>("getQueryParameter", query, pname);
        }
        
        public nsISupports CreateSampler()
        {
            return this.CallMethod<nsISupports>("createSampler");
        }
        
        public void DeleteSampler(nsISupports sampler)
        {
            this.CallVoidMethod("deleteSampler", sampler);
        }
        
        public bool IsSampler(nsISupports sampler)
        {
            return this.CallMethod<bool>("isSampler", sampler);
        }
        
        public void BindSampler(uint unit, nsISupports sampler)
        {
            this.CallVoidMethod("bindSampler", unit, sampler);
        }
        
        public void SamplerParameteri(nsISupports sampler, uint pname, int param)
        {
            this.CallVoidMethod("samplerParameteri", sampler, pname, param);
        }
        
        public void SamplerParameterf(nsISupports sampler, uint pname, float param)
        {
            this.CallVoidMethod("samplerParameterf", sampler, pname, param);
        }
        
        public object GetSamplerParameter(nsISupports sampler, uint pname)
        {
            return this.CallMethod<object>("getSamplerParameter", sampler, pname);
        }
        
        public nsISupports FenceSync(uint condition, uint flags)
        {
            return this.CallMethod<nsISupports>("fenceSync", condition, flags);
        }
        
        public bool IsSync(nsISupports sync)
        {
            return this.CallMethod<bool>("isSync", sync);
        }
        
        public void DeleteSync(nsISupports sync)
        {
            this.CallVoidMethod("deleteSync", sync);
        }
        
        public uint ClientWaitSync(nsISupports sync, uint flags, ulong timeout)
        {
            return this.CallMethod<uint>("clientWaitSync", sync, flags, timeout);
        }
        
        public void WaitSync(nsISupports sync, uint flags, long timeout)
        {
            this.CallVoidMethod("waitSync", sync, flags, timeout);
        }
        
        public object GetSyncParameter(nsISupports sync, uint pname)
        {
            return this.CallMethod<object>("getSyncParameter", sync, pname);
        }
        
        public nsISupports CreateTransformFeedback()
        {
            return this.CallMethod<nsISupports>("createTransformFeedback");
        }
        
        public void DeleteTransformFeedback(nsISupports tf)
        {
            this.CallVoidMethod("deleteTransformFeedback", tf);
        }
        
        public bool IsTransformFeedback(nsISupports tf)
        {
            return this.CallMethod<bool>("isTransformFeedback", tf);
        }
        
        public void BindTransformFeedback(uint target, nsISupports tf)
        {
            this.CallVoidMethod("bindTransformFeedback", target, tf);
        }
        
        public void BeginTransformFeedback(uint primitiveMode)
        {
            this.CallVoidMethod("beginTransformFeedback", primitiveMode);
        }
        
        public void EndTransformFeedback()
        {
            this.CallVoidMethod("endTransformFeedback");
        }
        
        public void TransformFeedbackVaryings(nsISupports program, string[] varyings, uint bufferMode)
        {
            this.CallVoidMethod("transformFeedbackVaryings", program, varyings, bufferMode);
        }
        
        public nsISupports GetTransformFeedbackVarying(nsISupports program, uint index)
        {
            return this.CallMethod<nsISupports>("getTransformFeedbackVarying", program, index);
        }
        
        public void PauseTransformFeedback()
        {
            this.CallVoidMethod("pauseTransformFeedback");
        }
        
        public void ResumeTransformFeedback()
        {
            this.CallVoidMethod("resumeTransformFeedback");
        }
        
        public void BindBufferBase(uint target, uint index, nsISupports buffer)
        {
            this.CallVoidMethod("bindBufferBase", target, index, buffer);
        }
        
        public void BindBufferRange(uint target, uint index, nsISupports buffer, long offset, long size)
        {
            this.CallVoidMethod("bindBufferRange", target, index, buffer, offset, size);
        }
        
        public object GetIndexedParameter(uint target, uint index)
        {
            return this.CallMethod<object>("getIndexedParameter", target, index);
        }
        
        public uint[] GetUniformIndices(nsISupports program, string[] uniformNames)
        {
            return this.CallMethod<uint[]>("getUniformIndices", program, uniformNames);
        }
        
        public object GetActiveUniforms(nsISupports program, uint[] uniformIndices, uint pname)
        {
            return this.CallMethod<object>("getActiveUniforms", program, uniformIndices, pname);
        }
        
        public uint GetUniformBlockIndex(nsISupports program, string uniformBlockName)
        {
            return this.CallMethod<uint>("getUniformBlockIndex", program, uniformBlockName);
        }
        
        public object GetActiveUniformBlockParameter(nsISupports program, uint uniformBlockIndex, uint pname)
        {
            return this.CallMethod<object>("getActiveUniformBlockParameter", program, uniformBlockIndex, pname);
        }
        
        public string GetActiveUniformBlockName(nsISupports program, uint uniformBlockIndex)
        {
            return this.CallMethod<string>("getActiveUniformBlockName", program, uniformBlockIndex);
        }
        
        public void UniformBlockBinding(nsISupports program, uint uniformBlockIndex, uint uniformBlockBinding)
        {
            this.CallVoidMethod("uniformBlockBinding", program, uniformBlockIndex, uniformBlockBinding);
        }
        
        public nsISupports CreateVertexArray()
        {
            return this.CallMethod<nsISupports>("createVertexArray");
        }
        
        public void DeleteVertexArray(nsISupports vertexArray)
        {
            this.CallVoidMethod("deleteVertexArray", vertexArray);
        }
        
        public bool IsVertexArray(nsISupports vertexArray)
        {
            return this.CallMethod<bool>("isVertexArray", vertexArray);
        }
        
        public void BindVertexArray(nsISupports array)
        {
            this.CallVoidMethod("bindVertexArray", array);
        }
    }
}
