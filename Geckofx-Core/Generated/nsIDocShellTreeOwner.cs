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
// Generated by IDLImporter from file nsIDocShellTreeOwner.idl
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
    /// The nsIDocShellTreeOwner
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0e3dc4b1-4cea-4a37-af71-79f0afd07574")]
	public interface nsIDocShellTreeOwner
	{
		
		/// <summary>
        /// Called when a content shell is added to the docshell tree.  This is
        /// _only_ called for "root" content shells (that is, ones whose parent is a
        /// chrome shell).
        ///
        /// @param aContentShell the shell being added.
        /// @param aPrimary whether the shell is primary.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ContentShellAdded([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aContentShell, [MarshalAs(UnmanagedType.U1)] bool aPrimary);
		
		/// <summary>
        /// Called when a content shell is removed from the docshell tree.  This is
        /// _only_ called for "root" content shells (that is, ones whose parent is a
        /// chrome shell).  Note that if aContentShell was never added,
        /// contentShellRemoved should just do nothing.
        ///
        /// @param aContentShell the shell being removed.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ContentShellRemoved([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aContentShell);
		
		/// <summary>
        ///Returns the Primary Content Shell
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetPrimaryContentShellAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TabParentAdded([MarshalAs(UnmanagedType.Interface)] nsITabParent aTab, [MarshalAs(UnmanagedType.U1)] bool aPrimary);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TabParentRemoved([MarshalAs(UnmanagedType.Interface)] nsITabParent aTab);
		
		/// <summary>
        ///In multiprocess case we may not have primaryContentShell but
        ///	primaryTabParent.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITabParent GetPrimaryTabParentAttribute();
		
		/// <summary>
        ///Tells the tree owner to size its window or parent window in such a way
        ///	that the shell passed along will be the size specified.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeShellTo([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem shell, int cx, int cy);
		
		/// <summary>
        ///Gets the size of the primary content area in CSS pixels. This should work
        ///	for both in-process and out-of-process content areas.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrimaryContentSize(ref int width, ref int height);
		
		/// <summary>
        ///Sets the size of the primary content area in CSS pixels. This should work
        ///	for both in-process and out-of-process content areas.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrimaryContentSize(int width, int height);
		
		/// <summary>
        ///Gets the size of the root docshell in CSS pixels.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRootShellSize(ref int width, ref int height);
		
		/// <summary>
        ///Sets the size of the root docshell in CSS pixels.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRootShellSize(int width, int height);
		
		/// <summary>
        ///Sets the persistence of different attributes of the window.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistence([MarshalAs(UnmanagedType.U1)] bool aPersistPosition, [MarshalAs(UnmanagedType.U1)] bool aPersistSize, [MarshalAs(UnmanagedType.U1)] bool aPersistSizeMode);
		
		/// <summary>
        ///Gets the current persistence states of the window.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPersistence([MarshalAs(UnmanagedType.U1)] ref bool aPersistPosition, [MarshalAs(UnmanagedType.U1)] ref bool aPersistSize, [MarshalAs(UnmanagedType.U1)] ref bool aPersistSizeMode);
		
		/// <summary>
        ///Gets the number of tabs currently open in our window, assuming
        ///	this tree owner has such a concept.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTabCountAttribute();
		
		/// <summary>
        ///Returns true if there is a primary content shell or a primary
        ///	tab parent.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasPrimaryContentAttribute();
	}
}
