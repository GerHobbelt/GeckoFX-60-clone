// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIFormPOSTActionChannel.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// nsIFormPOSTActionChannel
    ///
    /// Channel classes that want to be allowed for HTML form POST action must
    /// implement this interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fc826b53-0db8-42b4-aa6a-5dd2cfca52a4")]
	public interface nsIFormPOSTActionChannel : nsIUploadChannel
	{
		
		/// <summary>
        /// Sets a stream to be uploaded by this channel.
        ///
        /// Most implementations of this interface require that the stream:
        /// (1) implement threadsafe addRef and release
        /// (2) implement nsIInputStream::readSegments
        /// (3) implement nsISeekableStream::seek
        ///
        /// History here is that we need to support both streams that already have
        /// headers (e.g., Content-Type and Content-Length) information prepended to
        /// the stream (by plugins) as well as clients (composer, uploading
        /// application) that want to upload data streams without any knowledge of
        /// protocol specifications.  For this reason, we have a special meaning
        /// for the aContentType parameter (see below).
        ///
        /// @param aStream
        /// The stream to be uploaded by this channel.
        /// @param aContentType
        /// If aContentType is empty, the protocol will assume that no
        /// content headers are to be added to the uploaded stream and that
        /// any required headers are already encoded in the stream.  In the
        /// case of HTTP, if this parameter is non-empty, then its value will
        /// replace any existing Content-Type header on the HTTP request.
        /// In the case of FTP and FILE, this parameter is ignored.
        /// @param aContentLength
        /// A value of -1 indicates that the length of the stream should be
        /// determined by calling the stream's |available| method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetUploadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aContentType, long aContentLength);
		
		/// <summary>
        /// Get the stream (to be) uploaded by this channel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream GetUploadStreamAttribute();
	}
}