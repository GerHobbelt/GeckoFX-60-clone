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
// Generated by IDLImporter from file nsIStyleSheetService.idl
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
    /// nsIStyleSheetService allows extensions or embeddors to add to the
    /// built-in list of user or agent style sheets.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4de68896-e8eb-41de-8237-a797b570ac4a")]
	public interface nsIStyleSheetService
	{
		
		/// <summary>
        /// Synchronously loads a style sheet from |sheetURI| and adds it to the list
        /// of user or agent style sheets.
        ///
        /// A user sheet loaded via this API will come before userContent.css and
        /// userChrome.css in the cascade (so the rules in it will have lower
        /// precedence than rules in those sheets).
        ///
        /// An agent sheet loaded via this API will come after ua.css in the cascade
        /// (so the rules in it will have higher precedence than rules in ua.css).
        ///
        /// The relative ordering of two user or two agent sheets loaded via
        /// this API is undefined.
        ///
        /// Sheets added via this API take effect on all documents, including
        /// already-loaded ones, immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadAndRegisterSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);
		
		/// <summary>
        /// Returns true if a style sheet at |sheetURI| has previously been
        /// added to the list of style sheets specified by |type|.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SheetRegistered([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);
		
		/// <summary>
        /// Synchronously loads a style sheet from |sheetURI| and returns the
        /// new style sheet object. Can be used with nsIDOMWindowUtils.addSheet.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPreloadedStyleSheet PreloadSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);
		
		/// <summary>
        /// Asynchronously loads a style sheet from |sheetURI| and returns a Promise
        /// which resolves to the new style sheet object, which can be used with
        /// nsIDOMWindowUtils.addSheet, when it has completed loading.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal PreloadSheetAsync([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type, System.IntPtr jsContext);
		
		/// <summary>
        /// Remove the style sheet at |sheetURI| from the list of style sheets
        /// specified by |type|.  The removal takes effect immediately, even for
        /// already-loaded documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterSheet([MarshalAs(UnmanagedType.Interface)] nsIURI sheetURI, uint type);
	}
	
	/// <summary>nsIStyleSheetServiceConsts </summary>
	public class nsIStyleSheetServiceConsts
	{
		
		// <summary>
        // nsIStyleSheetService allows extensions or embeddors to add to the
        // built-in list of user or agent style sheets.
        // </summary>
		public const ulong AGENT_SHEET = 0;
		
		// 
		public const ulong USER_SHEET = 1;
		
		// 
		public const ulong AUTHOR_SHEET = 2;
	}
}
