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
// Generated by IDLImporter from file nsIRDFPropagatableDataSource.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// An nsIRDFPropagatableDataSource provides an ability to suppress
    /// synchronization notifications.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5a9b4770-9fcb-4307-a12e-4b6708e78b97")]
	public interface nsIRDFPropagatableDataSource
	{
		
		/// <summary>
        /// Set this value to <code>true</code> to enable synchronization
        /// notifications.
        ///
        /// Set this value to <code>false</code> to disable synchronization
        /// notifications.
        ///
        /// By default, this value is <code>true</code>.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPropagateChangesAttribute();
		
		/// <summary>
        /// Set this value to <code>true</code> to enable synchronization
        /// notifications.
        ///
        /// Set this value to <code>false</code> to disable synchronization
        /// notifications.
        ///
        /// By default, this value is <code>true</code>.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPropagateChangesAttribute([MarshalAs(UnmanagedType.U1)] bool aPropagateChanges);
	}
}
