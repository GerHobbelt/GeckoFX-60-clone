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
// Generated by IDLImporter from file nsIAudioDeviceInfo.idl
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
	[Guid("feb979a8-f8cc-4522-9dff-6c055ca50762")]
	public interface nsIAudioDeviceInfo
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGroupIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGroupId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVendorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aVendor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetStateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPreferredAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetSupportedFormatAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetDefaultFormatAttribute();
		
		/// <summary>
        /// Max number of channels: [1, 255]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaxChannelsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDefaultRateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaxRateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMinRateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaxLatencyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMinLatencyAttribute();
	}
	
	/// <summary>nsIAudioDeviceInfoConsts </summary>
	public class nsIAudioDeviceInfoConsts
	{
		
		// <summary>
        // type: Unknown/Input/Output
        // </summary>
		public const ushort TYPE_UNKNOWN = 0;
		
		// 
		public const ushort TYPE_INPUT = 1;
		
		// 
		public const ushort TYPE_OUTPUT = 2;
		
		// <summary>
        // state: Disabled/Unplugged/Enabled
        // </summary>
		public const ushort STATE_DISABLED = 0;
		
		// 
		public const ushort STATE_UNPLUGGED = 1;
		
		// 
		public const ushort STATE_ENABLED = 2;
		
		// <summary>
        // preferred: None/Multimedia/Voice/Notification/All
        // </summary>
		public const ushort PREF_NONE = 0x00;
		
		// 
		public const ushort PREF_MULTIMEDIA = 0x01;
		
		// 
		public const ushort PREF_VOICE = 0x02;
		
		// 
		public const ushort PREF_NOTIFICATION = 0x04;
		
		// 
		public const ushort PREF_ALL = 0x0F;
		
		// <summary>
        // supported format, default format: S16LE/S16BE/F32LE/F32BE
        // </summary>
		public const ushort FMT_S16LE = 0x0010;
		
		// 
		public const ushort FMT_S16BE = 0x0020;
		
		// 
		public const ushort FMT_F32LE = 0x1000;
		
		// 
		public const ushort FMT_F32BE = 0x2000;
	}
}
