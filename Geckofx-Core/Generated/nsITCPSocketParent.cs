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
// Generated by IDLImporter from file nsITCPSocketParent.idl
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
    /// to talk to the parent IPC actor
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4e7246c6-a8b3-426d-9c17-76dab1e1e14a")]
	public interface nsITCPSocketParent
	{
		
		/// <summary>
        /// to talk to the parent IPC actor
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitJS(Gecko.JsVal intermediary, System.IntPtr jsContext);
		
		/// <summary>
        /// with the given values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendCallback([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type, Gecko.JsVal data, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase readyState, uint bufferedAmount, System.IntPtr jsContext);
	}
	
	/// <summary>
    /// and kicking off the chrome process socket object's connection.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("afa42841-a6cb-4a91-912f-93099f6a3d18")]
	public interface nsITCPSocketIntermediary
	{
		
		/// <summary>
        /// Open the connection to the server with the given parameters
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPSocket Open([MarshalAs(UnmanagedType.Interface)] nsITCPSocketParent parent, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase host, ushort port, [MarshalAs(UnmanagedType.U1)] bool useSSL, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase binaryType);
		
		/// <summary>
        /// Send a basic string along the connection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		/// <summary>
        /// Send a typed array
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendArrayBuffer(Gecko.JsVal data);
	}
}