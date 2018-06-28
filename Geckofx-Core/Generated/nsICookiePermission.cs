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
// Generated by IDLImporter from file nsICookiePermission.idl
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
    /// An interface to test for cookie permissions
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("11ddd4ed-8f5b-40b3-b2a0-27c20ea1c88d")]
	public interface nsICookiePermission
	{
		
		/// <summary>
        /// setAccess
        ///
        /// this method is called to block cookie access for the given URI.  this
        /// may result in other URIs being blocked as well (e.g., URIs which share
        /// the same host name).
        ///
        /// @param aURI
        /// the URI to block
        /// @param aAccess
        /// the new cookie access for the URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAccess([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, System.IntPtr aAccess);
		
		/// <summary>
        /// canAccess
        ///
        /// this method is called to test whether or not the given URI/channel may
        /// access the cookie database, either to set or get cookies.
        ///
        /// @param aPrincipal
        /// the principal trying to access cookies.
        ///
        /// @return one of the following nsCookieAccess values:
        /// ACCESS_DEFAULT, ACCESS_ALLOW, ACCESS_DENY, or
        /// ACCESS_ALLOW_FIRST_PARTY_ONLY
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CanAccess([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
		
		/// <summary>
        /// canSetCookie
        ///
        /// this method is called to test whether or not the given URI/channel may
        /// set a specific cookie.  this method is always preceded by a call to
        /// canAccess. it may modify the isSession and expiry attributes of the
        /// cookie via the aIsSession and aExpiry parameters, in order to limit
        /// or extend the lifetime of the cookie. this is useful, for instance, to
        /// downgrade a cookie to session-only if it fails to meet certain criteria.
        ///
        /// @param aURI
        /// the URI trying to set the cookie
        /// @param aChannel
        /// the channel corresponding to aURI
        /// @param aCookie
        /// the cookie being added to the cookie database
        /// @param aIsSession
        /// when canSetCookie is invoked, this is the current isSession attribute
        /// of the cookie. canSetCookie may leave this value unchanged to
        /// preserve this attribute of the cookie.
        /// @param aExpiry
        /// when canSetCookie is invoked, this is the current expiry time of
        /// the cookie. canSetCookie may leave this value unchanged to
        /// preserve this attribute of the cookie.
        ///
        /// @return true if the cookie can be set.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanSetCookie([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsICookie2 aCookie, [MarshalAs(UnmanagedType.U1)] ref bool aIsSession, ref long aExpiry);
	}
	
	/// <summary>nsICookiePermissionConsts </summary>
	public class nsICookiePermissionConsts
	{
		
		// <summary>
        // nsCookieAccess values
        // </summary>
		public const long ACCESS_DEFAULT = 0;
		
		// 
		public const long ACCESS_ALLOW = 1;
		
		// 
		public const long ACCESS_DENY = 2;
		
		// <summary>
        // additional values for nsCookieAccess which may not match
        // nsIPermissionManager. Keep 3-7 available to allow nsIPermissionManager to
        // add values without colliding. ACCESS_SESSION is not directly returned by
        // any methods on this interface.
        // </summary>
		public const long ACCESS_SESSION = 8;
		
		// 
		public const long ACCESS_ALLOW_FIRST_PARTY_ONLY = 9;
		
		// 
		public const long ACCESS_LIMIT_THIRD_PARTY = 10;
	}
}
