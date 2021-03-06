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
// Generated by IDLImporter from file nsIIOService.idl
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
    /// nsIIOService provides a set of network utility functions.  This interface
    /// duplicates many of the nsIProtocolHandler methods in a protocol handler
    /// independent way (e.g., NewURI inspects the scheme in order to delegate
    /// creation of the new URI to the appropriate protocol handler).  nsIIOService
    /// also provides a set of URL parsing utility functions.  These are provided
    /// as a convenience to the programmer and in some cases to improve performance
    /// by eliminating intermediate data structures and interfaces.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4286de5a-b2ea-446f-8f70-e2a461f42694")]
	public interface nsIIOService
	{
		
		/// <summary>
        /// Returns a protocol handler for a given URI scheme.
        ///
        /// @param aScheme the URI scheme
        /// @return reference to corresponding nsIProtocolHandler
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProtocolHandler GetProtocolHandler([MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		/// <summary>
        /// Returns the protocol flags for a given scheme.
        ///
        /// @param aScheme the URI scheme
        /// @return value of corresponding nsIProtocolHandler::protocolFlags
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProtocolFlags([MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		/// <summary>
        /// This method constructs a new URI by determining the scheme of the
        /// URI spec, and then delegating the construction of the URI to the
        /// protocol handler for that scheme. QueryInterface can be used on
        /// the resulting URI object to obtain a more specific type of URI.
        ///
        /// @see nsIProtocolHandler::newURI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// This method constructs a new URI from a nsIFile.
        ///
        /// @param aFile specifies the file path
        /// @return reference to a new nsIURI object
        ///
        /// Note: in the future, for perf reasons we should allow
        /// callers to specify whether this is a file or directory by
        /// splitting this  into newDirURI() and newActualFileURI().
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewFileURI([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>
        /// Creates a channel for a given URI.
        ///
        /// @param aURI
        /// nsIURI from which to make a channel
        /// @param aLoadingNode
        /// @param aLoadingPrincipal
        /// @param aTriggeringPrincipal
        /// @param aSecurityFlags
        /// @param aContentPolicyType
        /// These will be used as values for the nsILoadInfo object on the
        /// created channel. For details, see nsILoadInfo in nsILoadInfo.idl
        /// @return reference to the new nsIChannel object
        ///
        /// Please note, if you provide both a loadingNode and a loadingPrincipal,
        /// then loadingPrincipal must be equal to loadingNode->NodePrincipal().
        /// But less error prone is to just supply a loadingNode.
        ///
        /// Keep in mind that URIs coming from a webpage should *never* use the
        /// systemPrincipal as the loadingPrincipal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannelFromURI2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int NewChannelFromURIWithClientAndController([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, nsISupports aLoadingClientInfo, nsISupports aController, uint aSecurityFlags, uint aContentPolicyType, [MarshalAs(UnmanagedType.Interface)] ref nsIChannel aResult);
		
		/// <summary>
        /// Equivalent to newChannelFromURI2(aURI, aLoadingNode, ...)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannelFromURIWithLoadInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);
		
		/// <summary>
        /// Equivalent to newChannelFromURI2(newURI(...))
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannel2([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);
		
		/// <summary>
        /// ***** DEPRECATED *****
        /// Please use NewChannelFromURI2()
        ///
        /// Creates a channel for a given URI.
        ///
        /// @param aURI nsIURI from which to make a channel
        /// @return reference to the new nsIChannel object
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannelFromURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// ***** DEPRECATED *****
        /// Please use newChannel2().
        ///
        /// Equivalent to newChannelFromURI(newURI(...))
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannel([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// Returns true if networking is in "offline" mode. When in offline mode,
        /// attempts to access the network will fail (although this does not
        /// necessarily correlate with whether there is actually a network
        /// available -- that's hard to detect without causing the dialer to
        /// come up).
        ///
        /// Changing this fires observer notifications ... see below.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOfflineAttribute();
		
		/// <summary>
        /// Returns true if networking is in "offline" mode. When in offline mode,
        /// attempts to access the network will fail (although this does not
        /// necessarily correlate with whether there is actually a network
        /// available -- that's hard to detect without causing the dialer to
        /// come up).
        ///
        /// Changing this fires observer notifications ... see below.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOfflineAttribute([MarshalAs(UnmanagedType.U1)] bool aOffline);
		
		/// <summary>
        /// Returns false if there are no interfaces for a network request
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetConnectivityAttribute();
		
		/// <summary>
        /// Checks if a port number is banned. This involves consulting a list of
        /// unsafe ports, corresponding to network services that may be easily
        /// exploitable. If the given port is considered unsafe, then the protocol
        /// handler (corresponding to aScheme) will be asked whether it wishes to
        /// override the IO service's decision to block the port. This gives the
        /// protocol handler ultimate control over its own security policy while
        /// ensuring reasonable, default protection.
        ///
        /// @see nsIProtocolHandler::allowPort
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowPort(int aPort, [MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		/// <summary>
        /// Utility to extract the scheme from a URL string, consistently and
        /// according to spec (see RFC 2396).
        ///
        /// NOTE: Most URL parsing is done via nsIURI, and in fact the scheme
        /// can also be extracted from a URL string via nsIURI.  This method
        /// is provided purely as an optimization.
        ///
        /// @param aSpec the URL string to parse
        /// @return URL scheme, lowercase
        ///
        /// @throws NS_ERROR_MALFORMED_URI if URL string is not of the right form.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExtractScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase urlString, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Checks if a URI host is a local IPv4 or IPv6 address literal.
        ///
        /// @param nsIURI the URI that contains the hostname to check
        /// @return true if the URI hostname is a local IP address
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HostnameIsLocalIPAddress([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// While this is set, IOService will monitor an nsINetworkLinkService
        /// (if available) and set its offline status to "true" whenever
        /// isLinkUp is false.
        ///
        /// Applications that want to control changes to the IOService's offline
        /// status should set this to false, watch for network:link-status-changed
        /// broadcasts, and change nsIIOService::offline as they see fit. Note
        /// that this means during application startup, IOService may be offline
        /// if there is no link, until application code runs and can turn off
        /// this management.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetManageOfflineStatusAttribute();
		
		/// <summary>
        /// While this is set, IOService will monitor an nsINetworkLinkService
        /// (if available) and set its offline status to "true" whenever
        /// isLinkUp is false.
        ///
        /// Applications that want to control changes to the IOService's offline
        /// status should set this to false, watch for network:link-status-changed
        /// broadcasts, and change nsIIOService::offline as they see fit. Note
        /// that this means during application startup, IOService may be offline
        /// if there is no link, until application code runs and can turn off
        /// this management.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetManageOfflineStatusAttribute([MarshalAs(UnmanagedType.U1)] bool aManageOfflineStatus);
		
		/// <summary>
        /// Creates a channel for a given URI.
        ///
        /// @param aURI
        /// nsIURI from which to make a channel
        /// @param aProxyURI
        /// nsIURI to use for proxy resolution. Can be null in which
        /// case aURI is used
        /// @param aProxyFlags flags from nsIProtocolProxyService to use
        /// when resolving proxies for this new channel
        /// @param aLoadingNode
        /// @param aLoadingPrincipal
        /// @param aTriggeringPrincipal
        /// @param aSecurityFlags
        /// @param aContentPolicyType
        /// These will be used as values for the nsILoadInfo object on the
        /// created channel. For details, see nsILoadInfo in nsILoadInfo.idl
        /// @return reference to the new nsIChannel object
        ///
        /// Please note, if you provide both a loadingNode and a loadingPrincipal,
        /// then loadingPrincipal must be equal to loadingNode->NodePrincipal().
        /// But less error prone is to just supply a loadingNode.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannelFromURIWithProxyFlags2([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aProxyURI, uint aProxyFlags, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aLoadingNode, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aLoadingPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aTriggeringPrincipal, uint aSecurityFlags, uint aContentPolicyType);
	}
	
	/// <summary>nsIIOServiceInternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6633c0bf-d97a-428f-8ece-cb6a655fb95a")]
	public interface nsIIOServiceInternal
	{
		
		/// <summary>
        /// This is an internal method that should only be called from ContentChild
        /// in order to pass the connectivity state from the chrome process to the
        /// content process. It throws if called outside the content process.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetConnectivity([MarshalAs(UnmanagedType.U1)] bool connectivity);
		
		/// <summary>
        /// An internal method to asynchronously run our notifications that happen
        /// when we wake from sleep
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyWakeup();
	}
}
