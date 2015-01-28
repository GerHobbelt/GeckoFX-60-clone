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
// Generated by IDLImporter from file nsIDOMApplicationRegistry.idl
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
	[Guid("f8cb08ed-588e-465f-b2b3-a4b0afde711a")]
	public interface mozIDOMApplication
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetManifestAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetUpdateManifestAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetManifestURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aManifestURL);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetReceiptsAttribute();
		
		/// <summary>
        ///an array of strings </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aOrigin);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInstallOriginAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInstallOrigin);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetInstallTimeAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRemovableAttribute();
		
		/// <summary>
        /// The current progress when downloading an offline cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetProgressAttribute();
		
		/// <summary>
        /// The application installation state :
        /// "pending"   : The application is being installed (eg, we're downloading the
        /// offline cache or the package).
        /// "installed" : The application is installed and ready to be launched.
        /// "updating"  : We are updating the offline-cache or the package.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInstallStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInstallState);
		
		/// <summary>
        /// fires a nsIDOMApplicationEvent when a change in appcache download or
        /// package download happens.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnprogressAttribute();
		
		/// <summary>
        /// fires a nsIDOMApplicationEvent when a change in appcache download or
        /// package download happens.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnprogress);
		
		/// <summary>
        /// The date of the last update check.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetLastUpdateCheckAttribute();
		
		/// <summary>
        /// The date of the last updated manifest.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetUpdateTimeAttribute();
		
		/// <summary>
        /// Starts the process of looking for an update.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest CheckForUpdate();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDownloadAvailableAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDownloadingAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReadyToApplyDownloadAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDownloadSizeAttribute();
		
		/// <summary>
        /// This is a DOMError
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetDownloadErrorAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndownloadsuccessAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndownloadsuccessAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndownloadsuccess);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndownloaderrorAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndownloaderrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndownloaderror);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndownloadavailableAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndownloadavailableAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndownloadavailable);
		
		/// <summary>
        /// Will fire once the mgmt.applyDownload() call succeeds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndownloadappliedAttribute();
		
		/// <summary>
        /// Will fire once the mgmt.applyDownload() call succeeds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndownloadappliedAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndownloadapplied);
		
		/// <summary>
        /// Starts to download an update. If |downloading| is true, this
        /// is a no-op.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Download();
		
		/// <summary>
        /// Cancels an ongoing update download.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelDownload();
		
		/// <summary>
        ///startPoint will be used when several launch_path exists for an app </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest Launch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase startPoint);
		
		/// <summary>
        /// Clear data that has been collected through mozbrowser elements.
        /// onsuccess will be called once data is actually cleared.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest ClearBrowserData();
		
		/// <summary>
        /// Inter-App Communication APIs.
        ///
        /// https://wiki.mozilla.org/WebAPI/Inter_App_Communication_Alt_proposal
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports Connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase keyword, ref Gecko.JsVal rules);
		
		/// <summary>
        /// nsISupports is a Promise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetConnections();
		
		/// <summary>
        ///Receipts handling functions </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest AddReceipt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase receipt);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest RemoveReceipt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase receipt);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest ReplaceReceipt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase oldReceipt, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newReceipt);
	}
	
	/// <summary>mozIDOMApplicationMgmt </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf742022-5ba3-11e2-868f-03310341b006")]
	public interface mozIDOMApplicationMgmt
	{
		
		/// <summary>
        /// the request will return the all the applications installed. Only accessible
        /// to privileged callers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetAll();
		
		/// <summary>
        /// the request will return the applications acquired from all origins but
        /// which are not launchable (e.g. by not being natively installed), or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetNotInstalled();
		
		/// <summary>
        /// event listener to get notified of application installs. Only settable by
        /// privileged callers.
        /// the event will be a mozIDOMApplicationEvent
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOninstallAttribute();
		
		/// <summary>
        /// event listener to get notified of application installs. Only settable by
        /// privileged callers.
        /// the event will be a mozIDOMApplicationEvent
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOninstallAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOninstall);
		
		/// <summary>
        /// event listener to get notified of application uninstalls. Only settable by
        /// privileged callers.
        /// the event will be a mozIDOMApplicationEvent
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnuninstallAttribute();
		
		/// <summary>
        /// event listener to get notified of application uninstalls. Only settable by
        /// privileged callers.
        /// the event will be a mozIDOMApplicationEvent
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnuninstallAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnuninstall);
		
		/// <summary>
        /// Applies a downloaded update.
        /// This function is a no-op if it's passed an app object which doesn't have
        /// |readyToApplyDownload| set to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ApplyDownload(mozIDOMApplication app);
		
		/// <summary>
        /// Uninstall a web app.
        ///
        /// @param app : the app object of the web app to be uninstalled.
        /// @returns   : A DOMRequest object, returning the app's origin in |result|
        /// if uninstall succeeds; returning "NOT_INSTALLED" error otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest Uninstall(mozIDOMApplication app);
	}
	
	/// <summary>mozIDOMApplicationRegistry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("52710c5f-b2a2-4b27-b5b9-f679a1bcc79b")]
	public interface mozIDOMApplicationRegistry
	{
		
		/// <summary>
        /// Install a web app.
        ///
        /// @param manifestUrl : the URL of the webapps manifest.
        /// @param parameters  : A structure with optional information.
        /// {
        /// receipts: ...    Will be used to specify the payment receipts for this installation.
        /// categories: ...  Will be used to specify the categories of the webapp.
        /// }
        /// @returns           : A DOMRequest object, returning the app object in |result| if install succeeds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest Install([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase manifestUrl, ref Gecko.JsVal parameters);
		
		/// <summary>
        /// the request will return the application currently installed, or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetSelf();
		
		/// <summary>
        /// the request will return the application if the app from that origin is installed
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest CheckInstalled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase manifestUrl);
		
		/// <summary>
        /// the request will return the applications installed from this origin, or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetInstalled();
		
		/// <summary>
        /// Install a packaged web app.
        ///
        /// @param packageUrl : the URL of the webapps manifest.
        /// @param parameters : A structure with optional information.
        /// {
        /// receipts: ...    Will be used to specify the payment receipts for this installation.
        /// categories: ...  Will be used to specify the categories of the webapp.
        /// }
        /// @returns          : A DOMRequest object, returning the app object in |result| if install succeeds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest InstallPackage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase packageUrl, ref Gecko.JsVal parameters);
		
		/// <summary>Member GetMgmtAttribute </summary>
		/// <returns>A mozIDOMApplicationMgmt</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIDOMApplicationMgmt GetMgmtAttribute();
	}
}
