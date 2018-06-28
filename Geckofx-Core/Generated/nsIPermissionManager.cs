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
// Generated by IDLImporter from file nsIPermissionManager.idl
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
    /// This file contains an interface to the Permission Manager,
    /// used to persistenly store permissions for different object types (cookies,
    /// images etc) on a site-by-site basis.
    ///
    /// This service broadcasts the following notification when the permission list
    /// is changed:
    ///
    /// topic  : "perm-changed" (PERM_CHANGE_NOTIFICATION)
    /// broadcast whenever the permission list changes in some way. there
    /// are four possible data strings for this notification; one
    /// notification will be broadcast for each change, and will involve
    /// a single permission.
    /// subject: an nsIPermission interface pointer representing the permission object
    /// that changed.
    /// data   : "deleted"
    /// a permission was deleted. the subject is the deleted permission.
    /// "added"
    /// a permission was added. the subject is the added permission.
    /// "changed"
    /// a permission was changed. the subject is the new permission.
    /// "cleared"
    /// the entire permission list was cleared. the subject is null.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4dcb3851-eba2-4e42-b236-82d2596fca22")]
	public interface nsIPermissionManager
	{
		
		/// <summary>
        /// Add permission information for a given URI and permission type. This
        /// operation will cause the type string to be registered if it does not
        /// currently exist. If a permission already exists for a given type, it
        /// will be modified.
        ///
        /// @param uri         the uri to add the permission for
        /// @param type        a case-sensitive ASCII string, identifying the consumer.
        /// Consumers should choose this string to be unique, with
        /// respect to other consumers.
        /// @param permission  an integer representing the desired action (e.g. allow
        /// or deny). The interpretation of this number is up to the
        /// consumer, and may represent different actions for different
        /// types. Consumers may use one of the enumerated permission
        /// actions defined above, for convenience.
        /// NOTE: UNKNOWN_ACTION (0) is reserved to represent the
        /// default permission when no entry is found for a host, and
        /// should not be used by consumers to indicate otherwise.
        /// @param expiretype  a constant defining whether this permission should
        /// never expire (EXPIRE_NEVER), expire at the end of the
        /// session (EXPIRE_SESSION), or expire at a specified time
        /// (EXPIRE_TIME).
        /// @param expiretime  an integer representation of when this permission
        /// should be forgotten (milliseconds since Jan 1 1970 0:00:00).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type, uint permission, uint expireType, long expireTime);
		
		/// <summary>
        /// Get all custom permissions for a given URI. This will return
        /// an enumerator of all permissions which are not set to default
        /// and which belong to the matching prinicpal of the given URI.
        ///
        /// @param uri  the URI to get all permissions for
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetAllForURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
		
		/// <summary>
        /// Add permission information for a given principal.
        /// It is internally calling the other add() method using the nsIURI from the
        /// principal.
        /// Passing a system principal will be a no-op because they will always be
        /// granted permissions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string typed, uint permission, uint expireType, long expireTime);
		
		/// <summary>
        /// Remove permission information for a given URI and permission type. This will
        /// remove the permission for the entire host described by the uri, acting as the
        /// opposite operation to the add() method.
        ///
        /// @param uri    the uri to remove the permission for
        /// @param type   a case-sensitive ASCII string, identifying the consumer.
        /// The type must have been previously registered using the
        /// add() method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Remove permission information for a given principal.
        /// This is internally calling remove() with the host from the principal's URI.
        /// Passing system principal will be a no-op because we never add them to the
        /// database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Remove the given permission from the permission manager.
        ///
        /// @param perm   a permission obtained from the permission manager.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePermission([MarshalAs(UnmanagedType.Interface)] nsIPermission perm);
		
		/// <summary>
        /// Clear permission information for all websites.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAll();
		
		/// <summary>
        /// Clear all permission information added since the specified time.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllSince(long since);
		
		/// <summary>
        /// Test whether a website has permission to perform the given action.
        /// This function will perform a pref lookup to permissions.default.<type>
        /// if the specific permission type is part of the whitelist for that functionality.
        /// @param uri     the uri to be tested
        /// @param type    a case-sensitive ASCII string, identifying the consumer
        /// @param return  see add(), param permission. returns UNKNOWN_ACTION when
        /// there is no stored permission for this uri and / or type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestPermission([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Test whether the principal has the permission to perform a given action.
        /// System principals will always have permissions granted.
        /// This function will perform a pref lookup to permissions.default.<type>
        /// if the specific permission type is part of the whitelist for that functionality.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestPermissionFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Test whether the principal associated with the window's document has the
        /// permission to perform a given action.  System principals will always
        /// have permissions granted.
        /// This function will perform a pref lookup to permissions.default.<type>
        /// if the specific permission type is part of the whitelist for that functionality.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestPermissionFromWindow(mozIDOMWindow window, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Test whether a website has permission to perform the given action.
        /// This requires an exact hostname match, subdomains are not a match.
        /// This function will perform a pref lookup to permissions.default.<type>
        /// if the specific permission type is part of the whitelist for that functionality.
        /// @param uri     the uri to be tested
        /// @param type    a case-sensitive ASCII string, identifying the consumer
        /// @param return  see add(), param permission. returns UNKNOWN_ACTION when
        /// there is no stored permission for this uri and / or type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestExactPermission([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// See testExactPermission() above.
        /// System principals will always have permissions granted.
        /// This function will perform a pref lookup to permissions.default.<type>
        /// if the specific permission type is part of the whitelist for that functionality.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestExactPermissionFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Test whether a website has permission to perform the given action
        /// ignoring active sessions.
        /// System principals will always have permissions granted.
        /// This function will perform a pref lookup to permissions.default.<type>
        /// if the specific permission type is part of the whitelist for that functionality.
        ///
        /// @param principal the principal
        /// @param type      a case-sensitive ASCII string, identifying the consumer
        /// @param return    see add(), param permission. returns UNKNOWN_ACTION when
        /// there is no stored permission for this uri and / or type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestExactPermanentPermission([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Get the permission object associated with the given URI and action.
        /// @param uri The URI
        /// @param type      A case-sensitive ASCII string identifying the consumer
        /// @param exactHost If true, only the specific host will be matched,
        /// @see testExactPermission. If false, subdomains will
        /// also be searched, @see testPermission.
        /// @returns The matching permission object, or null if no matching object
        /// was found. No matching object is equivalent to UNKNOWN_ACTION.
        /// @note Clients in general should prefer the test* methods unless they
        /// need to know the specific stored details.
        /// @note This method will always return null for the system principal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPermission GetPermissionObjectForURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type, [MarshalAs(UnmanagedType.U1)] bool exactHost);
		
		/// <summary>
        /// Get the permission object associated with the given principal and action.
        /// @param principal The principal
        /// @param type      A case-sensitive ASCII string identifying the consumer
        /// @param exactHost If true, only the specific host will be matched,
        /// @see testExactPermission. If false, subdomains will
        /// also be searched, @see testPermission.
        /// @returns The matching permission object, or null if no matching object
        /// was found. No matching object is equivalent to UNKNOWN_ACTION.
        /// @note Clients in general should prefer the test* methods unless they
        /// need to know the specific stored details.
        /// @note This method will always return null for the system principal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPermission GetPermissionObject([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type, [MarshalAs(UnmanagedType.U1)] bool exactHost);
		
		/// <summary>
        /// Allows enumeration of all stored permissions
        /// @return an nsISimpleEnumerator interface that allows access to
        /// nsIPermission objects
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetEnumeratorAttribute();
		
		/// <summary>
        /// Remove all permissions that will match the origin pattern.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePermissionsWithAttributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase patternAsJSON);
		
		/// <summary>
        /// If the current permission is set to expire, reset the expiration time. If
        /// there is no permission or the current permission does not expire, this
        /// method will silently return.
        ///
        /// @param sessionExpiretime  an integer representation of when this permission
        /// should be forgotten (milliseconds since
        /// Jan 1 1970 0:00:00), if it is currently
        /// EXPIRE_SESSION.
        /// @param sessionExpiretime  an integer representation of when this permission
        /// should be forgotten (milliseconds since
        /// Jan 1 1970 0:00:00), if it is currently
        /// EXPIRE_TIME.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateExpireTime([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type, [MarshalAs(UnmanagedType.U1)] bool exactHost, ulong sessionExpireTime, ulong persistentExpireTime);
		
		/// <summary>
        /// The content process doesn't have access to every permission. Instead, when
        /// LOAD_DOCUMENT_URI channels for http://, https://, and ftp:// URIs are
        /// opened, the permissions for those channels are sent down to the content
        /// process before the OnStartRequest message. Permissions for principals with
        /// other schemes are sent down at process startup.
        ///
        /// Permissions are keyed and grouped by "Permission Key"s.
        /// `nsPermissionManager::GetKeyForPrincipal` provides the mechanism for
        /// determining the permission key for a given principal.
        ///
        /// This method may only be called in the parent process. It fills the nsTArray
        /// argument with the IPC::Permission objects which have a matching permission
        /// key.
        ///
        /// @param permissionKey  The key to use to find the permissions of interest.
        /// @param perms  An array which will be filled with the permissions which
        /// match the given permission key.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPermissionsWithKey([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase permissionKey, [MarshalAs(UnmanagedType.Interface)] ref nsISupports perms);
		
		/// <summary>
        /// See `nsIPermissionManager::GetPermissionsWithKey` for more info on
        /// Permission keys.
        ///
        /// `SetPermissionsWithKey` may only be called in the Child process, and
        /// initializes the permission manager with the permissions for a given
        /// Permission key. marking permissions with that key as available.
        ///
        /// @param permissionKey  The key for the permissions which have been sent over.
        /// @param perms  An array with the permissions which match the given key.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissionsWithKey([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase permissionKey, [MarshalAs(UnmanagedType.Interface)] nsISupports perms);
		
		/// <summary>
        /// Broadcasts permissions for the given principal to all content processes.
        ///
        /// DO NOT USE THIS METHOD if you can avoid it. It was added in bug XXX to
        /// handle the current temporary implementation of ServiceWorker debugging. It
        /// will be removed when service worker debugging is fixed.
        ///
        /// @param aPrincipal The principal to broadcast permissions for.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BroadcastPermissionsForPrincipalToAllContentProcesses([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
		
		/// <summary>
        /// Add a callback which should be run when all permissions are available for
        /// the given nsIPrincipal. This method invokes the callback runnable
        /// synchronously when the permissions are already available. Otherwise the
        /// callback will be run asynchronously in SystemGroup when all permissions
        /// are available in the future.
        ///
        /// NOTE: This method will not request the permissions be sent by the parent
        /// process. This should only be used to wait for permissions which may not
        /// have arrived yet in order to ensure they are present.
        ///
        /// @param aPrincipal The principal to wait for permissions to be available for.
        /// @param aRunnable  The runnable to run when permissions are available for the
        /// given principal.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WhenPermissionsAvailable([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIRunnable aRunnable);
		
		/// <summary>
        /// True if any "preload" permissions are present. This is used to avoid making
        /// potentially expensive permissions checks in nsContentBlocker.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasPreloadPermissionsAttribute();
	}
	
	/// <summary>nsIPermissionManagerConsts </summary>
	public class nsIPermissionManagerConsts
	{
		
		// <summary>
        // Predefined return values for the testPermission method and for
        // the permission param of the add method
        // NOTE: UNKNOWN_ACTION (0) is reserved to represent the
        // default permission when no entry is found for a host, and
        // should not be used by consumers to indicate otherwise.
        // </summary>
		public const long UNKNOWN_ACTION = 0;
		
		// 
		public const long ALLOW_ACTION = 1;
		
		// 
		public const long DENY_ACTION = 2;
		
		// 
		public const long PROMPT_ACTION = 3;
		
		// <summary>
        // Predefined expiration types for permissions.  Permissions can be permanent
        // (never expire), expire at the end of the session, or expire at a specified
        // time. Permissions that expire at the end of a session may also have a
        // specified expiration time.
        //
        // EXPIRE_POLICY is a special expiration status. It is set when the permission
        // is set by reading an enterprise policy. These permissions cannot be overridden.
        // </summary>
		public const long EXPIRE_NEVER = 0;
		
		// 
		public const long EXPIRE_SESSION = 1;
		
		// 
		public const long EXPIRE_TIME = 2;
		
		// 
		public const long EXPIRE_POLICY = 3;
	}
}
