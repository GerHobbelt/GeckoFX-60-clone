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
// Generated by IDLImporter from file nsIAutoCompleteController.idl
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
	[Guid("ff9f8465-204a-47a6-b3c9-0628b3856684")]
	public interface nsIAutoCompleteController
	{
		
		/// <summary>
        /// The input widget that is currently being controlled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAutoCompleteInput GetInputAttribute();
		
		/// <summary>
        /// The input widget that is currently being controlled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInputAttribute([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteInput aInput);
		
		/// <summary>
        /// State which indicates the status of possible ongoing searches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetSearchStatusAttribute();
		
		/// <summary>
        /// The number of matches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMatchCountAttribute();
		
		/// <summary>
        /// Start a search on a string, assuming the input property is already set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartSearch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase searchString);
		
		/// <summary>
        /// Stop all asynchronous searches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopSearch();
		
		/// <summary>
        /// Notify the controller that the user has changed text in the textbox.
        /// This includes all means of changing the text value, including typing a
        /// character, backspacing, deleting, pasting, committing composition or
        /// canceling composition.
        ///
        /// NOTE: handleText() must be called after composition actually ends, even if
        /// the composition is canceled and the textbox value isn't changed.
        /// Then, implementation of handleText() can access the editor when
        /// it's not in composing mode. DOM compositionend event is not good
        /// timing for calling handleText(). DOM input event immediately after
        /// DOM compositionend event is the best timing to call this.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleText();
		
		/// <summary>
        /// Notify the controller that the user wishes to enter the current text. If
        /// aIsPopupSelection is true, then a selection was made from the popup, so
        /// fill this value into the input field before continuing. If false, just
        /// use the current value of the input field.
        ///
        /// @return True if the controller wishes to prevent event propagation and default event
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleEnter([MarshalAs(UnmanagedType.U1)] bool aIsPopupSelection);
		
		/// <summary>
        /// Notify the controller that the user wishes to revert autocomplete
        ///
        /// @return True if the controller wishes to prevent event propagation and default event
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleEscape();
		
		/// <summary>
        /// Notify the controller that the user wishes to start composition
        ///
        /// NOTE: nsIAutoCompleteController implementation expects that this is called
        /// by DOM compositionstart handler.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStartComposition();
		
		/// <summary>
        /// Notify the controller that the user wishes to end composition
        ///
        /// NOTE: nsIAutoCompleteController implementation expects that this is called
        /// by DOM compositionend handler.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEndComposition();
		
		/// <summary>
        /// Handle tab. Just closes up.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleTab();
		
		/// <summary>
        /// Notify the controller of the following key navigation events:
        /// up, down, left, right, page up, page down
        ///
        /// @return True if the controller wishes to prevent event propagation and default event
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleKeyNavigation(uint key);
		
		/// <summary>
        /// Notify the controller that the user chose to delete the current
        /// auto-complete result.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleDelete();
		
		/// <summary>
        /// Get the value of the result at a given index in the last completed search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the label of the result at a given index in the last completed search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLabelAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the comment of the result at a given index in the last completed search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommentAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the style hint for the result at a given index in the last completed search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStyleAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get the url of the image of the result at a given index in the last completed search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImageAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// For the last completed search, get the final value that should be completed
        /// when the user confirms the match at the given index
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFinalCompleteValueAt(int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Get / set the current search string.  Note, setting will not start searching
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);
		
		/// <summary>
        /// Get / set the current search string.  Note, setting will not start searching
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString);
	}
	
	/// <summary>nsIAutoCompleteControllerConsts </summary>
	public class nsIAutoCompleteControllerConsts
	{
		
		// <summary>
        // Possible values for the searchStatus attribute
        // </summary>
		public const ushort STATUS_NONE = 1;
		
		// 
		public const ushort STATUS_SEARCHING = 2;
		
		// 
		public const ushort STATUS_COMPLETE_NO_MATCH = 3;
		
		// 
		public const ushort STATUS_COMPLETE_MATCH = 4;
	}
}
