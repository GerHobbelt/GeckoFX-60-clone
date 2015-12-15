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
// Generated by IDLImporter from file nsIIccService.idl
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
	[Guid("71b33012-eca2-11e4-a40d-9ff040a6fe2a")]
	public interface nsIIccListener
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStkCommand([MarshalAs(UnmanagedType.Interface)] nsIStkProactiveCmd aStkProactiveCmd);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStkSessionEnd();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCardStateChanged();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyIccInfoChanged();
	}
	
	/// <summary>
    /// A callback interface for handling asynchronous response.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b7b0623f-fb2c-4cec-b0dc-00ac2fe7b296")]
	public interface nsIIccCallback
	{
		
		/// <summary>
        /// The success callback with no result required:
        /// |unlockCardLock|, |setCardLockEnabled| and |changeCardLockPassword|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySuccess();
		
		/// <summary>
        /// The success callback with boolean response:
        /// |getCardLockEnabled|, |matchMvno|, and |getServiceStateEnabled|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySuccessWithBoolean([MarshalAs(UnmanagedType.U1)] bool aResult);
		
		/// <summary>
        /// The success callback of |getCardLockRetryCount|.
        ///
        /// @param aCount
        /// The number of remaining retries. -1 if unknown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetCardLockRetryCount(int aCount);
		
		/// <summary>
        /// The success callback of |readContacts|.
        ///
        /// @param aContacts
        /// The list of contacts retrieved from ICC.
        /// @param aCount
        /// The number of contacts retrieved from ICC.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyRetrievedIccContacts([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsIIccContact[] aContacts, uint aCount);
		
		/// <summary>
        /// The success callback of |updateContact|.
        ///
        /// @param aContact
        /// The contact with the updated result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyUpdatedIccContact([MarshalAs(UnmanagedType.Interface)] nsIIccContact aContact);
		
		/// <summary>
        /// The error callback of |getCardLockEnabled|, |getCardLockRetryCount|,
        /// |matchMvno|, |getServiceStateEnabled|, |readContacts| and |updateContact|.
        ///
        /// @param aErrorMsg
        /// The error message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aErrorMsg);
		
		/// <summary>
        /// The error callback of |unlockCardLock|, |setCardLockEnabled| and
        /// |changeCardLockPassword|.
        ///
        /// @param aErrorMsg
        /// The error message.
        /// @param aRetryCount
        /// The number of remaining retries. -1 if unknown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCardLockError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aErrorMsg, int aRetryCount);
	}
	
	/// <summary>nsIIccChannelCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6136acab-b50e-494a-a86d-df392a032897")]
	public interface nsIIccChannelCallback
	{
		
		/// <summary>
        /// Callback function to notify on successfully opening a logical channel.
        ///
        /// @param channel
        /// The Channel Number/Handle that is successfully opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyOpenChannelSuccess(int channel);
		
		/// <summary>
        /// Callback function to notify on successfully closing the logical channel.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyCloseChannelSuccess();
		
		/// <summary>
        /// Callback function to notify the status of 'iccExchangeAPDU' command.
        ///
        /// @param sw1
        /// Response's First Status Byte
        /// @param sw2
        /// Response's Second Status Byte
        /// @param data
        /// Response's data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyExchangeAPDUResponse(System.IntPtr sw1, System.IntPtr sw2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase data);
		
		/// <summary>
        /// Callback function to notify error
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase error);
	}
	
	/// <summary>
    /// XPCOM Service for the selection of the ICC to be accessed.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6590a04c-9ca4-11e4-ae95-570876ecc428")]
	public interface nsIIccService
	{
		
		/// <summary>
        /// Get Icc instance with specified Service Id.
        ///
        /// @param aServiceId
        /// Started from 0 to nsIMobileConnectionService.numItems - 1;
        ///
        /// @return a nsIcc instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIcc GetIccByServiceId(uint aServiceId);
	}
	
	/// <summary>
    /// XPCOM component that provides the access to the selected ICC.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1791f102-b081-4435-8555-37eb035fa4e2")]
	public interface nsIIcc
	{
		
		/// <summary>
        /// Called to register icc-related changes.
        ///
        /// 'mobileconnection' permission is required to register.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterListener([MarshalAs(UnmanagedType.Interface)] nsIIccListener aListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterListener([MarshalAs(UnmanagedType.Interface)] nsIIccListener aListener);
		
		/// <summary>
        /// Information stored in this ICC.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIccInfo GetIccInfoAttribute();
		
		/// <summary>
        /// Indicates the state of this ICC.
        ///
        /// One of the CARD_STATE_* values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCardStateAttribute();
		
		/// <summary>
        /// IMSI of this ICC.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImsiAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImsi);
		
		/// <summary>
        /// Get the status of an ICC lock (e.g. the PIN lock).
        ///
        /// @param aLockType
        /// One of the CARD_LOCK_TYPE_* values.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifySuccessWithBoolean() if success.
        /// nsIIccCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCardLockEnabled(uint aLockType, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Unlock a card lock.
        ///
        /// @param aLockType
        /// One of the CARD_LOCK_TYPE_* values.
        /// @param aPassword
        /// The password of this lock.
        /// @param aNewPin (Optional)
        /// The new PIN to be set after PUK/PUK2 is unlock.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifySuccess() if success.
        /// nsIIccCallback::notifyCardLockError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockCardLock(uint aLockType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNewPin, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Enable/Disable a card lock.
        ///
        /// @param aLockType
        /// One of the CARD_LOCK_TYPE_* values.
        /// @param aPassword
        /// The password of this lock.
        /// @param aEnabled.
        /// True to enable the lock. False to disable, otherwise.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifySuccess() if success.
        /// nsIIccCallback::notifyCardLockError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCardLockEnabled(uint aLockType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword, [MarshalAs(UnmanagedType.U1)] bool aEnabled, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Change the password of a card lock.
        ///
        /// @param aLockType
        /// One of the CARD_LOCK_TYPE_* values.
        /// @param aPassword
        /// The password of this lock.
        /// @param aNewPassword.
        /// The new password of this lock.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifySuccess() if success.
        /// nsIIccCallback::notifyCardLockError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChangeCardLockPassword(uint aLockType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNewPassword, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Get the number of remaining tries of a lock.
        ///
        /// @param aLockType
        /// One of the CARD_LOCK_TYPE_* values.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifyGetCardLockRetryCount() if success.
        /// nsIIccCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCardLockRetryCount(uint aLockType, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Verify whether the passed data (matchData) matches with some ICC's field
        /// according to the mvno type (mvnoType).
        ///
        /// @param aMvnoType
        /// One of CARD_MVNO_TYPE_* values.
        /// @param aMvnoData
        /// Data to be compared with ICC's field.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifySuccessWithBoolean() if success.
        /// nsIIccCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MatchMvno(uint aMvnoType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMvnoData, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Retrieve the the availability of an icc service.
        ///
        /// @param aService
        /// One of CARD_SERVICE_* values.
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifySuccessWithBoolean() if success.
        /// nsIIccCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetServiceStateEnabled(uint aService, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Open Secure Card Icc communication channel
        ///
        /// @param aAid
        /// Card Application Id in this UICC.
        /// @param aCallback
        /// An instance of nsIIccChannelCallback.
        /// nsIIccChannelCallback::notifyOpenChannelSuccess() if success.
        /// nsIIccChannelCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IccOpenChannel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAid, [MarshalAs(UnmanagedType.Interface)] nsIIccChannelCallback aCallback);
		
		/// <summary>
        /// Exchange Command APDU (C-APDU) with UICC on the given logical channel.
        /// Note that 'P3' parameter could be Le/Lc depending on command APDU case.
        /// For Case 1 scenario (when only command header is present), the value
        /// of 'P3' should be set to '-1' explicitly.
        /// Refer to 3G TS 31.101 , 10.2 'Command APDU Structure' for all the cases.
        ///
        /// @param aChannel
        /// given logical channel.
        /// @param aCla
        /// APDU class.
        /// @param aIns
        /// Instruction code.
        /// @param aP1, aP2, aP3
        /// P1, P2, P3 parameters in APDU.
        /// @param aData
        /// The hex data to be sent by this PDU.
        /// @param aCallback
        /// An instance of nsIIccChannelCallback.
        /// nsIIccChannelCallback::notifyExchangeAPDUResponse() if success.
        /// nsIIccChannelCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IccExchangeAPDU(int aChannel, System.IntPtr aCla, System.IntPtr aIns, System.IntPtr aP1, System.IntPtr aP2, short aP3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aData, [MarshalAs(UnmanagedType.Interface)] nsIIccChannelCallback aCallback);
		
		/// <summary>
        /// Close Secure Card Icc communication channel
        ///
        /// @param aChannel
        /// Channel to be closed.
        /// @param aCallback
        /// An instance of nsIIccChannelCallback.
        /// nsIIccChannelCallback::notifyCloseChannelSuccess() if success.
        /// nsIIccChannelCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IccCloseChannel(int aChannel, [MarshalAs(UnmanagedType.Interface)] nsIIccChannelCallback aCallback);
		
		/// <summary>
        /// Send STK terminal response to the received proactive command.
        ///
        /// @param aCommand
        /// The received proactive command.
        /// @param aResponse
        /// The response to be reply to the card application that issues
        /// this proactive command.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkResponse([MarshalAs(UnmanagedType.Interface)] nsIStkProactiveCmd aCommand, [MarshalAs(UnmanagedType.Interface)] nsIStkTerminalResponse aResponse);
		
		/// <summary>
        /// Send envelope to notify the selected item of the main STK menu.
        ///
        /// @param aItemIdentifier
        /// The identifier of the menu item.
        /// @param aHelpRequested
        /// True if help information of the selected item is requested by
        /// the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkMenuSelection(ushort aItemIdentifier, [MarshalAs(UnmanagedType.U1)] bool aHelpRequested);
		
		/// <summary>
        /// Send envelope to notify the expiration of a requested timer.
        ///
        /// @param aTimerId
        /// The TimerId provided from previous proactive command.
        /// @param aTimerValue
        /// The real used seconds when expired.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkTimerExpiration(ushort aTimerId, uint aTimerValue);
		
		/// <summary>
        /// Send "Event Download" envelope to the ICC.
        ///
        /// @param aEvent
        /// The event that ICC listening to in STK_CMD_SET_UP_EVENT_LIST.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendStkEventDownload([MarshalAs(UnmanagedType.Interface)] nsIStkDownloadEvent aEvent);
		
		/// <summary>
        /// Read Specified type of Contact from ICC.
        ///
        /// @param aContactType
        /// One of CONTACT_TYPE_*.
        ///
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifyRetrievedIccContacts() if success.
        /// nsIIccCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadContacts(uint aContactType, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
		
		/// <summary>
        /// Update Specified type of Contact in ICC.
        ///
        /// @param aContactType
        /// One of CONTACT_TYPE_*.
        /// @param aContact
        /// an nsIIccContact instance with information to be updated.
        /// @param aPin2 (Optional)
        /// The PIN2 required to update FDN contact.
        ///
        /// @param aCallback
        /// An instance of nsIIccCallback:
        /// nsIIccCallback::notifyUpdatedIccContact() if success.
        /// nsIIccCallback::notifyError(), otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateContact(uint aContactType, [MarshalAs(UnmanagedType.Interface)] nsIIccContact aContact, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPin2, [MarshalAs(UnmanagedType.Interface)] nsIIccCallback aCallback);
	}
	
	/// <summary>nsIIccConsts </summary>
	public class nsIIccConsts
	{
		
		// <summary>
        // Card State Constants
        //
        // Note: MUST be matched with enum IccCardState in MozIcc.webidl!
        // </summary>
		public const ulong CARD_STATE_UNKNOWN = 0;
		
		// 
		public const ulong CARD_STATE_READY = 1;
		
		// 
		public const ulong CARD_STATE_PIN_REQUIRED = 2;
		
		// 
		public const ulong CARD_STATE_PUK_REQUIRED = 3;
		
		// 
		public const ulong CARD_STATE_PERMANENT_BLOCKED = 4;
		
		// 
		public const ulong CARD_STATE_PERSONALIZATION_IN_PROGRESS = 5;
		
		// 
		public const ulong CARD_STATE_PERSONALIZATION_READY = 6;
		
		// 
		public const ulong CARD_STATE_NETWORK_LOCKED = 7;
		
		// 
		public const ulong CARD_STATE_NETWORK_SUBSET_LOCKED = 8;
		
		// 
		public const ulong CARD_STATE_CORPORATE_LOCKED = 9;
		
		// 
		public const ulong CARD_STATE_SERVICE_PROVIDER_LOCKED = 10;
		
		// 
		public const ulong CARD_STATE_SIM_LOCKED = 11;
		
		// 
		public const ulong CARD_STATE_NETWORK_PUK_REQUIRED = 12;
		
		// 
		public const ulong CARD_STATE_NETWORK_SUBSET_PUK_REQUIRED = 13;
		
		// 
		public const ulong CARD_STATE_CORPORATE_PUK_REQUIRED = 14;
		
		// 
		public const ulong CARD_STATE_SERVICE_PROVIDER_PUK_REQUIRED = 15;
		
		// 
		public const ulong CARD_STATE_SIM_PUK_REQUIRED = 16;
		
		// 
		public const ulong CARD_STATE_NETWORK1_LOCKED = 17;
		
		// 
		public const ulong CARD_STATE_NETWORK2_LOCKED = 18;
		
		// 
		public const ulong CARD_STATE_HRPD_NETWORK_LOCKED = 19;
		
		// 
		public const ulong CARD_STATE_RUIM_CORPORATE_LOCKED = 20;
		
		// 
		public const ulong CARD_STATE_RUIM_SERVICE_PROVIDER_LOCKED = 21;
		
		// 
		public const ulong CARD_STATE_RUIM_LOCKED = 22;
		
		// 
		public const ulong CARD_STATE_NETWORK1_PUK_REQUIRED = 23;
		
		// 
		public const ulong CARD_STATE_NETWORK2_PUK_REQUIRED = 24;
		
		// 
		public const ulong CARD_STATE_HRPD_NETWORK_PUK_REQUIRED = 25;
		
		// 
		public const ulong CARD_STATE_RUIM_CORPORATE_PUK_REQUIRED = 26;
		
		// 
		public const ulong CARD_STATE_RUIM_SERVICE_PROVIDER_PUK_REQUIRED = 27;
		
		// 
		public const ulong CARD_STATE_RUIM_PUK_REQUIRED = 28;
		
		// 
		public const ulong CARD_STATE_ILLEGAL = 29;
		
		// 
		public const ulong CARD_STATE_UNDETECTED = 4294967295;
		
		// <summary>
        // Card Lock Constants
        //
        // Note: MUST be matched with enum IccLockType in MozIcc.webidl!
        // </summary>
		public const ulong CARD_LOCK_TYPE_PIN = 0;
		
		// 
		public const ulong CARD_LOCK_TYPE_PIN2 = 1;
		
		// 
		public const ulong CARD_LOCK_TYPE_PUK = 2;
		
		// 
		public const ulong CARD_LOCK_TYPE_PUK2 = 3;
		
		// 
		public const ulong CARD_LOCK_TYPE_NCK = 4;
		
		// 
		public const ulong CARD_LOCK_TYPE_NSCK = 5;
		
		// 
		public const ulong CARD_LOCK_TYPE_NCK1 = 6;
		
		// 
		public const ulong CARD_LOCK_TYPE_NCK2 = 7;
		
		// 
		public const ulong CARD_LOCK_TYPE_HNCK = 8;
		
		// 
		public const ulong CARD_LOCK_TYPE_CCK = 9;
		
		// 
		public const ulong CARD_LOCK_TYPE_SPCK = 10;
		
		// 
		public const ulong CARD_LOCK_TYPE_PCK = 11;
		
		// 
		public const ulong CARD_LOCK_TYPE_RCCK = 12;
		
		// 
		public const ulong CARD_LOCK_TYPE_RSPCK = 13;
		
		// 
		public const ulong CARD_LOCK_TYPE_NCK_PUK = 14;
		
		// 
		public const ulong CARD_LOCK_TYPE_NSCK_PUK = 15;
		
		// 
		public const ulong CARD_LOCK_TYPE_NCK1_PUK = 16;
		
		// 
		public const ulong CARD_LOCK_TYPE_NCK2_PUK = 17;
		
		// 
		public const ulong CARD_LOCK_TYPE_HNCK_PUK = 18;
		
		// 
		public const ulong CARD_LOCK_TYPE_CCK_PUK = 19;
		
		// 
		public const ulong CARD_LOCK_TYPE_SPCK_PUK = 20;
		
		// 
		public const ulong CARD_LOCK_TYPE_PCK_PUK = 21;
		
		// 
		public const ulong CARD_LOCK_TYPE_RCCK_PUK = 22;
		
		// 
		public const ulong CARD_LOCK_TYPE_RSPCK_PUK = 23;
		
		// 
		public const ulong CARD_LOCK_TYPE_FDN = 24;
		
		// <summary>
        // Contact Type Constants
        //
        // Note: MUST be matched with enum IccContactType in MozIcc.webidl!
        // </summary>
		public const ulong CARD_CONTACT_TYPE_ADN = 0;
		
		// 
		public const ulong CARD_CONTACT_TYPE_FDN = 1;
		
		// 
		public const ulong CARD_CONTACT_TYPE_SDN = 2;
		
		// <summary>
        // MVNO Type Constants
        //
        // Note: MUST be matched with enum IccMvnoType in MozIcc.webidl!
        // </summary>
		public const ulong CARD_MVNO_TYPE_IMSI = 0;
		
		// 
		public const ulong CARD_MVNO_TYPE_SPN = 1;
		
		// 
		public const ulong CARD_MVNO_TYPE_GID = 2;
		
		// <summary>
        // Card Service Constants
        //
        // Note: MUST be matched with enum IccService in MozIcc.webidl!
        // </summary>
		public const ulong CARD_SERVICE_FDN = 0;
		
		// <summary>
        // Icc Contact Type Constants
        //
        // Note: MUST be matched with enum IccContactType in MozIcc.webidl!
        // </summary>
		public const ulong CONTACT_TYPE_ADN = 0;
		
		// 
		public const ulong CONTACT_TYPE_FDN = 1;
		
		// 
		public const ulong CONTACT_TYPE_SDN = 2;
	}
}
