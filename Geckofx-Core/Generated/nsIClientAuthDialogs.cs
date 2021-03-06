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
// Generated by IDLImporter from file nsIClientAuthDialogs.idl
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
    /// Provides UI for SSL client-auth dialogs.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fa4c7520-1433-11d5-ba24-00108303b117")]
	public interface nsIClientAuthDialogs
	{
		
		/// <summary>
        /// Called when a user is asked to choose a certificate for client auth.
        ///
        /// @param ctx Context that allows at least nsIClientAuthUserDecision to be
        /// queried.
        /// @param hostname Hostname of the server.
        /// @param port Port of the server.
        /// @param organization Organization field of the server cert.
        /// @param issuerOrg Organization field of the issuer cert of the server cert.
        /// @param certList List of certificates the user can choose from.
        /// @param selectedIndex Index of the cert in |certList| that the user chose.
        /// Ignored if the return value is false.
        /// @return true if a certificate was chosen. false if the user canceled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ChooseCertificate([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor ctx, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase hostname, int port, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase organization, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase issuerOrg, [MarshalAs(UnmanagedType.Interface)] nsIArray certList, ref uint selectedIndex);
	}
	
	/// <summary>nsIClientAuthUserDecision </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("95c4373e-bdd4-4a63-b431-f5b000367721")]
	public interface nsIClientAuthUserDecision
	{
		
		/// <summary>Member GetRememberClientAuthCertificateAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRememberClientAuthCertificateAttribute();
		
		/// <summary>Member SetRememberClientAuthCertificateAttribute </summary>
		/// <param name='aRememberClientAuthCertificate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRememberClientAuthCertificateAttribute([MarshalAs(UnmanagedType.U1)] bool aRememberClientAuthCertificate);
	}
}
