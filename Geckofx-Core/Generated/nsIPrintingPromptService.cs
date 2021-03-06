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
// Generated by IDLImporter from file nsIPrintingPromptService.idl
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
    ///Doc interface here </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("72006d06-a2a5-4250-ae92-04b2f0e2ab8d")]
	public interface nsIPrintingPromptService
	{
		
		/// <summary>
        /// Show the Print Dialog
        ///
        /// @param parent - a DOM windows the dialog will be parented to (required)
        /// @param webBrowserPrint - represents the document to be printed (required)
        /// @param printSettings - PrintSettings for print "job" (required)
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrintDialog(mozIDOMWindowProxy parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);
		
		/// <summary>
        /// Shows the print progress dialog
        ///
        /// @param parent - a DOM windows the dialog will be parented to
        /// @param webBrowserPrint - represents the document to be printed
        /// @param printSettings - PrintSettings for print "job"
        /// @param openDialogObserver - an observer that will be notifed when the dialog is opened
        /// @param isForPrinting - true - for printing, false for print preview
        /// @param webProgressListener - additional listener can be registered for progress notifications
        /// @param printProgressParams - parameter object for passing progress state
        /// @param notifyOnOpen - this indicates that the observer will be notified when the progress
        /// dialog has been opened. If false is returned it means the observer
        /// (usually the caller) shouldn't wait
        /// For Print Preview Progress there is intermediate progress
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowProgress(mozIDOMWindowProxy parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver openDialogObserver, [MarshalAs(UnmanagedType.U1)] bool isForPrinting, [MarshalAs(UnmanagedType.Interface)] ref nsIWebProgressListener webProgressListener, [MarshalAs(UnmanagedType.Interface)] ref nsIPrintProgressParams printProgressParams, [MarshalAs(UnmanagedType.U1)] ref bool notifyOnOpen);
		
		/// <summary>
        /// Shows the print progress dialog
        ///
        /// @param parent - a DOM windows the dialog will be parented to (required)
        /// @param printSettings - PrintSettings for page setup (required)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPageSetup(mozIDOMWindowProxy parent, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);
	}
}
