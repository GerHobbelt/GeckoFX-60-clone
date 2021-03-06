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
// Generated by IDLImporter from file nsIEditorMailSupport.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fdf23301-4a94-11d3-9ce4-9960496c41bc")]
	public interface nsIEditorMailSupport
	{
		
		/// <summary>
        ///Paste the text in the OS clipboard at the cursor position,
        /// as a quotation (whose representation is dependant on the editor type),
        /// replacing the selected text (if any).
        /// @param aSelectionType Text or html?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteAsQuotation(int aSelectionType);
		
		/// <summary>
        ///Insert a string as quoted text
        /// (whose representation is dependant on the editor type),
        /// replacing the selected text (if any).
        /// @param aQuotedText  The actual text to be quoted
        /// @return             The node which was inserted
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertAsQuotation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aQuotedText);
		
		/// <summary>
        /// Inserts a plaintext string at the current location,
        /// with special processing for lines beginning with ">",
        /// which will be treated as mail quotes and inserted
        /// as plaintext quoted blocks.
        /// If the selection is not collapsed, the selection is deleted
        /// and the insertion takes place at the resulting collapsed selection.
        ///
        /// @param aString   the string to be inserted
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertTextWithQuotations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStringToInsert);
		
		/// <summary>
        ///Paste a string as quoted text,
        /// whose representation is dependant on the editor type,
        /// replacing the selected text (if any)
        /// @param aCitation    The "mid" URL of the source message
        /// @param aSelectionType Text or html?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteAsCitedQuotation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCitation, int aSelectionType);
		
		/// <summary>
        ///Insert a string as quoted text
        /// (whose representation is dependant on the editor type),
        /// replacing the selected text (if any),
        /// including, if possible, a "cite" attribute.
        /// @param aQuotedText  The actual text to be quoted
        /// @param aCitation    The "mid" URL of the source message
        /// @param aInsertHTML  Insert as html?  (vs plaintext)
        /// @return             The node which was inserted
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertAsCitedQuotation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aQuotedText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCitation, [MarshalAs(UnmanagedType.U1)] bool aInsertHTML);
		
		/// <summary>
        /// Rewrap the selected part of the document, re-quoting if necessary.
        /// @param aRespectNewlines  Try to maintain newlines in the original?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Rewrap([MarshalAs(UnmanagedType.U1)] bool aRespectNewlines);
		
		/// <summary>
        /// Strip any citations in the selected part of the document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StripCites();
		
		/// <summary>
        /// Get a list of IMG and OBJECT tags in the current document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetEmbeddedObjects();
	}
}
