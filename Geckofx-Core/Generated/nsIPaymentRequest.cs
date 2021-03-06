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
// Generated by IDLImporter from file nsIPaymentRequest.idl
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
	[Guid("2fe296cc-d917-4820-b492-aa42df23f9b4")]
	public interface nsIPaymentMethodData
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSupportedMethodsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSupportedMethods);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetDataAttribute(System.IntPtr jsContext);
	}
	
	/// <summary>nsIPaymentCurrencyAmount </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d22a6f5f-767b-4fea-bf92-68b0b8003eba")]
	public interface nsIPaymentCurrencyAmount
	{
		
		/// <summary>Member GetCurrencyAttribute </summary>
		/// <param name='aCurrency'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCurrencyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCurrency);
		
		/// <summary>Member GetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);
	}
	
	/// <summary>nsIPaymentItem </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4f78a59f-b5ff-4fb5-ab48-3b37d0101b02")]
	public interface nsIPaymentItem
	{
		
		/// <summary>Member GetLabelAttribute </summary>
		/// <param name='aLabel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);
		
		/// <summary>Member GetAmountAttribute </summary>
		/// <returns>A nsIPaymentCurrencyAmount</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPaymentCurrencyAmount GetAmountAttribute();
		
		/// <summary>Member GetPendingAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPendingAttribute();
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
	}
	
	/// <summary>nsIPaymentDetailsModifier </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("74259861-c318-40e8-b3d5-518e701bed80")]
	public interface nsIPaymentDetailsModifier
	{
		
		/// <summary>Member GetSupportedMethodsAttribute </summary>
		/// <param name='aSupportedMethods'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSupportedMethodsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSupportedMethods);
		
		/// <summary>Member GetTotalAttribute </summary>
		/// <returns>A nsIPaymentItem</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPaymentItem GetTotalAttribute();
		
		/// <summary>Member GetAdditionalDisplayItemsAttribute </summary>
		/// <returns>A nsIArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetAdditionalDisplayItemsAttribute();
		
		/// <summary>Member GetDataAttribute </summary>
		/// <param name='jsContext'> </param>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetDataAttribute(System.IntPtr jsContext);
	}
	
	/// <summary>nsIPaymentShippingOption </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("68341551-3605-4381-b936-41e830aa88fb")]
	public interface nsIPaymentShippingOption
	{
		
		/// <summary>Member GetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		/// <summary>Member GetLabelAttribute </summary>
		/// <param name='aLabel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLabelAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLabel);
		
		/// <summary>Member GetAmountAttribute </summary>
		/// <returns>A nsIPaymentCurrencyAmount</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPaymentCurrencyAmount GetAmountAttribute();
		
		/// <summary>Member GetSelectedAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSelectedAttribute();
		
		/// <summary>Member SetSelectedAttribute </summary>
		/// <param name='aSelected'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelected);
	}
	
	/// <summary>nsIPaymentDetails </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("73a5a3f1-45b9-4605-a6e6-7aa60daa9039")]
	public interface nsIPaymentDetails
	{
		
		/// <summary>Member GetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		/// <summary>Member GetTotalItemAttribute </summary>
		/// <returns>A nsIPaymentItem</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPaymentItem GetTotalItemAttribute();
		
		/// <summary>Member GetDisplayItemsAttribute </summary>
		/// <returns>A nsIArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetDisplayItemsAttribute();
		
		/// <summary>Member GetShippingOptionsAttribute </summary>
		/// <returns>A nsIArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetShippingOptionsAttribute();
		
		/// <summary>Member GetModifiersAttribute </summary>
		/// <returns>A nsIArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetModifiersAttribute();
		
		/// <summary>Member GetErrorAttribute </summary>
		/// <param name='aError'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetErrorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aError);
		
		/// <summary>Member Update </summary>
		/// <param name='aDetails'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.Interface)] nsIPaymentDetails aDetails);
	}
	
	/// <summary>nsIPaymentOptions </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d53f9f20-138e-47cc-9fd5-db16a3f6d301")]
	public interface nsIPaymentOptions
	{
		
		/// <summary>Member GetRequestPayerNameAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRequestPayerNameAttribute();
		
		/// <summary>Member GetRequestPayerEmailAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRequestPayerEmailAttribute();
		
		/// <summary>Member GetRequestPayerPhoneAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRequestPayerPhoneAttribute();
		
		/// <summary>Member GetRequestShippingAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRequestShippingAttribute();
		
		/// <summary>Member GetShippingTypeAttribute </summary>
		/// <param name='aShippingType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetShippingTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aShippingType);
	}
	
	/// <summary>nsIPaymentRequest </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2fa36783-d684-4487-b7a8-9def6ae3128f")]
	public interface nsIPaymentRequest
	{
		
		/// <summary>Member GetTabIdAttribute </summary>
		/// <returns>A System.UInt64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTabIdAttribute();
		
		/// <summary>Member GetTopLevelPrincipalAttribute </summary>
		/// <returns>A nsIPrincipal</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetTopLevelPrincipalAttribute();
		
		/// <summary>Member GetRequestIdAttribute </summary>
		/// <param name='aRequestId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRequestId);
		
		/// <summary>Member GetPaymentMethodsAttribute </summary>
		/// <returns>A nsIArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetPaymentMethodsAttribute();
		
		/// <summary>Member GetPaymentDetailsAttribute </summary>
		/// <returns>A nsIPaymentDetails</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPaymentDetails GetPaymentDetailsAttribute();
		
		/// <summary>Member GetPaymentOptionsAttribute </summary>
		/// <returns>A nsIPaymentOptions</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPaymentOptions GetPaymentOptionsAttribute();
		
		/// <summary>Member UpdatePaymentDetails </summary>
		/// <param name='aDetails'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdatePaymentDetails([MarshalAs(UnmanagedType.Interface)] nsIPaymentDetails aDetails);
	}
}
