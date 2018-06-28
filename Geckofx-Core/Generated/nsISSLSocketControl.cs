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
// Generated by IDLImporter from file nsISSLSocketControl.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("418265c8-654e-4fbb-ba62-4eed27de1f03")]
	public interface nsISSLSocketControl
	{
		
		/// <summary>
        ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        ///
        /// This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor GetNotificationCallbacksAttribute();
		
		/// <summary>
        ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        ///
        /// This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ProxyStartSSL();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartTLS();
		
		/// <summary>
        ///NPN (Next Protocol Negotiation) is a mechanism for
        ///       negotiating the protocol to be spoken inside the SSL
        ///       tunnel during the SSL handshake. The NPNList is the list
        ///       of offered client side protocols. setNPNList() needs to
        ///       be called before any data is read or written (including the
        ///       handshake to be setup correctly. The server determines the
        ///       priority when multiple matches occur, but if there is no overlap
        ///       the first protocol in the list is used. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNPNList(System.IntPtr aNPNList);
		
		/// <summary>
        ///negotiatedNPN is '' if no NPN list was provided by the client,
        /// or if the server did not select any protocol choice from that
        /// list. That also includes the case where the server does not
        /// implement NPN.
        ///
        /// If negotiatedNPN is read before NPN has progressed to the point
        /// where this information is available NS_ERROR_NOT_CONNECTED is
        /// raised.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNegotiatedNPNAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNegotiatedNPN);
		
		/// <summary>
        ///For 0RTT we need to know the alpn protocol selected for the last tls
        /// session. This function will return a value if applicable or an error
        /// NS_ERROR_NOT_AVAILABLE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAlpnEarlySelection([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        ///If 0RTT handshake was applied and some data has been sent, as soon as
        /// the handshake finishes this attribute will be set to appropriate value.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEarlyDataAcceptedAttribute();
		
		/// <summary>
        ///When 0RTT is performed, PR_Write will not drive the handshake forward.
        /// It must be forced by calling this function.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DriveHandshake();
		
		/// <summary>
        ///e.g. "h2" </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool JoinConnection([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase npnProtocol, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostname, int port);
		
		/// <summary>
        ///e.g. "h2" </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool TestJoinConnection([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase npnProtocol, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostname, int port);
		
		/// <summary>
        ///Determine if existing connection should be trusted to convey information about
        /// a hostname.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsAcceptableForHost([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase hostname);
		
		/// <summary>
        ///The Key Exchange Algorithm is used when determining whether or
        ///       not HTTP/2 can be used.
        ///       After a handshake is complete it can be read from KEAUsed.
        ///       The values correspond to the SSLKEAType enum in NSS or the
        ///       KEY_EXCHANGE_UNKNOWN constant defined below.
        ///       KEAKeyBits is the size/security-level used for the KEA.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetKEAUsedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetKEAKeyBitsAttribute();
		
		/// <summary>
        /// The original flags from the socket provider.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProviderFlagsAttribute();
		
		/// <summary>
        /// The original TLS flags from the socket provider.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProviderTlsFlagsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetSSLVersionUsedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetSSLVersionOfferedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetMACAlgorithmUsedAttribute();
		
		/// <summary>
        /// If set to true before the server requests a client cert
        /// no cert will be sent.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDenyClientCertAttribute();
		
		/// <summary>
        /// If set to true before the server requests a client cert
        /// no cert will be sent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDenyClientCertAttribute([MarshalAs(UnmanagedType.U1)] bool aDenyClientCert);
		
		/// <summary>
        /// If set before the server requests a client cert (assuming it does so at
        /// all), then this cert will be presented to the server, instead of asking
        /// the user or searching the set of rememebered user cert decisions.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509Cert GetClientCertAttribute();
		
		/// <summary>
        /// If set before the server requests a client cert (assuming it does so at
        /// all), then this cert will be presented to the server, instead of asking
        /// the user or searching the set of rememebered user cert decisions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClientCertAttribute([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aClientCert);
		
		/// <summary>
        /// True iff a client cert has been sent to the server - i.e. this
        /// socket has been client-cert authenticated.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetClientCertSentAttribute();
		
		/// <summary>
        /// bypassAuthentication is true if the server certificate checks are
        /// not be enforced. This is to enable non-secure transport over TLS.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBypassAuthenticationAttribute();
		
		/// <summary>
        /// failedVerification is true if any enforced certificate checks have failed.
        /// Connections that have not yet tried to verify, have verifications bypassed,
        /// or are using acceptable exceptions will all return false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFailedVerificationAttribute();
	}
	
	/// <summary>nsISSLSocketControlConsts </summary>
	public class nsISSLSocketControlConsts
	{
		
		// 
		public const short KEY_EXCHANGE_UNKNOWN = -1;
		
		// <summary>
        //These values are defined by TLS. </summary>
		public const short SSL_VERSION_3 = 0x0300;
		
		// 
		public const short TLS_VERSION_1 = 0x0301;
		
		// 
		public const short TLS_VERSION_1_1 = 0x0302;
		
		// 
		public const short TLS_VERSION_1_2 = 0x0303;
		
		// 
		public const short TLS_VERSION_1_3 = 0x0304;
		
		// 
		public const short SSL_VERSION_UNKNOWN = -1;
		
		// <summary>
        //These values match the NSS defined values in sslt.h </summary>
		public const short SSL_MAC_UNKNOWN = -1;
		
		// 
		public const short SSL_MAC_NULL = 0;
		
		// 
		public const short SSL_MAC_MD5 = 1;
		
		// 
		public const short SSL_MAC_SHA = 2;
		
		// 
		public const short SSL_HMAC_MD5 = 3;
		
		// 
		public const short SSL_HMAC_SHA = 4;
		
		// 
		public const short SSL_HMAC_SHA256 = 5;
		
		// 
		public const short SSL_MAC_AEAD = 6;
	}
}
