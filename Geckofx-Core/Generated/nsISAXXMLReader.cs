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
// Generated by IDLImporter from file nsISAXXMLReader.idl
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
    /// Interface for reading an XML document using callbacks.
    ///
    /// NOTE: This file (and related ones) used to implement a full-featured SAX XML
    /// parser. But we have few uses of this interface and the ones we have only use
    /// a fraction of the full SAX functionality. So in bug 1416038 we removed a lot
    /// of it. See the changes associated with that bug if you need to reintroduce
    /// any of that functionality.
    ///
    /// nsISAXXMLReader is the interface that an XML parser's SAX2
    /// driver must implement.  This interface allows an application to set
    /// and query features and properties in the parser, to register event
    /// handlers for document processing, and to initiate a document
    /// parse.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5b1de802-9091-454f-9972-5753c0d0c70e")]
	public interface nsISAXXMLReader : nsIStreamListener
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);
		
		/// <summary>
        /// The base URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBaseURIAttribute();
		
		/// <summary>
        /// The base URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// If the application does not register a content handler, all
        /// content events reported by the SAX parser will be silently
        /// ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXContentHandler GetContentHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a content handler, all
        /// content events reported by the SAX parser will be silently
        /// ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXContentHandler aContentHandler);
		
		/// <summary>
        /// If the application does not register an error handler, all
        /// error events reported by the SAX parser will be silently ignored;
        /// however, normal processing may not continue.  It is highly
        /// recommended that all SAX applications implement an error handler
        /// to avoid unexpected bugs.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXErrorHandler GetErrorHandlerAttribute();
		
		/// <summary>
        /// If the application does not register an error handler, all
        /// error events reported by the SAX parser will be silently ignored;
        /// however, normal processing may not continue.  It is highly
        /// recommended that all SAX applications implement an error handler
        /// to avoid unexpected bugs.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetErrorHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXErrorHandler aErrorHandler);
		
		/// <summary>
        /// @param str The UTF16 string to be parsed
        /// @param contentType The content type of the string (see parseFromStream)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseFromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// @param stream The byte stream whose contents are parsed
        /// @param charset The character set that was used to encode the byte
        /// stream. NULL if not specified.
        /// @param contentType The content type of the string - either text/xml,
        /// application/xml, or application/xhtml+xml.
        /// Must not be NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// Begin an asynchronous parse. This method initializes the parser,
        /// and must be called before any nsIStreamListener methods. It is
        /// then the caller's duty to call nsIStreamListener methods to drive
        /// the parser. Once this method is called, the caller must not call
        /// one of the other parse methods.
        ///
        /// @param observer The nsIRequestObserver to notify upon start or stop.
        /// Can be NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver observer);
	}
}
