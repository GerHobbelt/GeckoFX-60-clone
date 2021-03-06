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
// Generated by IDLImporter from file nsIFaviconService.idl
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
	[Guid("e81e0b0c-b9f1-4c2e-8f3c-b809933cf73c")]
	public interface nsIFaviconService
	{
		
		/// <summary>
        /// For a given icon URI, this will return a URI that will result in the image.
        /// In most cases, this is an annotation URI.  For chrome URIs, this will do
        /// nothing but returning the input URI.
        ///
        /// No validity checking is done. If you pass an icon URI that we've never
        /// seen, you'll get back a URI that references an invalid icon. The moz-anno
        /// protocol handler's special case for "favicon" annotations will resolve
        /// invalid icons to the default icon, although without caching.
        /// For invalid chrome URIs, you'll get a broken image.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// @return A URI that will give you the icon image.  This is NOT the URI of
        /// the icon as set on the page, but a URI that will give you the
        /// data out of the favicon service.  For a normal page with a
        /// favicon we've stored, this will be an annotation URI which will
        /// then cause the corresponding favicon data to be loaded async from
        /// this service.  For pages where we don't have a favicon, this will
        /// be a chrome URI of the default icon. For chrome URIs, the
        /// output will be the same as the input.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFaviconLinkForIcon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Expire all known favicons from the database.
        ///
        /// @note This is an async method.
        /// On successful completion a "places-favicons-expired" notification is
        /// dispatched through observer's service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExpireAllFavicons();
		
		/// <summary>
        /// Sets the default size returned by preferredSizeFromURI when the uri doesn't
        /// specify a size ref. If this is not invoked first, or 0 is passed to it,
        /// preferredSizeFromURI() will return UINT16_MAX, that matches the biggest
        /// icon available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultIconURIPreferredSize(ushort aDefaultSize);
		
		/// <summary>
        /// Tries to extract the preferred size from an icon uri ref fragment.
        ///
        /// @param aURI
        /// The URI to parse.
        /// @return The preferred size, or a default size set through
        /// setDefaultIconURIPreferredSize, or UINT16_MAX if neither are set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint PreferredSizeFromURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Adds a given favicon's URI to the failed favicon cache.
        ///
        /// The lifespan of the favicon cache is up to the caching system.  This cache
        /// will also be written when setAndLoadFaviconForPage hits an error while
        /// fetching an icon.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Removes the given favicon from the failed favicon cache.  If the icon is
        /// not in the cache, it will silently succeed.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Checks to see if a favicon is in the failed favicon cache.
        /// A positive return value means the icon is in the failed cache and you
        /// probably shouldn't try to load it.  A false return value means that it's
        /// worth trying to load it.
        /// This allows you to avoid trying to load "foo.com/favicon.ico" for every
        /// page on a site that doesn't have a favicon.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// The default favicon URI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetDefaultFaviconAttribute();
		
		/// <summary>
        /// The default favicon mimeType
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultFaviconMimeTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDefaultFaviconMimeType);
	}
	
	/// <summary>nsIFaviconServiceConsts </summary>
	public class nsIFaviconServiceConsts
	{
		
		// <summary>
        // The favicon is being loaded from a private browsing window
        // </summary>
		public const ulong FAVICON_LOAD_PRIVATE = 1;
		
		// <summary>
        // The favicon is being loaded from a non-private browsing window
        // </summary>
		public const ulong FAVICON_LOAD_NON_PRIVATE = 2;
		
		// <summary>
        // The limit in bytes of the size of favicons in memory and passed via the
        // favicon protocol.
        // </summary>
		public const ulong MAX_FAVICON_BUFFER_SIZE = 65536;
	}
	
	/// <summary>nsIFaviconDataCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c85e5c82-b70f-4621-9528-beb2aa47fb44")]
	public interface nsIFaviconDataCallback
	{
		
		/// <summary>
        /// Called when the required favicon's information is available.
        ///
        /// It's up to the invoking method to state if the callback is always invoked,
        /// or called on success only.  Check the method documentation to ensure that.
        ///
        /// The caller will receive the most information we can gather on the icon,
        /// but it's not guaranteed that all of them will be set.  For some method
        /// we could not know the favicon's data (it could just be too expensive to
        /// get it, or the method does not require we actually have any data).
        /// It's up to the caller to check aDataLen > 0 before using any data-related
        /// information like mime-type or data itself.
        ///
        /// @param aFaviconURI
        /// Receives the "favicon URI" (not the "favicon link URI") associated
        /// to the requested page.  This can be null if there is no associated
        /// favicon URI, or the callback is notifying a failure.
        /// @param aDataLen
        /// Size of the icon data in bytes.  Notice that a value of 0 does not
        /// necessarily mean that we don't have an icon.
        /// @param aData
        /// Icon data, or an empty array if aDataLen is 0.
        /// @param aMimeType
        /// Mime type of the icon, or an empty string if aDataLen is 0.
        /// @param aWidth
        /// Width of the icon. 0 if the width is unknown or if the icon is
        /// vectorial.
        ///
        /// @note If you want to open a network channel to access the favicon, it's
        /// recommended that you call the getFaviconLinkForIcon method to convert
        /// the "favicon URI" into a "favicon link URI".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnComplete([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, uint aDataLen, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] aData, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMimeType, ushort aWidth);
	}
}
