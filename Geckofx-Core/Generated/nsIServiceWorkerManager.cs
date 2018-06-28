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
// Generated by IDLImporter from file nsIServiceWorkerManager.idl
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
	[Guid("52ee2c9d-ee87-4caf-9588-23ae77ff8798")]
	public interface nsIServiceWorkerUnregisterCallback
	{
		
		/// <summary>
        /// It's false if this ServiceWorkerRegistration doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterSucceeded([MarshalAs(UnmanagedType.U1)] bool aState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFailed();
	}
	
	/// <summary>nsIServiceWorkerInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("76e357ed-208d-4e4c-9165-1c4059707879")]
	public interface nsIServiceWorkerInfo
	{
		
		/// <summary>Member GetScriptSpecAttribute </summary>
		/// <param name='aScriptSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScriptSpecAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScriptSpec);
		
		/// <summary>Member GetCacheNameAttribute </summary>
		/// <param name='aCacheName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCacheNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCacheName);
		
		/// <summary>Member GetStateAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetStateAttribute();
		
		/// <summary>Member GetDebuggerAttribute </summary>
		/// <returns>A nsIWorkerDebugger</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWorkerDebugger GetDebuggerAttribute();
		
		/// <summary>Member GetHandlesFetchEventsAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHandlesFetchEventsAttribute();
		
		/// <summary>Member GetInstalledTimeAttribute </summary>
		/// <returns>A System.Int64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetInstalledTimeAttribute();
		
		/// <summary>Member GetActivatedTimeAttribute </summary>
		/// <returns>A System.Int64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetActivatedTimeAttribute();
		
		/// <summary>Member GetRedundantTimeAttribute </summary>
		/// <returns>A System.Int64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetRedundantTimeAttribute();
		
		/// <summary>Member AttachDebugger </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AttachDebugger();
		
		/// <summary>Member DetachDebugger </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DetachDebugger();
	}
	
	/// <summary>nsIServiceWorkerInfoConsts </summary>
	public class nsIServiceWorkerInfoConsts
	{
		
		// <summary>
        // State values below should match the ServiceWorkerState enumeration.
        // </summary>
		public const ushort STATE_PARSED = 0;
		
		// 
		public const ushort STATE_INSTALLING = 1;
		
		// 
		public const ushort STATE_INSTALLED = 2;
		
		// 
		public const ushort STATE_ACTIVATING = 3;
		
		// 
		public const ushort STATE_ACTIVATED = 4;
		
		// 
		public const ushort STATE_REDUNDANT = 5;
		
		// 
		public const ushort STATE_UNKNOWN = 6;
	}
	
	/// <summary>nsIServiceWorkerRegistrationInfoListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("87e63548-d440-4b8a-b158-65ad1de0211E")]
	public interface nsIServiceWorkerRegistrationInfoListener
	{
		
		/// <summary>Member OnChange </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnChange();
	}
	
	/// <summary>nsIServiceWorkerRegistrationInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ddbc1fd4-2f2e-4fca-a395-6e010bbedfe3")]
	public interface nsIServiceWorkerRegistrationInfo
	{
		
		/// <summary>Member GetPrincipalAttribute </summary>
		/// <returns>A nsIPrincipal</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetPrincipalAttribute();
		
		/// <summary>Member GetScopeAttribute </summary>
		/// <param name='aScope'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScopeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);
		
		/// <summary>Member GetScriptSpecAttribute </summary>
		/// <param name='aScriptSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScriptSpecAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScriptSpec);
		
		/// <summary>Member GetUpdateViaCacheAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetUpdateViaCacheAttribute();
		
		/// <summary>Member GetLastUpdateTimeAttribute </summary>
		/// <returns>A System.Int64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastUpdateTimeAttribute();
		
		/// <summary>Member GetInstallingWorkerAttribute </summary>
		/// <returns>A nsIServiceWorkerInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIServiceWorkerInfo GetInstallingWorkerAttribute();
		
		/// <summary>Member GetWaitingWorkerAttribute </summary>
		/// <returns>A nsIServiceWorkerInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIServiceWorkerInfo GetWaitingWorkerAttribute();
		
		/// <summary>Member GetActiveWorkerAttribute </summary>
		/// <returns>A nsIServiceWorkerInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIServiceWorkerInfo GetActiveWorkerAttribute();
		
		/// <summary>
        /// null if the service worker is no longer registered.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIServiceWorkerInfo GetWorkerByID(ulong aID);
		
		/// <summary>Member AddListener </summary>
		/// <param name='listener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerRegistrationInfoListener listener);
		
		/// <summary>Member RemoveListener </summary>
		/// <param name='listener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerRegistrationInfoListener listener);
	}
	
	/// <summary>nsIServiceWorkerRegistrationInfoConsts </summary>
	public class nsIServiceWorkerRegistrationInfoConsts
	{
		
		// <summary>
        // State values below should match the ServiceWorkerUpdateViaCache enumeration.
        // </summary>
		public const ushort UPDATE_VIA_CACHE_IMPORTS = 0;
		
		// 
		public const ushort UPDATE_VIA_CACHE_ALL = 1;
		
		// 
		public const ushort UPDATE_VIA_CACHE_NONE = 2;
	}
	
	/// <summary>nsIServiceWorkerManagerListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9e523e7c-ad6f-4df0-8077-c74aebbc679d")]
	public interface nsIServiceWorkerManagerListener
	{
		
		/// <summary>Member OnRegister </summary>
		/// <param name='aInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnRegister([MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerRegistrationInfo aInfo);
		
		/// <summary>Member OnUnregister </summary>
		/// <param name='aInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnUnregister([MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerRegistrationInfo aInfo);
	}
	
	/// <summary>nsIServiceWorkerManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7404c8e8-4d47-4449-8ed1-47d1261d4e33")]
	public interface nsIServiceWorkerManager
	{
		
		/// <summary>
        /// Registers a ServiceWorker with script loaded from `aScriptURI` to act as
        /// the ServiceWorker for aScope.  Requires a valid entry settings object on
        /// the stack. This means you must call this from content code 'within'
        /// a window.
        ///
        /// Returns a Promise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports Register(mozIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aScope, [MarshalAs(UnmanagedType.Interface)] nsIURI aScriptURI, ushort aUpdateViaCache);
		
		/// <summary>
        /// Unregister an existing ServiceWorker registration for `aScope`.
        /// It keeps aCallback alive until the operation is concluded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unregister([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerUnregisterCallback aCallback, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);
		
		/// <summary>
        /// Returns a Promise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetRegistrations(mozIDOMWindow aWindow);
		
		/// <summary>
        /// Returns a Promise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetRegistration(mozIDOMWindow aWindow, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);
		
		/// <summary>
        /// Returns a Promise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetReadyPromise(mozIDOMWindow aWindow);
		
		/// <summary>
        /// Remove ready pending Promise
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveReadyPromise(mozIDOMWindow aWindow);
		
		/// <summary>Member GetRegistrationByPrincipal </summary>
		/// <param name='aPrincipal'> </param>
		/// <param name='aScope'> </param>
		/// <returns>A nsIServiceWorkerRegistrationInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIServiceWorkerRegistrationInfo GetRegistrationByPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);
		
		/// <summary>Member StartControlling </summary>
		/// <param name='aClientInfo'> </param>
		/// <param name='aServiceWorker'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool StartControlling(nsISupports aClientInfo, nsISupports aServiceWorker);
		
		/// <summary>
        /// Clears ServiceWorker registrations from memory and disk for the specified
        /// host.
        /// - All ServiceWorker instances change their state to redundant.
        /// - Existing ServiceWorker instances handling fetches will keep running.
        /// - All documents will immediately stop being controlled.
        /// - Unregister jobs will be queued for all registrations.
        /// This eventually results in the registration being deleted from disk too.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAndPropagate([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>
        /// Testing
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScopeForUrl([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// It returns an array of nsIServiceWorkerRegistrationInfos.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetAllRegistrations();
		
		/// <summary>
        /// It calls softUpdate() for each child process.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PropagateSoftUpdate(ref Gecko.JsVal aOriginAttributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope, System.IntPtr jsContext);
		
		/// <summary>
        /// inform when unregister() is completed on the current process.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PropagateUnregister([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerUnregisterCallback aCallback, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aScope);
		
		/// <summary>Member SendNotificationClickEvent </summary>
		/// <param name='aOriginSuffix'> </param>
		/// <param name='scope'> </param>
		/// <param name='aID'> </param>
		/// <param name='aTitle'> </param>
		/// <param name='aDir'> </param>
		/// <param name='aLang'> </param>
		/// <param name='aBody'> </param>
		/// <param name='aTag'> </param>
		/// <param name='aIcon'> </param>
		/// <param name='aData'> </param>
		/// <param name='aBehavior'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendNotificationClickEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginSuffix, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase scope, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBody, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIcon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBehavior);
		
		/// <summary>Member SendNotificationCloseEvent </summary>
		/// <param name='aOriginSuffix'> </param>
		/// <param name='scope'> </param>
		/// <param name='aID'> </param>
		/// <param name='aTitle'> </param>
		/// <param name='aDir'> </param>
		/// <param name='aLang'> </param>
		/// <param name='aBody'> </param>
		/// <param name='aTag'> </param>
		/// <param name='aIcon'> </param>
		/// <param name='aData'> </param>
		/// <param name='aBehavior'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendNotificationCloseEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginSuffix, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase scope, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBody, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIcon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBehavior);
		
		/// <summary>Member SendPushEvent </summary>
		/// <param name='aOriginAttributes'> </param>
		/// <param name='aScope'> </param>
		/// <param name='aDataLength'> </param>
		/// <param name='aDataBytes'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendPushEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginAttributes, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScope, uint aDataLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aDataBytes, int argc);
		
		/// <summary>Member SendPushSubscriptionChangeEvent </summary>
		/// <param name='aOriginAttributes'> </param>
		/// <param name='scope'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendPushSubscriptionChangeEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginAttributes, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase scope);
		
		/// <summary>Member AddListener </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerManagerListener aListener);
		
		/// <summary>Member RemoveListener </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIServiceWorkerManagerListener aListener);
	}
}
