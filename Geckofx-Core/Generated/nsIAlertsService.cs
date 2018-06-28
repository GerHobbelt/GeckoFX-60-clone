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
// Generated by IDLImporter from file nsIAlertsService.idl
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
	[Guid("a71a637d-de1d-47c6-a8d2-c60b2596f471")]
	public interface nsIAlertNotificationImageListener
	{
		
		/// <summary>
        /// Called when the image finishes loading.
        ///
        /// @param aUserData An opaque parameter passed to |loadImage|.
        /// @param aRequest  The image request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnImageReady([MarshalAs(UnmanagedType.Interface)] nsISupports aUserData, imgIRequest aRequest);
		
		/// <summary>
        /// Called if the alert doesn't have an image, or if the image request times
        /// out or fails.
        ///
        /// @param aUserData An opaque parameter passed to |loadImage|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnImageMissing([MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
	}
	
	/// <summary>nsIAlertNotification </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf2e4cb6-4b8f-4eca-aea9-d51a8f9f7a50")]
	public interface nsIAlertNotification
	{
		
		/// <summary>
        ///Initializes an alert notification. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImageURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText, [MarshalAs(UnmanagedType.U1)] bool aTextClickable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCookie, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.U1)] bool aInPrivateBrowsing, [MarshalAs(UnmanagedType.U1)] bool aRequireInteraction);
		
		/// <summary>
        /// The name of the notification. On Android, the name is hashed and used as
        /// a notification ID. Notifications will replace previous notifications with
        /// the same name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		/// <summary>
        /// A URL identifying the image to put in the alert. The OS X backend limits
        /// the amount of time it will wait for the image to load to six seconds. After
        /// that time, the alert will show without an image.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImageURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImageURL);
		
		/// <summary>
        ///The title for the alert. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);
		
		/// <summary>
        ///The contents of the alert. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);
		
		/// <summary>
        /// Controls the click behavior. If true, the alert listener will be notified
        /// when the user clicks on the alert.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetTextClickableAttribute();
		
		/// <summary>
        /// An opaque cookie that will be passed to the alert listener for each
        /// callback.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCookieAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCookie);
		
		/// <summary>
        /// Bidi override for the title and contents. Valid values are "auto", "ltr",
        /// or "rtl". Ignored if the backend doesn't support localization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDirAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDir);
		
		/// <summary>
        /// Language of the title and text. Ignored if the backend doesn't support
        /// localization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLangAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLang);
		
		/// <summary>
        /// A Base64-encoded structured clone buffer containing data associated with
        /// this alert. Only used for web notifications. Chrome callers should use a
        /// cookie instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData);
		
		/// <summary>
        /// The principal of the page that created the alert. Used for IPC security
        /// checks, and to determine whether the alert is actionable.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetPrincipalAttribute();
		
		/// <summary>
        /// The URI of the page that created the alert. |null| if the alert is not
        /// actionable.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// Controls the image loading behavior. If true, the image request will be
        /// loaded anonymously (without cookies or authorization tokens).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInPrivateBrowsingAttribute();
		
		/// <summary>
        /// Indicates that the notification should remain readily available until
        /// the user activates or dismisses the notification.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRequireInteractionAttribute();
		
		/// <summary>
        /// Indicates whether this alert should show the source string and action
        /// buttons. False for system alerts (which can omit the principal), or
        /// expanded, system, and null principals.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetActionableAttribute();
		
		/// <summary>
        /// The host and port of the originating page, or an empty string if the alert
        /// is not actionable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSourceAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSource);
		
		/// <summary>
        /// Loads the image associated with this alert.
        ///
        /// @param aTimeout  The number of milliseconds to wait before cancelling the
        /// image request. If zero, there is no timeout.
        /// @param aListener An |nsIAlertNotificationImageListener| implementation,
        /// notified when the image loads. The listener is kept alive
        /// until the request completes.
        /// @param aUserData An opaque parameter passed to the listener's methods.
        /// Not used by the libnotify backend, but the OS X backend
        /// passes the pending notification.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICancelable LoadImage(uint aTimeout, [MarshalAs(UnmanagedType.Interface)] nsIAlertNotificationImageListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
	}
	
	/// <summary>nsIAlertsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f7a36392-d98b-4141-a7d7-4e46642684e3")]
	public interface nsIAlertsService
	{
		
		/// <summary>Member ShowPersistentNotification </summary>
		/// <param name='aPersistentData'> </param>
		/// <param name='aAlert'> </param>
		/// <param name='aAlertListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPersistentNotification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPersistentData, [MarshalAs(UnmanagedType.Interface)] nsIAlertNotification aAlert, [MarshalAs(UnmanagedType.Interface)] nsIObserver aAlertListener);
		
		/// <summary>Member ShowAlert </summary>
		/// <param name='aAlert'> </param>
		/// <param name='aAlertListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAlert([MarshalAs(UnmanagedType.Interface)] nsIAlertNotification aAlert, [MarshalAs(UnmanagedType.Interface)] nsIObserver aAlertListener);
		
		/// <summary>
        /// Initializes and shows an |nsIAlertNotification| with the given parameters.
        ///
        /// @param aAlertListener Used for callbacks. May be null if the caller
        /// doesn't care about callbacks.
        /// @see nsIAlertNotification for descriptions of all other parameters.
        /// @throws NS_ERROR_NOT_AVAILABLE If the notification cannot be displayed.
        ///
        /// The following arguments will be passed to the alertListener's observe()
        /// method:
        /// subject - null
        /// topic   - "alertfinished" when the alert goes away
        /// "alertdisablecallback" when alerts should be disabled for the principal
        /// "alertsettingscallback" when alert settings should be opened
        /// "alertclickcallback" when the text is clicked
        /// "alertshow" when the alert is shown
        /// data    - the value of the cookie parameter passed to showAlertNotification.
        ///
        /// @note Depending on current circumstances (if the user's in a fullscreen
        /// application, for instance), the alert might not be displayed at all.
        /// In that case, if an alert listener is passed in it will receive the
        /// "alertfinished" notification immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAlertNotification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImageURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText, [MarshalAs(UnmanagedType.U1)] bool aTextClickable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCookie, [MarshalAs(UnmanagedType.Interface)] nsIObserver aAlertListener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLang, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.U1)] bool aInPrivateBrowsing, [MarshalAs(UnmanagedType.U1)] bool aRequireInteraction);
		
		/// <summary>
        /// Close alerts created by the service.
        ///
        /// @param aName          The name of the notification to close. If no name
        /// is provided then only a notification created with
        /// no name (if any) will be closed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloseAlert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
	}
	
	/// <summary>nsIAlertsDoNotDisturb </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c5d63e3a-259d-45a8-b964-8377967cb4d2")]
	public interface nsIAlertsDoNotDisturb
	{
		
		/// <summary>
        /// Toggles a manual Do Not Disturb mode for the service to reduce the amount
        /// of disruption that alerts cause the user.
        /// This may mean only displaying them in a notification tray/center or not
        /// displaying them at all. If a system backend already supports a similar
        /// feature controlled by the user, enabling this may not have any impact on
        /// code to show an alert. e.g. on OS X, the system will take care not
        /// disrupting a user if we simply create a notification like usual.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetManualDoNotDisturbAttribute();
		
		/// <summary>
        /// Toggles a manual Do Not Disturb mode for the service to reduce the amount
        /// of disruption that alerts cause the user.
        /// This may mean only displaying them in a notification tray/center or not
        /// displaying them at all. If a system backend already supports a similar
        /// feature controlled by the user, enabling this may not have any impact on
        /// code to show an alert. e.g. on OS X, the system will take care not
        /// disrupting a user if we simply create a notification like usual.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetManualDoNotDisturbAttribute([MarshalAs(UnmanagedType.U1)] bool aManualDoNotDisturb);
	}
	
	/// <summary>nsIAlertsIconData </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fc6d7f0a-0cf6-4268-8c71-ab640842b9b1")]
	public interface nsIAlertsIconData
	{
		
		/// <summary>
        /// Shows an alert with an icon. Web notifications use the favicon of the
        /// page that created the alert. If the favicon is not in the Places database,
        /// |aIconSize| will be zero.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAlertWithIconData([MarshalAs(UnmanagedType.Interface)] nsIAlertNotification aAlert, [MarshalAs(UnmanagedType.Interface)] nsIObserver aAlertListener, uint aIconSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aIconData);
	}
	
	/// <summary>nsIAlertsIconURI </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f3c82915-bf60-41ea-91ce-6c46b22e381a")]
	public interface nsIAlertsIconURI
	{
		
		/// <summary>
        /// Shows an alert with an icon URI. Web notifications use |moz-anno:|
        /// URIs to reference favicons from Places. If the page doesn't have a
        /// favicon, |aIconURI| will be |null|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAlertWithIconURI([MarshalAs(UnmanagedType.Interface)] nsIAlertNotification aAlert, [MarshalAs(UnmanagedType.Interface)] nsIObserver aAlertListener, [MarshalAs(UnmanagedType.Interface)] nsIURI aIconURI);
	}
}
