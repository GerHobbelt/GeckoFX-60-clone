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
// Generated by IDLImporter from file nsIWebBrowserPersist.idl
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
    /// Interface for persisting DOM documents and URIs to local or remote storage.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8cd752a4-60b1-42c3-a819-65c7a1138a28")]
	public interface nsIWebBrowserPersist : nsICancelable
	{
		
		/// <summary>
        /// Call this method to request that this object abort whatever operation it
        /// may be performing.
        ///
        /// @param aReason
        /// Pass a failure code to indicate the reason why this operation is
        /// being canceled.  It is an error to pass a success code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(int aReason);
		
		/// <summary>
        /// Flags governing how data is fetched and saved from the network.
        /// It is best to set this value explicitly unless you are prepared
        /// to accept the default values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPersistFlagsAttribute();
		
		/// <summary>
        /// Flags governing how data is fetched and saved from the network.
        /// It is best to set this value explicitly unless you are prepared
        /// to accept the default values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistFlagsAttribute(uint aPersistFlags);
		
		/// <summary>
        /// Current state of the persister object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCurrentStateAttribute();
		
		/// <summary>
        /// Value indicating the success or failure of the persist
        /// operation.
        ///
        /// @throws NS_BINDING_ABORTED Operation cancelled.
        /// @throws NS_ERROR_FAILURE Non-specific failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetResultAttribute();
		
		/// <summary>
        /// Callback listener for progress notifications. The object that the
        /// embbedder supplies may also implement nsIInterfaceRequestor and be
        /// prepared to return nsIAuthPrompt or other interfaces that may be required
        /// to download data.
        ///
        /// @see nsIAuthPrompt
        /// @see nsIInterfaceRequestor
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebProgressListener GetProgressListenerAttribute();
		
		/// <summary>
        /// Callback listener for progress notifications. The object that the
        /// embbedder supplies may also implement nsIInterfaceRequestor and be
        /// prepared to return nsIAuthPrompt or other interfaces that may be required
        /// to download data.
        ///
        /// @see nsIAuthPrompt
        /// @see nsIInterfaceRequestor
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProgressListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aProgressListener);
		
		/// <summary>
        /// Save the specified URI to file.
        ///
        /// @param aURI       URI to save to file. Some implementations of this interface
        /// may also support <CODE>nullptr</CODE> to imply the currently
        /// loaded URI.
        /// @param aCacheKey  An object representing the URI in the cache or
        /// <CODE>nullptr</CODE>.  This can be a necko cache key,
        /// an nsIWebPageDescriptor, or the currentDescriptor of an
        /// nsIWebPageDescriptor.
        /// @param aReferrer  The referrer URI to pass with an HTTP request or
        /// <CODE>nullptr</CODE>.
        /// @param aReferrerPolicy  The referrer policy for when and what to send via
        /// HTTP Referer header.  Ignored if aReferrer is
        /// <CODE>nullptr</CODE>.  Taken from REFERRER_POLICY
        /// constants in nsIHttpChannel.
        /// @param aPostData  Post data to pass with an HTTP request or
        /// <CODE>nullptr</CODE>.
        /// @param aExtraHeaders Additional headers to supply with an HTTP request
        /// or <CODE>nullptr</CODE>.
        /// @param aFile      Target file. This may be a nsIFile object or an
        /// nsIURI object with a file scheme or a scheme that
        /// supports uploading (e.g. ftp).
        /// @param aPrivacyContext A context from which the privacy status of this
        /// save operation can be determined. Must only be null
        /// in situations in which no such context is available
        /// (eg. the operation has no logical association with any
        /// window or document)
        ///
        /// @see nsIFile
        /// @see nsIURI
        /// @see nsIInputStream
        ///
        /// @throws NS_ERROR_INVALID_ARG One or more arguments was invalid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, uint aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.LPStr)] string aExtraHeaders, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile, [MarshalAs(UnmanagedType.Interface)] nsILoadContext aPrivacyContext);
		
		/// <summary>
        /// @param aIsPrivate Treat the save operation as private (ie. with
        /// regards to networking operations and persistence
        /// of intermediate data, etc.)
        /// @see saveURI for all other parameter descriptions
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SavePrivacyAwareURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsISupports aCacheKey, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, uint aReferrerPolicy, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostData, [MarshalAs(UnmanagedType.LPStr)] string aExtraHeaders, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile, [MarshalAs(UnmanagedType.U1)] bool aIsPrivate);
		
		/// <summary>
        /// Save a channel to a file. It must not be opened yet.
        /// @see saveURI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile);
		
		/// <summary>
        /// Save the specified DOM document to file and optionally all linked files
        /// (e.g. images, CSS, JS & subframes). Do not call this method until the
        /// document has finished loading!
        ///
        /// @param aDocument          Document to save to file. Some implementations of
        /// this interface may also support <CODE>nullptr</CODE>
        /// to imply the currently loaded document.  Can be an
        /// nsIWebBrowserPersistDocument or nsIDOMDocument.
        /// @param aFile              Target local file. This may be a nsIFile object or an
        /// nsIURI object with a file scheme or a scheme that
        /// supports uploading (e.g. ftp).
        /// @param aDataPath          Path to directory where URIs linked to the document
        /// are saved or nullptr if no linked URIs should be saved.
        /// This may be a nsIFile object or an nsIURI object
        /// with a file scheme.
        /// @param aOutputContentType The desired MIME type format to save the
        /// document and all subdocuments into or nullptr to use
        /// the default behaviour.
        /// @param aEncodingFlags     Flags to pass to the encoder.
        /// @param aWrapColumn        For text documents, indicates the desired width to
        /// wrap text at. Parameter is ignored if wrapping is not
        /// specified by the encoding flags.
        ///
        /// @see nsIWebBrowserPersistDocument
        /// @see nsIWebBrowserPersistable
        /// @see nsIFile
        /// @see nsIURI
        ///
        /// @throws NS_ERROR_INVALID_ARG One or more arguments was invalid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveDocument([MarshalAs(UnmanagedType.Interface)] nsISupports aDocument, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile, [MarshalAs(UnmanagedType.Interface)] nsISupports aDataPath, [MarshalAs(UnmanagedType.LPStr)] string aOutputContentType, uint aEncodingFlags, uint aWrapColumn);
		
		/// <summary>
        /// Cancels the current operation. The caller is responsible for cleaning up
        /// partially written files or directories. This has the same effect as calling
        /// cancel with an argument of NS_BINDING_ABORTED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelSave();
	}
	
	/// <summary>nsIWebBrowserPersistConsts </summary>
	public class nsIWebBrowserPersistConsts
	{
		
		// <summary>
        //No special persistence behaviour. </summary>
		public const ulong PERSIST_FLAGS_NONE = 0;
		
		// <summary>
        //Use cached data if present (skipping validation), else load from network </summary>
		public const ulong PERSIST_FLAGS_FROM_CACHE = 1;
		
		// <summary>
        //Bypass the cached data. </summary>
		public const ulong PERSIST_FLAGS_BYPASS_CACHE = 2;
		
		// <summary>
        //Ignore any redirected data (usually adverts). </summary>
		public const ulong PERSIST_FLAGS_IGNORE_REDIRECTED_DATA = 4;
		
		// <summary>
        //Ignore IFRAME content (usually adverts). </summary>
		public const ulong PERSIST_FLAGS_IGNORE_IFRAMES = 8;
		
		// <summary>
        //Do not run the incoming data through a content converter e.g. to decompress it </summary>
		public const ulong PERSIST_FLAGS_NO_CONVERSION = 16;
		
		// <summary>
        //Replace existing files on the disk (use with due diligence!) </summary>
		public const ulong PERSIST_FLAGS_REPLACE_EXISTING_FILES = 32;
		
		// <summary>
        //Don't modify or add base tags </summary>
		public const ulong PERSIST_FLAGS_NO_BASE_TAG_MODIFICATIONS = 64;
		
		// <summary>
        //Make changes to original dom rather than cloning nodes </summary>
		public const ulong PERSIST_FLAGS_FIXUP_ORIGINAL_DOM = 128;
		
		// <summary>
        //Fix links relative to destination location (not origin) </summary>
		public const ulong PERSIST_FLAGS_FIXUP_LINKS_TO_DESTINATION = 256;
		
		// <summary>
        //Don't make any adjustments to links </summary>
		public const ulong PERSIST_FLAGS_DONT_FIXUP_LINKS = 512;
		
		// <summary>
        //Force serialization of output (one file at a time; not concurrent) </summary>
		public const ulong PERSIST_FLAGS_SERIALIZE_OUTPUT = 1024;
		
		// <summary>
        //Don't make any adjustments to filenames </summary>
		public const ulong PERSIST_FLAGS_DONT_CHANGE_FILENAMES = 2048;
		
		// <summary>
        //Fail on broken inline links </summary>
		public const ulong PERSIST_FLAGS_FAIL_ON_BROKEN_LINKS = 4096;
		
		// <summary>
        // Automatically cleanup after a failed or cancelled operation, deleting all
        // created files and directories. This flag does nothing for failed upload
        // operations to remote servers.
        // </summary>
		public const ulong PERSIST_FLAGS_CLEANUP_ON_FAILURE = 8192;
		
		// <summary>
        // Let the WebBrowserPersist decide whether the incoming data is encoded
        // and whether it needs to go through a content converter e.g. to
        // decompress it.
        // </summary>
		public const ulong PERSIST_FLAGS_AUTODETECT_APPLY_CONVERSION = 16384;
		
		// <summary>
        // Append the downloaded data to the target file.
        // This can only be used when persisting to a local file.
        // </summary>
		public const ulong PERSIST_FLAGS_APPEND_TO_FILE = 32768;
		
		// <summary>
        // Force relevant cookies to be sent with this load even if normally they
        // wouldn't be.
        // </summary>
		public const ulong PERSIST_FLAGS_FORCE_ALLOW_COOKIES = 65536;
		
		// <summary>
        //Persister is ready to save data </summary>
		public const ulong PERSIST_STATE_READY = 1;
		
		// <summary>
        //Persister is saving data </summary>
		public const ulong PERSIST_STATE_SAVING = 2;
		
		// <summary>
        //Persister has finished saving data </summary>
		public const ulong PERSIST_STATE_FINISHED = 3;
		
		// <summary>
        //Output only the current selection as opposed to the whole document. </summary>
		public const ulong ENCODE_FLAGS_SELECTION_ONLY = 1;
		
		// <summary>
        // For plaintext output. Convert html to plaintext that looks like the html.
        // Implies wrap (except inside &lt;pre&gt;), since html wraps.
        // HTML output: always do prettyprinting, ignoring existing formatting.
        // </summary>
		public const ulong ENCODE_FLAGS_FORMATTED = 2;
		
		// <summary>
        // Output without formatting or wrapping the content. This flag
        // may be used to preserve the original formatting as much as possible.
        // </summary>
		public const ulong ENCODE_FLAGS_RAW = 4;
		
		// <summary>
        //Output only the body section, no HTML tags. </summary>
		public const ulong ENCODE_FLAGS_BODY_ONLY = 8;
		
		// <summary>
        //Wrap even if when not doing formatted output (e.g. for text fields). </summary>
		public const ulong ENCODE_FLAGS_PREFORMATTED = 16;
		
		// <summary>
        //Wrap documents at the specified column. </summary>
		public const ulong ENCODE_FLAGS_WRAP = 32;
		
		// <summary>
        // For plaintext output. Output for format flowed (RFC 2646). This is used
        // when converting to text for mail sending. This differs just slightly
        // but in an important way from normal formatted, and that is that
        // lines are space stuffed. This can't (correctly) be done later.
        // </summary>
		public const ulong ENCODE_FLAGS_FORMAT_FLOWED = 64;
		
		// <summary>
        //Convert links to absolute links where possible. </summary>
		public const ulong ENCODE_FLAGS_ABSOLUTE_LINKS = 128;
		
		// <summary>
        // Output with carriage return line breaks. May also be combined with
        // ENCODE_FLAGS_LF_LINEBREAKS and if neither is specified, the platform
        // default format is used.
        // </summary>
		public const ulong ENCODE_FLAGS_CR_LINEBREAKS = 512;
		
		// <summary>
        // Output with linefeed line breaks. May also be combined with
        // ENCODE_FLAGS_CR_LINEBREAKS and if neither is specified, the platform
        // default format is used.
        // </summary>
		public const ulong ENCODE_FLAGS_LF_LINEBREAKS = 1024;
		
		// <summary>
        //For plaintext output. Output the content of noscript elements. </summary>
		public const ulong ENCODE_FLAGS_NOSCRIPT_CONTENT = 2048;
		
		// <summary>
        //For plaintext output. Output the content of noframes elements. </summary>
		public const ulong ENCODE_FLAGS_NOFRAMES_CONTENT = 4096;
		
		// <summary>
        // Encode basic entities, e.g. output &nbsp; instead of character code 0xa0.
        // The basic set is just &nbsp; &amp; &lt; &gt; &quot; for interoperability
        // with older products that don't support &alpha; and friends.
        // </summary>
		public const ulong ENCODE_FLAGS_ENCODE_BASIC_ENTITIES = 8192;
	}
}
