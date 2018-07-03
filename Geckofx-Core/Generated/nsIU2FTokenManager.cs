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
// Generated by IDLImporter from file nsIU2FTokenManager.idl
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
    /// nsIU2FTokenManager
    ///
    /// An interface to the U2FTokenManager singleton.
    ///
    /// This should be used only by the WebAuthn browser UI prompts.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("745e1eac-e449-4342-bca1-ee0e6ead09fc")]
	public interface nsIU2FTokenManager
	{
		
		/// <summary>
        /// Resumes the current WebAuthn/U2F transaction if that matches the given
        /// transaction ID. This is used only when direct attestation was requested
        /// and we have to wait for user input to proceed.
        ///
        /// @param aTransactionID : The ID of the transaction to resume.
        /// @param aPermitDirectAttestation : Whether direct attestation was
        /// permitted by the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeRegister(ulong aTransactionID, [MarshalAs(UnmanagedType.U1)] bool aPermitDirectAttestation);
		
		/// <summary>
        /// Cancels the current WebAuthn/U2F transaction if that matches the given
        /// transaction ID.
        ///
        /// @param aTransactionID : The ID of the transaction to cancel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(ulong aTransactionID);
	}
}
