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
// Generated by IDLImporter from file nsIDOMParser.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// The nsIDOMParser interface is a non-SAX interface that can be used
    /// to parse a string or byte stream containing XML or HTML content
    /// to a DOM document. Parsing is always synchronous - a document is always
    /// returned from the parsing methods. This is as opposed to loading and
    /// parsing with the XMLHttpRequest interface, which can be used for
    /// asynchronous (callback-based) loading.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5677f36e-1842-4c6f-a39c-2e5576ab8b40")]
	public interface nsIDOMParser
	{
		
		/// <summary>
        /// The string passed in is parsed into a DOM document.
        ///
        /// @param str The UTF16 string to be parsed
        /// @param contentType The content type of the string (see parseFromStream)
        /// @returns The DOM document created as a result of parsing the
        /// string
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument ParseFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string str, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// The buffer is parsed into a DOM document.
        /// The charset is determined from the xml entity decl.
        ///
        /// @param buf The octet array data to be parsed
        /// @param bufLen Length (in bytes) of the data
        /// @param contentType The content type of the data (see parseFromStream)
        /// @returns The DOM document created as a result of parsing the
        /// string
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument ParseFromBuffer(System.IntPtr buf, uint bufLen, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// The byte stream passed in is parsed into a DOM document.
        ///
        /// Not accessible from web content.
        ///
        /// @param stream The byte stream whose contents are parsed
        /// @param charset The character set that was used to encode the byte
        /// stream. NULL if not specified.
        /// @param contentLength The number of bytes in the input stream.
        /// @param contentType The content type of the string - either text/xml,
        /// application/xml, or application/xhtml+xml.
        /// Must not be NULL.
        /// @returns The DOM document created as a result of parsing the
        /// stream
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, int contentLength, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// Initialize the principal and document and base URIs that the parser should
        /// use for documents it creates.  If this is not called, then a null
        /// principal and its URI will be used.  When creating a DOMParser via the JS
        /// constructor, this will be called automatically.  This method may only be
        /// called once.  If this method fails, all following parse attempts will
        /// fail.
        ///
        /// @param principal The principal to use for documents we create.
        /// If this is null, a codebase principal will be created
        /// based on documentURI; in that case the documentURI must
        /// be non-null.
        /// @param documentURI The documentURI to use for the documents we create.
        /// If null, the principal's URI will be used;
        /// in that case, the principal must be non-null and its
        /// URI must be non-null.
        /// @param baseURI The baseURI to use for the documents we create.
        /// If null, the documentURI will be used.
        /// @param scriptObject The object from which the context for event handling
        /// can be got.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.Interface)] nsIURI documentURI, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI, System.IntPtr scriptObject);
	}
	
	/// <summary>
    /// The nsIDOMParserJS interface provides a scriptable way of calling init().
    /// Do NOT use this interface from languages other than JavaScript.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba6bcd6c-63d8-49b3-bc8a-1e5e895645bc")]
	public interface nsIDOMParserJS
	{
		
		/// <summary>
        /// Just like nsIDOMParser.init, but callable from JS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.Interface)] nsIURI documentURI, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI);
	}
}
