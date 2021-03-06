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
// Generated by IDLImporter from file nsIDivertableChannel.idl
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
    /// A channel implementing this interface allows diverting from an
    /// nsIStreamListener in the child process to one in the parent.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7a9bf52d-f828-4b31-b8df-b40fdd37d007")]
	public interface nsIDivertableChannel
	{
		
		/// <summary>
        /// CHILD ONLY.
        /// Called by Necko client in child process during OnStartRequest to divert
        /// nsIStreamListener and nsIRequest callbacks to the parent process.
        ///
        /// The process should look like the following:
        ///
        /// 1) divertToParent is called in the child process.  It can only be called
        /// during OnStartRequest().
        ///
        /// 2) The /* ChannelDiverterChild */ nsISupports that is returned is an IPDL object. It should
        /// be passed via some other IPDL method of the client's choosing to the
        /// parent.  On the parent the ChannelDiverterParent's divertTo() function
        /// should be called with an nsIStreamListener that will then receive the
        /// OnStartRequest/OnDataAvailable/OnStopRequest for the channel.  The
        /// ChannelDiverterParent can then be deleted (which will also destroy the
        /// /* ChannelDiverterChild */ nsISupports in the child).
        ///
        /// After divertToParent() has been called, NO further function calls
        /// should be made on the channel.  It is a dead object for all purposes.
        /// The reference that the channel holds to the listener in the child is
        /// released is once OnStartRequest completes, and no other
        /// nsIStreamListener calls (OnDataAvailable, OnStopRequest) will be made
        /// to it.
        ///
        /// @return /* ChannelDiverterChild */ nsISupports IPDL actor to be passed to parent process by
        /// client IPDL message, e.g. PClient.DivertUsing(PDiverterChild).
        ///
        /// @throws exception if the channel was canceled early. Throws status code of
        /// canceled channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		/* ChannelDiverterChild */ nsISupports DivertToParent();
		
		/// <summary>
        /// nsUnknownDecoder delays calling OnStartRequest until it gets enough data
        /// to decide about the content type (until OnDataAvaiable is called). In a
        /// OnStartRequest DivertToParent can be called but some OnDataAvailables are
        /// already called and therefore can not be diverted to parent.
        ///
        /// nsUnknownDecoder will call UnknownDecoderInvolvedKeepData in its
        /// OnStartRequest function and when it calls OnStartRequest of the next
        /// listener it will call UnknownDecoderInvolvedOnStartRequestCalled. In this
        /// function Child process will decide to discarge data if it is not diverting
        /// to parent or keep them if it is diverting to parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnknownDecoderInvolvedKeepData();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnknownDecoderInvolvedOnStartRequestCalled();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDivertingToParentAttribute();
	}
}
