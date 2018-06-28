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
// Generated by IDLImporter from file nsIXULBrowserWindow.idl
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
    /// The nsIXULBrowserWindow supplies the methods that may be called from the
    /// internals of the browser area to tell the containing xul window to update
    /// its ui.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a8675fa9-c8b4-4350-9803-c38f344a9e38")]
	public interface nsIXULBrowserWindow
	{
		
		/// <summary>
        /// Sets the status according to JS' version of status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetJSStatus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase status);
		
		/// <summary>
        /// Tells the object implementing this function what link we are currently
        /// over.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOverLink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase link, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
		
		/// <summary>
        /// Determines the appropriate target for a link.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBeforeLinkTraversal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase originalTarget, [MarshalAs(UnmanagedType.Interface)] nsIURI linkURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode linkNode, [MarshalAs(UnmanagedType.U1)] bool isAppTab, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Find the initial browser of the window and set its remote attributes.
        /// This can be used to ensure that there is a browser in a new window of the
        /// correct type when it first spawns.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceInitialBrowserRemote([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRemoteType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceInitialBrowserNonRemote(mozIDOMWindowProxy openerWindow);
		
		/// <summary>
        /// Determines whether a load should continue.
        ///
        /// @param aDocShell
        /// The docshell performing the load.
        /// @param aURI
        /// The URI being loaded.
        /// @param aReferrer
        /// The referrer of the load.
        /// @param aHasPostData
        /// True if the load which is being asked about has associated post data
        /// which would be discarded if the load was redirected across process
        /// boundaries.
        /// @param aTriggeringPrincipal
        /// The principal that initiated the load of aURI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ShouldLoadURI([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, [MarshalAs(UnmanagedType.U1)] bool aHasPostData, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal);
		
		/// <summary>
        /// Show/hide a tooltip (when the user mouses over a link, say).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowTooltip(int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tooltip, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase direction, System.IntPtr browser);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HideTooltip();
		
		/// <summary>
        /// Return the number of tabs in this window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTabCount();
		
		/// <summary>
        /// Navigate the browser to the given history index after restoring the full history
        /// from SessionStore. If the browser is currently in GroupedSHistory mode, it will
        /// be reverted to a non-grouped history mode. If a process change is required to
        /// perform the load, this will also occur.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NavigateAndRestoreByIndex([MarshalAs(UnmanagedType.Interface)] nsIBrowser aBrowser, int aIndex);
	}
}
