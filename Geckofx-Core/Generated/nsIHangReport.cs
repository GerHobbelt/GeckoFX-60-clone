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
// Generated by IDLImporter from file nsIHangReport.idl
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
    /// When a content process hangs, Gecko notifies "process-hang-report" observers
    /// and passes an nsIHangReport for the subject parameter. There is at most one
    /// nsIHangReport associated with a given content process. As long as the content
    /// process stays stuck, the "process-hang-report" observer will continue to be
    /// notified at regular intervals (approximately once per second). The content
    /// process will continue to run uninhibitedly during this time.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5fcffbb9-be62-49b1-b8a1-36e820787a74")]
	public interface nsIHangReport
	{
		
		/// <summary>
        /// The type of hang being reported: SLOW_SCRIPT or PLUGIN_HANG.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHangTypeAttribute();
		
		/// <summary>
        /// Only valid for SLOW_SCRIPT reports.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetScriptBrowserAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScriptFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScriptFileName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAddonIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAddonId);
		
		/// <summary>
        /// Only valid for PLUGIN_HANG reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPluginNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPluginName);
		
		/// <summary>
        /// the notification.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UserCanceled();
		
		/// <summary>
        /// Only valid for SLOW_SCRIPT reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TerminateScript();
		
		/// <summary>
        /// Only valid for SLOW_SCRIPT reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TerminateGlobal();
		
		/// <summary>
        /// Only valid for PLUGIN_HANG reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TerminatePlugin();
		
		/// <summary>
        /// Only valid for SLOW_SCRIPT reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginStartingDebugger();
		
		/// <summary>
        /// Only valid for SLOW_SCRIPT reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndStartingDebugger();
		
		/// <summary>
        /// frameloader.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsReportForBrowser(System.IntPtr aFrameLoader);
	}
	
	/// <summary>nsIHangReportConsts </summary>
	public class nsIHangReportConsts
	{
		
		// <summary>
        // When a content process hangs, Gecko notifies "process-hang-report" observers
        // and passes an nsIHangReport for the subject parameter. There is at most one
        // nsIHangReport associated with a given content process. As long as the content
        // process stays stuck, the "process-hang-report" observer will continue to be
        // notified at regular intervals (approximately once per second). The content
        // process will continue to run uninhibitedly during this time.
        // </summary>
		public const ulong SLOW_SCRIPT = 1;
		
		// 
		public const ulong PLUGIN_HANG = 2;
	}
}
