namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLRenderingContextBase : WebIDLBase
    {
        
        public WebGLRenderingContextBase(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<nsISupports,nsISupports> Canvas
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports>>("canvas");
            }
        }
        
        public int DrawingBufferWidth
        {
            get
            {
                return this.GetProperty<int>("drawingBufferWidth");
            }
        }
        
        public int DrawingBufferHeight
        {
            get
            {
                return this.GetProperty<int>("drawingBufferHeight");
            }
        }
        
        public object GetContextAttributes()
        {
            return this.CallMethod<object>("getContextAttributes");
        }
        
        public bool IsContextLost()
        {
            return this.CallMethod<bool>("isContextLost");
        }
        
        public string[] GetSupportedExtensions()
        {
            return this.CallMethod<string[]>("getSupportedExtensions");
        }
        
        public object GetExtension(string name)
        {
            return this.CallMethod<object>("getExtension", name);
        }
        
        public void ActiveTexture(uint texture)
        {
            this.CallVoidMethod("activeTexture", texture);
        }
        
        public void AttachShader(nsISupports program, nsISupports shader)
        {
            this.CallVoidMethod("attachShader", program, shader);
        }
        
        public void BindAttribLocation(nsISupports program, uint index, string name)
        {
            this.CallVoidMethod("bindAttribLocation", program, index, name);
        }
        
        public void BindBuffer(uint target, nsISupports buffer)
        {
            this.CallVoidMethod("bindBuffer", target, buffer);
        }
        
        public void BindFramebuffer(uint target, nsISupports framebuffer)
        {
            this.CallVoidMethod("bindFramebuffer", target, framebuffer);
        }
        
        public void BindRenderbuffer(uint target, nsISupports renderbuffer)
        {
            this.CallVoidMethod("bindRenderbuffer", target, renderbuffer);
        }
        
        public void BindTexture(uint target, nsISupports texture)
        {
            this.CallVoidMethod("bindTexture", target, texture);
        }
        
        public void BlendColor(float red, float green, float blue, float alpha)
        {
            this.CallVoidMethod("blendColor", red, green, blue, alpha);
        }
        
        public void BlendEquation(uint mode)
        {
            this.CallVoidMethod("blendEquation", mode);
        }
        
        public void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
        {
            this.CallVoidMethod("blendEquationSeparate", modeRGB, modeAlpha);
        }
        
        public void BlendFunc(uint sfactor, uint dfactor)
        {
            this.CallVoidMethod("blendFunc", sfactor, dfactor);
        }
        
        public void BlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
        {
            this.CallVoidMethod("blendFuncSeparate", srcRGB, dstRGB, srcAlpha, dstAlpha);
        }
        
        public uint CheckFramebufferStatus(uint target)
        {
            return this.CallMethod<uint>("checkFramebufferStatus", target);
        }
        
        public void Clear(uint mask)
        {
            this.CallVoidMethod("clear", mask);
        }
        
        public void ClearColor(float red, float green, float blue, float alpha)
        {
            this.CallVoidMethod("clearColor", red, green, blue, alpha);
        }
        
        public void ClearDepth(float depth)
        {
            this.CallVoidMethod("clearDepth", depth);
        }
        
        public void ClearStencil(int s)
        {
            this.CallVoidMethod("clearStencil", s);
        }
        
        public void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            this.CallVoidMethod("colorMask", red, green, blue, alpha);
        }
        
        public void CompileShader(nsISupports shader)
        {
            this.CallVoidMethod("compileShader", shader);
        }
        
        public void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
        {
            this.CallVoidMethod("copyTexImage2D", target, level, internalformat, x, y, width, height, border);
        }
        
        public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            this.CallVoidMethod("copyTexSubImage2D", target, level, xoffset, yoffset, x, y, width, height);
        }
        
        public nsISupports CreateBuffer()
        {
            return this.CallMethod<nsISupports>("createBuffer");
        }
        
        public nsISupports CreateFramebuffer()
        {
            return this.CallMethod<nsISupports>("createFramebuffer");
        }
        
        public nsISupports CreateProgram()
        {
            return this.CallMethod<nsISupports>("createProgram");
        }
        
        public nsISupports CreateRenderbuffer()
        {
            return this.CallMethod<nsISupports>("createRenderbuffer");
        }
        
        public nsISupports CreateShader(uint type)
        {
            return this.CallMethod<nsISupports>("createShader", type);
        }
        
        public nsISupports CreateTexture()
        {
            return this.CallMethod<nsISupports>("createTexture");
        }
        
        public void CullFace(uint mode)
        {
            this.CallVoidMethod("cullFace", mode);
        }
        
        public void DeleteBuffer(nsISupports buffer)
        {
            this.CallVoidMethod("deleteBuffer", buffer);
        }
        
        public void DeleteFramebuffer(nsISupports framebuffer)
        {
            this.CallVoidMethod("deleteFramebuffer", framebuffer);
        }
        
        public void DeleteProgram(nsISupports program)
        {
            this.CallVoidMethod("deleteProgram", program);
        }
        
        public void DeleteRenderbuffer(nsISupports renderbuffer)
        {
            this.CallVoidMethod("deleteRenderbuffer", renderbuffer);
        }
        
        public void DeleteShader(nsISupports shader)
        {
            this.CallVoidMethod("deleteShader", shader);
        }
        
        public void DeleteTexture(nsISupports texture)
        {
            this.CallVoidMethod("deleteTexture", texture);
        }
        
        public void DepthFunc(uint func)
        {
            this.CallVoidMethod("depthFunc", func);
        }
        
        public void DepthMask(bool flag)
        {
            this.CallVoidMethod("depthMask", flag);
        }
        
        public void DepthRange(float zNear, float zFar)
        {
            this.CallVoidMethod("depthRange", zNear, zFar);
        }
        
        public void DetachShader(nsISupports program, nsISupports shader)
        {
            this.CallVoidMethod("detachShader", program, shader);
        }
        
        public void Disable(uint cap)
        {
            this.CallVoidMethod("disable", cap);
        }
        
        public void DisableVertexAttribArray(uint index)
        {
            this.CallVoidMethod("disableVertexAttribArray", index);
        }
        
        public void DrawArrays(uint mode, int first, int count)
        {
            this.CallVoidMethod("drawArrays", mode, first, count);
        }
        
        public void DrawElements(uint mode, int count, uint type, long offset)
        {
            this.CallVoidMethod("drawElements", mode, count, type, offset);
        }
        
        public void Enable(uint cap)
        {
            this.CallVoidMethod("enable", cap);
        }
        
        public void EnableVertexAttribArray(uint index)
        {
            this.CallVoidMethod("enableVertexAttribArray", index);
        }
        
        public void Finish()
        {
            this.CallVoidMethod("finish");
        }
        
        public void Flush()
        {
            this.CallVoidMethod("flush");
        }
        
        public void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, nsISupports renderbuffer)
        {
            this.CallVoidMethod("framebufferRenderbuffer", target, attachment, renderbuffertarget, renderbuffer);
        }
        
        public void FramebufferTexture2D(uint target, uint attachment, uint textarget, nsISupports texture, int level)
        {
            this.CallVoidMethod("framebufferTexture2D", target, attachment, textarget, texture, level);
        }
        
        public void FrontFace(uint mode)
        {
            this.CallVoidMethod("frontFace", mode);
        }
        
        public void GenerateMipmap(uint target)
        {
            this.CallVoidMethod("generateMipmap", target);
        }
        
        public nsISupports GetActiveAttrib(nsISupports program, uint index)
        {
            return this.CallMethod<nsISupports>("getActiveAttrib", program, index);
        }
        
        public nsISupports GetActiveUniform(nsISupports program, uint index)
        {
            return this.CallMethod<nsISupports>("getActiveUniform", program, index);
        }
        
        public nsISupports[] GetAttachedShaders(nsISupports program)
        {
            return this.CallMethod<nsISupports[]>("getAttachedShaders", program);
        }
        
        public int GetAttribLocation(nsISupports program, string name)
        {
            return this.CallMethod<int>("getAttribLocation", program, name);
        }
        
        public object GetBufferParameter(uint target, uint pname)
        {
            return this.CallMethod<object>("getBufferParameter", target, pname);
        }
        
        public object GetParameter(uint pname)
        {
            return this.CallMethod<object>("getParameter", pname);
        }
        
        public uint GetError()
        {
            return this.CallMethod<uint>("getError");
        }
        
        public object GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname)
        {
            return this.CallMethod<object>("getFramebufferAttachmentParameter", target, attachment, pname);
        }
        
        public object GetProgramParameter(nsISupports program, uint pname)
        {
            return this.CallMethod<object>("getProgramParameter", program, pname);
        }
        
        public string GetProgramInfoLog(nsISupports program)
        {
            return this.CallMethod<string>("getProgramInfoLog", program);
        }
        
        public object GetRenderbufferParameter(uint target, uint pname)
        {
            return this.CallMethod<object>("getRenderbufferParameter", target, pname);
        }
        
        public object GetShaderParameter(nsISupports shader, uint pname)
        {
            return this.CallMethod<object>("getShaderParameter", shader, pname);
        }
        
        public nsISupports GetShaderPrecisionFormat(uint shadertype, uint precisiontype)
        {
            return this.CallMethod<nsISupports>("getShaderPrecisionFormat", shadertype, precisiontype);
        }
        
        public string GetShaderInfoLog(nsISupports shader)
        {
            return this.CallMethod<string>("getShaderInfoLog", shader);
        }
        
        public string GetShaderSource(nsISupports shader)
        {
            return this.CallMethod<string>("getShaderSource", shader);
        }
        
        public object GetTexParameter(uint target, uint pname)
        {
            return this.CallMethod<object>("getTexParameter", target, pname);
        }
        
        public object GetUniform(nsISupports program, nsISupports location)
        {
            return this.CallMethod<object>("getUniform", program, location);
        }
        
        public nsISupports GetUniformLocation(nsISupports program, string name)
        {
            return this.CallMethod<nsISupports>("getUniformLocation", program, name);
        }
        
        public object GetVertexAttrib(uint index, uint pname)
        {
            return this.CallMethod<object>("getVertexAttrib", index, pname);
        }
        
        public long GetVertexAttribOffset(uint index, uint pname)
        {
            return this.CallMethod<long>("getVertexAttribOffset", index, pname);
        }
        
        public void Hint(uint target, uint mode)
        {
            this.CallVoidMethod("hint", target, mode);
        }
        
        public bool IsBuffer(nsISupports buffer)
        {
            return this.CallMethod<bool>("isBuffer", buffer);
        }
        
        public bool IsEnabled(uint cap)
        {
            return this.CallMethod<bool>("isEnabled", cap);
        }
        
        public bool IsFramebuffer(nsISupports framebuffer)
        {
            return this.CallMethod<bool>("isFramebuffer", framebuffer);
        }
        
        public bool IsProgram(nsISupports program)
        {
            return this.CallMethod<bool>("isProgram", program);
        }
        
        public bool IsRenderbuffer(nsISupports renderbuffer)
        {
            return this.CallMethod<bool>("isRenderbuffer", renderbuffer);
        }
        
        public bool IsShader(nsISupports shader)
        {
            return this.CallMethod<bool>("isShader", shader);
        }
        
        public bool IsTexture(nsISupports texture)
        {
            return this.CallMethod<bool>("isTexture", texture);
        }
        
        public void LineWidth(float width)
        {
            this.CallVoidMethod("lineWidth", width);
        }
        
        public void LinkProgram(nsISupports program)
        {
            this.CallVoidMethod("linkProgram", program);
        }
        
        public void PixelStorei(uint pname, int param)
        {
            this.CallVoidMethod("pixelStorei", pname, param);
        }
        
        public void PolygonOffset(float factor, float units)
        {
            this.CallVoidMethod("polygonOffset", factor, units);
        }
        
        public void RenderbufferStorage(uint target, uint internalformat, int width, int height)
        {
            this.CallVoidMethod("renderbufferStorage", target, internalformat, width, height);
        }
        
        public void SampleCoverage(float value, bool invert)
        {
            this.CallVoidMethod("sampleCoverage", value, invert);
        }
        
        public void Scissor(int x, int y, int width, int height)
        {
            this.CallVoidMethod("scissor", x, y, width, height);
        }
        
        public void ShaderSource(nsISupports shader, string source)
        {
            this.CallVoidMethod("shaderSource", shader, source);
        }
        
        public void StencilFunc(uint func, int @ref, uint mask)
        {
            this.CallVoidMethod("stencilFunc", func, @ref, mask);
        }
        
        public void StencilFuncSeparate(uint face, uint func, int @ref, uint mask)
        {
            this.CallVoidMethod("stencilFuncSeparate", face, func, @ref, mask);
        }
        
        public void StencilMask(uint mask)
        {
            this.CallVoidMethod("stencilMask", mask);
        }
        
        public void StencilMaskSeparate(uint face, uint mask)
        {
            this.CallVoidMethod("stencilMaskSeparate", face, mask);
        }
        
        public void StencilOp(uint fail, uint zfail, uint zpass)
        {
            this.CallVoidMethod("stencilOp", fail, zfail, zpass);
        }
        
        public void StencilOpSeparate(uint face, uint fail, uint zfail, uint zpass)
        {
            this.CallVoidMethod("stencilOpSeparate", face, fail, zfail, zpass);
        }
        
        public void TexParameterf(uint target, uint pname, float param)
        {
            this.CallVoidMethod("texParameterf", target, pname, param);
        }
        
        public void TexParameteri(uint target, uint pname, int param)
        {
            this.CallVoidMethod("texParameteri", target, pname, param);
        }
        
        public void Uniform1f(nsISupports location, float x)
        {
            this.CallVoidMethod("uniform1f", location, x);
        }
        
        public void Uniform2f(nsISupports location, float x, float y)
        {
            this.CallVoidMethod("uniform2f", location, x, y);
        }
        
        public void Uniform3f(nsISupports location, float x, float y, float z)
        {
            this.CallVoidMethod("uniform3f", location, x, y, z);
        }
        
        public void Uniform4f(nsISupports location, float x, float y, float z, float w)
        {
            this.CallVoidMethod("uniform4f", location, x, y, z, w);
        }
        
        public void Uniform1i(nsISupports location, int x)
        {
            this.CallVoidMethod("uniform1i", location, x);
        }
        
        public void Uniform2i(nsISupports location, int x, int y)
        {
            this.CallVoidMethod("uniform2i", location, x, y);
        }
        
        public void Uniform3i(nsISupports location, int x, int y, int z)
        {
            this.CallVoidMethod("uniform3i", location, x, y, z);
        }
        
        public void Uniform4i(nsISupports location, int x, int y, int z, int w)
        {
            this.CallVoidMethod("uniform4i", location, x, y, z, w);
        }
        
        public void UseProgram(nsISupports program)
        {
            this.CallVoidMethod("useProgram", program);
        }
        
        public void ValidateProgram(nsISupports program)
        {
            this.CallVoidMethod("validateProgram", program);
        }
        
        public void VertexAttrib1f(uint indx, float x)
        {
            this.CallVoidMethod("vertexAttrib1f", indx, x);
        }
        
        public void VertexAttrib1fv(uint indx, WebIDLUnion<IntPtr,System.Single[]> values)
        {
            this.CallVoidMethod("vertexAttrib1fv", indx, values);
        }
        
        public void VertexAttrib2f(uint indx, float x, float y)
        {
            this.CallVoidMethod("vertexAttrib2f", indx, x, y);
        }
        
        public void VertexAttrib2fv(uint indx, WebIDLUnion<IntPtr,System.Single[]> values)
        {
            this.CallVoidMethod("vertexAttrib2fv", indx, values);
        }
        
        public void VertexAttrib3f(uint indx, float x, float y, float z)
        {
            this.CallVoidMethod("vertexAttrib3f", indx, x, y, z);
        }
        
        public void VertexAttrib3fv(uint indx, WebIDLUnion<IntPtr,System.Single[]> values)
        {
            this.CallVoidMethod("vertexAttrib3fv", indx, values);
        }
        
        public void VertexAttrib4f(uint indx, float x, float y, float z, float w)
        {
            this.CallVoidMethod("vertexAttrib4f", indx, x, y, z, w);
        }
        
        public void VertexAttrib4fv(uint indx, WebIDLUnion<IntPtr,System.Single[]> values)
        {
            this.CallVoidMethod("vertexAttrib4fv", indx, values);
        }
        
        public void VertexAttribPointer(uint indx, int size, uint type, bool normalized, int stride, long offset)
        {
            this.CallVoidMethod("vertexAttribPointer", indx, size, type, normalized, stride, offset);
        }
        
        public void Viewport(int x, int y, int width, int height)
        {
            this.CallVoidMethod("viewport", x, y, width, height);
        }
    }
}
