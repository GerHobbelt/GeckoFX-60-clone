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
// Generated by IDLImporter from file nsIWebNavigation.idl
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
    /// The nsIWebNavigation interface defines an interface for navigating the web.
    /// It provides methods and attributes to direct an object to navigate to a new
    /// location, stop or restart an in process load, or determine where the object
    /// has previously gone.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F5D9E7B0-D930-11d3-B057-00A024FFC08C")]
	public interface nsIWebNavigation
	{
		
		/// <summary>
        /// Indicates if the object can go back.  If true this indicates that
        /// there is back session history available for navigation.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanGoBackAttribute();
		
		/// <summary>
        /// Indicates if the object can go forward.  If true this indicates that
        /// there is forward session history available for navigation
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanGoForwardAttribute();
		
		/// <summary>
        /// Tells the object to navigate to the previous session history item.  When a
        /// page is loaded from session history, all content is loaded from the cache
        /// (if available) and page state (such as form values and scroll position) is
        /// restored.
        ///
        /// @throw NS_ERROR_UNEXPECTED
        /// Indicates that the call was unexpected at this time, which implies
        /// that canGoBack is false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GoBack();
		
		/// <summary>
        /// Tells the object to navigate to the next session history item.  When a
        /// page is loaded from session history, all content is loaded from the cache
        /// (if available) and page state (such as form values and scroll position) is
        /// restored.
        ///
        /// @throw NS_ERROR_UNEXPECTED
        /// Indicates that the call was unexpected at this time, which implies
        /// that canGoForward is false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GoForward();
		
		/// <summary>
        /// Tells the object to navigate to the session history item at a given index.
        ///
        /// @throw NS_ERROR_UNEXPECTED
        /// Indicates that the call was unexpected at this time, which implies
        /// that session history entry at the given index does not exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GotoIndex(int index);
		
		/// <summary>
        /// Loads a given URI.  This will give priority to loading the requested URI
        /// in the object implementing	this interface.  If it can't be loaded here
        /// however, the URI dispatcher will go through its normal process of content
        /// loading.
        ///
        /// @param aURI
        /// The URI string to load.  For HTTP and FTP URLs and possibly others,
        /// characters above U+007F will be converted to UTF-8 and then URL-
        /// escaped per the rules of RFC 2396.
        /// @param aLoadFlags
        /// Flags modifying load behaviour.  This parameter is a bitwise
        /// combination of the load flags defined above.  (Undefined bits are
        /// reserved for future use.)  Generally you will pass LOAD_FLAGS_NONE
        /// for this parameter.
        /// @param aReferrer
        /// The referring URI.  If this argument is null, then the referring
        /// URI will be inferred internally.
        /// @param aPostData
        /// If the URI corresponds to a HTTP request, then this stream is
        /// appended directly to the HTTP request headers.  It may be prefixed
        /// with additional HTTP headers.  This stream must contain a "\r\n"
        /// sequence separating any HTTP headers from the HTTP request body.
        /// This parameter is optional and may be null.
        /// @param aHeaders
        /// If the URI corresponds to a HTTP request, then any HTTP headers
        /// contained in this stream are set on the HTTP request.  The HTTP
        /// header stream is formatted as:
        /// ( HEADER "\r\n" )*
        /// This parameter is optional and may be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aURI, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeaders);
		
		/// <summary>
        /// Tells the Object to reload the current page.  There may be cases where the
        /// user will be asked to confirm the reload (for example, when it is
        /// determined that the request is non-idempotent).
        ///
        /// @param aReloadFlags
        /// Flags modifying load behaviour.  This parameter is a bitwise
        /// combination of the Load Flags defined above.  (Undefined bits are
        /// reserved for future use.)  Generally you will pass LOAD_FLAGS_NONE
        /// for this parameter.
        ///
        /// @throw NS_BINDING_ABORTED
        /// Indicating that the user canceled the reload.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reload(uint aReloadFlags);
		
		/// <summary>
        /// Stops a load of a URI.
        ///
        /// @param aStopFlags
        /// This parameter is one of the stop flags defined above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop(uint aStopFlags);
		
		/// <summary>
        /// Retrieves the current DOM document for the frame, or lazily creates a
        /// blank document if there is none.  This attribute never returns null except
        /// for unexpected error situations.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocumentAttribute();
		
		/// <summary>
        /// The currently loaded URI or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetCurrentURIAttribute();
		
		/// <summary>
        /// The referring URI for the currently loaded URI or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferringURIAttribute();
		
		/// <summary>
        /// The session history object used by this web navigation instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHistory GetSessionHistoryAttribute();
		
		/// <summary>
        /// The session history object used by this web navigation instance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSessionHistoryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHistory aSessionHistory);
	}
}
