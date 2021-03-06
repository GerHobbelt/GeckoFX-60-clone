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
// Generated by IDLImporter from file nsIParentChannel.idl
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
    /// Implemented by chrome side of IPC protocols.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0fc4801-6030-4653-a59f-1fb282bd1a04")]
	public interface nsIParentChannel : nsIStreamListener
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, ulong aOffset, uint aCount);
		
		/// <summary>
        /// Called to set the /* HttpChannelParent */ nsISupportsListener object (optional).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentListener(System.IntPtr listener);
		
		/// <summary>
        /// Called to notify the HttpChannelChild that tracking protection was
        /// disabled for this load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyTrackingProtectionDisabled();
		
		/// <summary>
        /// Called to set matched information when URL matches SafeBrowsing list.
        /// @param aList
        /// Name of the list that matched
        /// @param aProvider
        /// Name of provider that matched
        /// @param aFullHash
        /// String represents full hash that matched
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClassifierMatchedInfo([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aList, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProvider, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFullHash);
		
		/// <summary>
        /// Called to notify the HttpChannelChild that the resource being loaded
        /// is on the tracking protection list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyTrackingResource();
		
		/// <summary>
        /// Called to invoke deletion of the IPC protocol.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Delete();
	}
}
