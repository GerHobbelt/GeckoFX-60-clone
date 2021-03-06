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
// Generated by IDLImporter from file nsIPaymentUIService.idl
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
    /// nsIPaymentUIService is the interface used by Gecko to communicate with the
    /// payment UI.
    /// In general, the implementation of this interface should be a service that
    /// manages all payment UI components and receives the requested payment actions
    /// from Gecko and perform the corresponding UI behavior.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("01f8bd55-9017-438b-85ec-7c15d2b35cdc")]
	public interface nsIPaymentUIService
	{
		
		/// <summary>
        /// Show the payment UI to users.
        /// The implementation gets the payment data through nsIPaymentRequestService
        /// by the passed in requestId, then shows the payment UI and start to interact
        /// with users.
        /// According to user's action, nsIPaymentRequestService's APIs respondPayment,
        /// changeShippingAddress, or changeShippingOtpion is possible to called in the
        /// implementation.
        /// @param requestId - the request identify of the payment request.
        /// Notice that this requestId is an internal request Id
        /// generated by Gecko
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPayment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase requestId);
		
		/// <summary>
        /// Abort the payment.
        /// The implementation must abort and close the showing payment UI then call
        /// nsIPaymentRequestService respondPayment with nsIPaymentAbortActionResponse
        /// to inform Gecko of the abort status.
        /// @param requestId - the request identify of the payment request.
        /// Notice that this requestId is an internal request Id
        /// generated by Gecko
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AbortPayment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase requestId);
		
		/// <summary>
        /// Complete the payment.
        /// The implementation should close the showing payment UI, then call
        /// nsIPaymentRequestService respondPayment with nsIPaymentCompleteActionResponse
        /// to inform Gecko of the complete status.
        /// @param requestId - the request identify of the payment request.
        /// Notice that this requestId is an internal request Id
        /// generated by Gecko
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CompletePayment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase requestId);
		
		/// <summary>
        /// Update the payment data in the payment UI.
        /// The implementation should get the updated payment data through the
        /// nsIPaymentRequestService again, and update the UI.
        /// @param requestId - the request identify of the payment request.
        /// Notice that this requestId is an internal request Id
        /// generated by Gecko
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdatePayment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase requestId);
	}
}
