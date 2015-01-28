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
// Generated by IDLImporter from file nsISettingsService.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aad47850-2e87-11e2-81c1-0800200c9a66")]
	public interface nsISettingsServiceCallback
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, Gecko.JsVal aResult);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aErrorMessage);
	}
	
	/// <summary>nsISettingsTransactionCompleteCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f1b3d820-8e75-11e3-baa8-0800200c9a66")]
	public interface nsISettingsTransactionCompleteCallback
	{
		
		/// <summary>Member Handle </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle();
		
		/// <summary>Member HandleAbort </summary>
		/// <param name='aErrorMessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleAbort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aErrorMessage);
	}
	
	/// <summary>nsISettingsServiceLock </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d7a395a0-e292-11e1-834e-1761d57f5f99")]
	public interface nsISettingsServiceLock
	{
		
		/// <summary>Member Set </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aCallback'> </param>
		/// <param name='aMessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Set([MarshalAs(UnmanagedType.LPStr)] string aName, Gecko.JsVal aValue, [MarshalAs(UnmanagedType.Interface)] nsISettingsServiceCallback aCallback, [MarshalAs(UnmanagedType.LPStr)] string aMessage);
		
		/// <summary>Member Get </summary>
		/// <param name='aName'> </param>
		/// <param name='aCallback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Get([MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.Interface)] nsISettingsServiceCallback aCallback);
	}
	
	/// <summary>nsISettingsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0505acf0-8e76-11e3-baa8-0800200c9a66")]
	public interface nsISettingsService
	{
		
		/// <summary>Member CreateLock </summary>
		/// <param name='aCallback'> </param>
		/// <returns>A nsISettingsServiceLock</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISettingsServiceLock CreateLock([MarshalAs(UnmanagedType.Interface)] nsISettingsTransactionCompleteCallback aCallback);
	}
}
