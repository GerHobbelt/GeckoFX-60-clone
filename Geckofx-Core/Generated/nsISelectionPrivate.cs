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
// Generated by IDLImporter from file nsISelectionPrivate.idl
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
	[Guid("0c9f4f74-ee7e-4fe9-be6b-0ba856368178")]
	public interface nsISelectionPrivate
	{
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInterlinePositionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInterlinePositionAttribute([MarshalAs(UnmanagedType.U1)] bool aInterlinePosition);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetAncestorLimiterAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAncestorLimiterAttribute(System.IntPtr aAncestorLimiter);
		
		/// <summary>
        ///startBatchChanges
        ///       match this up with endbatchChanges. will stop ui updates while multiple selection methods are called
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartBatchChanges();
		
		/// <summary>
        ///endBatchChanges
        ///       match this up with startBatchChanges
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndBatchChanges();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToStringWithFormat([MarshalAs(UnmanagedType.LPStr)] string formatType, uint flags, int wrapColumn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSelectionListener([MarshalAs(UnmanagedType.Interface)] nsISelectionListener newListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSelectionListener([MarshalAs(UnmanagedType.Interface)] nsISelectionListener listenerToRemove);
		
		/// <summary>
        ///Test if supplied range points to a single table element:
        /// Result is one of above constants. "None" means
        /// a table element isn't selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTableSelectionType([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);
		
		/// <summary>
        ///canCacheFrameOffset
        /// Frame Offset cache can be used just during calling nsEditor::EndPlaceHolderTransaction.
        /// EndPlaceHolderTransaction will give rise to reflow/refreshing view/scroll, and call times
        /// of nsTextFrame::GetPointFromOffset whose return value is to be cached.
        /// see bugs 35296 and 199412
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanCacheFrameOffsetAttribute();
		
		/// <summary>
        ///canCacheFrameOffset
        /// Frame Offset cache can be used just during calling nsEditor::EndPlaceHolderTransaction.
        /// EndPlaceHolderTransaction will give rise to reflow/refreshing view/scroll, and call times
        /// of nsTextFrame::GetPointFromOffset whose return value is to be cached.
        /// see bugs 35296 and 199412
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanCacheFrameOffsetAttribute([MarshalAs(UnmanagedType.U1)] bool aCanCacheFrameOffset);
		
		/// <summary>
        ///GetCachedOffsetForFrame
        /// Returns cached value for nsTextFrame::GetPointFromOffset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCachedFrameOffset(System.IntPtr aFrame, int inOffset, System.IntPtr aPoint);
		
		/// <summary>
        /// Get the direction of the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsDirection GetSelectionDirection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionDirection(nsDirection aDirection);
		
		/// <summary>
        /// Returns the type of the selection (see nsISelectionController for
        /// available constants).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetTypeAttribute();
		
		/// <summary>
        /// Return array of ranges intersecting with the given DOM interval.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangesForInterval([MarshalAs(UnmanagedType.Interface)] nsIDOMNode beginNode, int beginOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode endNode, int endOffset, [MarshalAs(UnmanagedType.U1)] bool allowAdjacent, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=5)] ref nsIDOMRange[] results);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangesForIntervalArray(System.IntPtr beginNode, int beginOffset, System.IntPtr endNode, int endOffset, [MarshalAs(UnmanagedType.U1)] bool allowAdjacent, System.IntPtr results);
		
		/// <summary>
        /// Scrolls a region of the selection, so that it is visible in
        /// the scrolled view.
        ///
        /// @param aRegion - the region inside the selection to scroll into view
        /// (see selection region constants defined in
        /// nsISelectionController).
        /// @param aIsSynchronous - when true, scrolls the selection into view
        /// before returning. If false, posts a request which
        /// is processed at some point after the method returns.
        /// @param aVPercent - how to align the frame vertically.
        /// @param aHPercent - how to align the frame horizontally.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollIntoView(short aRegion, [MarshalAs(UnmanagedType.U1)] bool aIsSynchronous, short aVPercent, short aHPercent);
		
		/// <summary>
        /// Scrolls a region of the selection, so that it is visible in
        /// the scrolled view.
        ///
        /// @param aRegion - the region inside the selection to scroll into view
        /// (see selection region constants defined in
        /// nsISelectionController).
        /// @param aIsSynchronous - when true, scrolls the selection into view
        /// before returning. If false, posts a request which
        /// is processed at some point after the method returns.
        /// @param aVertical - how to align the frame vertically and when.
        /// See nsIPresShell.h:ScrollAxis for details.
        /// @param aHorizontal - how to align the frame horizontally and when.
        /// See nsIPresShell.h:ScrollAxis for details.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollIntoViewInternal(short aRegion, [MarshalAs(UnmanagedType.U1)] bool aIsSynchronous, ScrollAxis aVertical, ScrollAxis aHorizontal);
		
		/// <summary>
        /// Modifies the cursor Bidi level after a change in keyboard direction
        /// @param langRTL is PR_TRUE if the new language is right-to-left or
        /// PR_FALSE if the new language is left-to-right.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectionLanguageChange([MarshalAs(UnmanagedType.U1)] bool langRTL);
		
		/// <summary>
        /// setColors() sets custom colors for the selection.
        /// Currently, this is supported only when the selection type is SELECTION_FIND.
        /// Otherwise, throws an exception.
        ///
        /// @param aForegroundColor     The foreground color of the selection.
        /// If this is "currentColor", foreground color
        /// isn't changed by this selection.
        /// @param aBackgroundColor     The background color of the selection.
        /// If this is "transparent", background color is
        /// never painted.
        /// @param aAltForegroundColor  The alternative foreground color of the
        /// selection.
        /// If aBackgroundColor doesn't have sufficient
        /// contrast with its around or foreground color
        /// if "currentColor" is specified, alternative
        /// colors are used if it have higher contrast.
        /// @param aAltBackgroundColor  The alternative background color of the
        /// selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetColors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aForegroundColor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBackgroundColor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAltForegroundColor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAltBackgroundColor);
		
		/// <summary>
        /// resetColors() forget the customized colors which were set by setColors().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetColors();
	}
	
	/// <summary>nsISelectionPrivateConsts </summary>
	public class nsISelectionPrivateConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const short ENDOFPRECEDINGLINE = 0;
		
		// 
		public const short STARTOFNEXTLINE = 1;
		
		// <summary>
        //Table selection stuff
        //       We should probably move this and table-related
        //       items in nsFrameSelection  to a
        //       new nsITableSelection interface
        // </summary>
		public const long TABLESELECTION_NONE = 0;
		
		// 
		public const long TABLESELECTION_CELL = 1;
		
		// 
		public const long TABLESELECTION_ROW = 2;
		
		// 
		public const long TABLESELECTION_COLUMN = 3;
		
		// 
		public const long TABLESELECTION_TABLE = 4;
		
		// 
		public const long TABLESELECTION_ALLCELLS = 5;
	}
}
