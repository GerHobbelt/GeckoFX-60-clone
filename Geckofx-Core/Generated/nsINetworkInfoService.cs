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
// Generated by IDLImporter from file nsINetworkInfoService.idl
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
    /// Listener for getting list of addresses.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c4bdaac1-3ab1-4fdb-9a16-17cbed794603")]
	public interface nsIListNetworkAddressesListener
	{
		
		/// <summary>
        /// Callback function that gets called by nsINetworkInfoService.listNetworkAddresses.
        /// Each address in the array is a string IP address in canonical form,
        /// e.g. 192.168.1.10, or an IPV6 address in string form.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnListedNetworkAddresses([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] string[] aAddressArray, uint aAddressArraySize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnListNetworkAddressesFailed();
	}
	
	/// <summary>
    /// Listener for getting hostname.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3ebdcb62-2df4-4042-8864-3fa81abd4693")]
	public interface nsIGetHostnameListener
	{
		
		/// <summary>
        /// Listener for getting hostname.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnGotHostname([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnGetHostnameFailed();
	}
	
	/// <summary>
    /// Service information
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("55fc8dae-4a58-4e0f-a49b-901cbabae809")]
	public interface nsINetworkInfoService
	{
		
		/// <summary>
        /// Obtain a list of local machine network addresses.  The listener object's
        /// onListedNetworkAddresses will be called with the obtained addresses.
        /// On failure, the listener object's onListNetworkAddressesFailed() will be called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ListNetworkAddresses([MarshalAs(UnmanagedType.Interface)] nsIListNetworkAddressesListener aListener);
		
		/// <summary>
        /// Obtain the hostname of the local machine.  The listener object's
        /// onGotHostname will be called with the obtained hostname.
        /// On failure, the listener object's onGetHostnameFailed() will be called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostname([MarshalAs(UnmanagedType.Interface)] nsIGetHostnameListener aListener);
	}
}