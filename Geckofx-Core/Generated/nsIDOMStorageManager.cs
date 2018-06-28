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
// Generated by IDLImporter from file nsIDOMStorageManager.idl
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
    /// General purpose interface that has two implementations, for localStorage
    /// resp. sessionStorage with "@mozilla.org/dom/localStorage-manager;1" resp.
    /// "@mozilla.org/dom/sessionStorage-manager;1" contract IDs.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a20c742e-3ed1-44fb-b897-4080a75b1662")]
	public interface nsIDOMStorageManager
	{
		
		/// <summary>
        /// This starts async preloading of a storage cache for scope
        /// defined by the principal.
        ///
        /// Because of how multi-e10s support was implemented in bug 1285898, the
        /// StorageCache instance can no longer use a timer to keep itself alive.  So a
        /// Storage instance is returned if precaching believes the principal may have
        /// localStorage data.  (Previously the StorageCache would be brought into
        /// existence and kept alive by the timer so that it could be returned if a
        /// call to createStorage was made due to a request by the page.)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage PrecacheStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
		
		/// <summary>
        /// Returns instance of DOM storage object for given principal.
        /// A new object is always returned and it is ensured there is
        /// a storage for the scope created.
        ///
        /// @param aWindow
        /// The parent window.
        /// @param aPrincipal
        /// Principal to bound storage to.
        /// @param aDocumentURI
        /// URL of the demanding document, used for DOM storage event only.
        /// @param aPrivate
        /// Whether the demanding document is running in Private Browsing mode or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage CreateStorage(mozIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDocumentURI, [MarshalAs(UnmanagedType.U1)] bool aPrivate);
		
		/// <summary>
        /// Returns instance of DOM storage object for given principal.
        /// If there is no storage managed for the scope, then null is returned and
        /// no object is created.  Otherwise, an object (new) for the existing storage
        /// scope is returned.
        ///
        /// @param aWindow
        /// The parent window.
        /// @param aPrincipal
        /// Principal to bound storage to.
        /// @param aPrivate
        /// Whether the demanding document is running in Private Browsing mode or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage GetStorage(mozIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.U1)] bool aPrivate);
		
		/// <summary>
        /// Clones given storage into this storage manager.
        ///
        /// @param aStorageToCloneFrom
        /// The storage to copy all items from into this manager.  Manager will then
        /// return a new and independent object that contains snapshot of data from
        /// the moment this method was called.  Modification to this new object will
        /// not affect the original storage content we cloned from and vice versa.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloneStorage([MarshalAs(UnmanagedType.Interface)] nsIDOMStorage aStorageToCloneFrom);
		
		/// <summary>
        /// Returns true if the storage belongs to the given principal and is managed
        /// (i.e. has been created and is cached) by this storage manager.
        ///
        /// @param aPrincipal
        /// Principal to check the storage against.
        /// @param aStorage
        /// The storage object to examine.
        ///
        /// @result
        /// true when the storage object is bound with the principal and is managed
        /// by this storage manager.
        /// false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIDOMStorage aStorage);
	}
}
