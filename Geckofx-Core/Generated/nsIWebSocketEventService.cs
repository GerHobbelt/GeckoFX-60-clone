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
// Generated by IDLImporter from file nsIWebSocketEventService.idl
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
	[Guid("6714a6be-2265-4f73-a988-d78a12416037")]
	public interface nsIWebSocketFrame
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		DOMHighResTimeStamp GetTimeStampAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFinBitAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRsvBit1Attribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRsvBit2Attribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRsvBit3Attribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetOpCodeAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMaskBitAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMaskAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPayloadAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPayload);
	}
	
	/// <summary>nsIWebSocketFrameConsts </summary>
	public class nsIWebSocketFrameConsts
	{
		
		// <summary>
        // Non-Control opCode values:
        // </summary>
		public const ushort OPCODE_CONTINUATION = 0x0;
		
		// 
		public const ushort OPCODE_TEXT = 0x1;
		
		// 
		public const ushort OPCODE_BINARY = 0x2;
		
		// <summary>
        // Control opCode values:
        // </summary>
		public const ushort OPCODE_CLOSE = 0x8;
		
		// 
		public const ushort OPCODE_PING = 0x9;
		
		// 
		public const ushort OPCODE_PONG = 0xA;
	}
	
	/// <summary>nsIWebSocketEventListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e7c005ab-e694-489b-b741-96db43ffb16f")]
	public interface nsIWebSocketEventListener
	{
		
		/// <summary>Member WebSocketCreated </summary>
		/// <param name='aWebSocketSerialID'> </param>
		/// <param name='aURI'> </param>
		/// <param name='aProtocols'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WebSocketCreated(uint aWebSocketSerialID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocols);
		
		/// <summary>Member WebSocketOpened </summary>
		/// <param name='aWebSocketSerialID'> </param>
		/// <param name='aEffectiveURI'> </param>
		/// <param name='aProtocols'> </param>
		/// <param name='aExtensions'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WebSocketOpened(uint aWebSocketSerialID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEffectiveURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProtocols, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aExtensions);
		
		/// <summary>Member WebSocketMessageAvailable </summary>
		/// <param name='aWebSocketSerialID'> </param>
		/// <param name='aMessage'> </param>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WebSocketMessageAvailable(uint aWebSocketSerialID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMessage, ushort aType);
		
		/// <summary>Member WebSocketClosed </summary>
		/// <param name='aWebSocketSerialID'> </param>
		/// <param name='aWasClean'> </param>
		/// <param name='aCode'> </param>
		/// <param name='aReason'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WebSocketClosed(uint aWebSocketSerialID, [MarshalAs(UnmanagedType.U1)] bool aWasClean, ushort aCode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReason);
		
		/// <summary>Member FrameReceived </summary>
		/// <param name='aWebSocketSerialID'> </param>
		/// <param name='aFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FrameReceived(uint aWebSocketSerialID, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketFrame aFrame);
		
		/// <summary>Member FrameSent </summary>
		/// <param name='aWebSocketSerialID'> </param>
		/// <param name='aFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FrameSent(uint aWebSocketSerialID, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketFrame aFrame);
	}
	
	/// <summary>nsIWebSocketEventListenerConsts </summary>
	public class nsIWebSocketEventListenerConsts
	{
		
		// 
		public const ushort TYPE_STRING = 0x0;
		
		// 
		public const ushort TYPE_BLOB = 0x1;
		
		// 
		public const ushort TYPE_ARRAYBUFFER = 0x2;
	}
	
	/// <summary>nsIWebSocketEventService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b89d1b90-2cf3-4d8f-ac21-5aedfb25c760")]
	public interface nsIWebSocketEventService
	{
		
		/// <summary>Member AddListener </summary>
		/// <param name='aInnerWindowID'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener(ulong aInnerWindowID, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketEventListener aListener);
		
		/// <summary>Member RemoveListener </summary>
		/// <param name='aInnerWindowID'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener(ulong aInnerWindowID, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketEventListener aListener);
		
		/// <summary>Member HasListenerFor </summary>
		/// <param name='aInnerWindowID'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasListenerFor(ulong aInnerWindowID);
	}
}
