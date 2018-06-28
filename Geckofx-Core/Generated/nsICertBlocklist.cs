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
// Generated by IDLImporter from file nsICertBlocklist.idl
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
    /// Represents a service to add certificates as explicitly blocked/distrusted.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0654480-f433-11e4-b939-0800200c9a66")]
	public interface nsICertBlocklist
	{
		
		/// <summary>
        /// Add details of a revoked certificate :
        /// issuer name (base-64 encoded DER) and serial number (base-64 encoded DER).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RevokeCertByIssuerAndSerial([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase issuer, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase serialNumber);
		
		/// <summary>
        /// Add details of a revoked certificate :
        /// subject name (base-64 encoded DER) and hash of public key (base-64 encoded
        /// sha-256 hash of the public key).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RevokeCertBySubjectAndPubKey([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase subject, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase pubKeyHash);
		
		/// <summary>
        /// Persist (fresh) blocklist entries to the profile (if a profile directory is
        /// available). Note: calling this will result in synchronous I/O.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveEntries();
		
		/// <summary>
        /// Check if a certificate is blocked.
        /// issuer - issuer name, DER encoded
        /// serial - serial number, DER encoded
        /// subject - subject name, DER encoded
        /// pubkey - public key, DER encoded
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCertRevoked([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] issuer, uint issuer_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] byte[] serial, uint serial_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=5)] byte[] subject, uint subject_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=7)] byte[] pubkey, uint pubkey_length);
		
		/// <summary>
        /// Check that the blocklist data is current. Specifically, that the current
        /// time is no more than security.onecrl.maximum_staleness_in_seconds seconds
        /// after the last blocklist update (as stored in the
        /// app.update.lastUpdateTime.blocklist-background-update-timer pref)
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsBlocklistFresh();
	}
}
