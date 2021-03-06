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
// Generated by IDLImporter from file nsIPresentationListener.idl
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
	[Guid("0105f837-4279-4715-9d5b-2dc3f8b65353")]
	public interface nsIPresentationAvailabilityListener
	{
		
		/// <summary>
        /// Called when device availability changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyAvailableChange(nsISupports urls, [MarshalAs(UnmanagedType.U1)] bool available);
	}
	
	/// <summary>nsIPresentationSessionListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7dd48df8-8f8c-48c7-ac37-7b9fd1acf2f8")]
	public interface nsIPresentationSessionListener
	{
		
		/// <summary>
        /// Called when session state changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStateChange([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sessionId, ushort state, int reason);
		
		/// <summary>
        /// Called when receive messages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sessionId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data, [MarshalAs(UnmanagedType.U1)] bool isBinary);
	}
	
	/// <summary>nsIPresentationSessionListenerConsts </summary>
	public class nsIPresentationSessionListenerConsts
	{
		
		// 
		public const ushort STATE_CONNECTING = 0;
		
		// 
		public const ushort STATE_CONNECTED = 1;
		
		// 
		public const ushort STATE_CLOSED = 2;
		
		// 
		public const ushort STATE_TERMINATED = 3;
	}
	
	/// <summary>nsIPresentationRespondingListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("27f101d7-9ed1-429e-b4f8-43b00e8e111c")]
	public interface nsIPresentationRespondingListener
	{
		
		/// <summary>
        /// Called when an incoming session connects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySessionConnect(ulong windowId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sessionId);
	}
}
