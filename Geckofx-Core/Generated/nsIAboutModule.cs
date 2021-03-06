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
// Generated by IDLImporter from file nsIAboutModule.idl
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
	[Guid("c0c19db9-1b5a-4ac5-b656-ed6f8149fa48")]
	public interface nsIAboutModule
	{
		
		/// <summary>
        /// Constructs a new channel for the about protocol module.
        ///
        /// @param aURI the uri of the new channel
        /// @param aLoadInfo the loadinfo of the new channel
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannel([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsILoadInfo aLoadInfo);
		
		/// <summary>
        /// A method to get the flags that apply to a given about: URI.  The URI
        /// passed in is guaranteed to be one of the URIs that this module
        /// registered to deal with.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetURIFlags([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
	}
	
	/// <summary>nsIAboutModuleConsts </summary>
	public class nsIAboutModuleConsts
	{
		
		// <summary>
        // A flag that indicates whether a URI should be run with content
        // privileges. If it is, the about: protocol handler will enforce that
        // the principal of channels created for it be based on their
        // originalURI or URI (depending on the channel flags), by setting
        // their "owner" to null.
        // If content needs to be able to link to this URI, specify
        // URI_CONTENT_LINKABLE as well.
        // </summary>
		public const ulong URI_SAFE_FOR_UNTRUSTED_CONTENT = (1<<0);
		
		// <summary>
        // A flag that indicates whether script should be enabled for the
        // given about: URI even if it's disabled in general.
        // </summary>
		public const ulong ALLOW_SCRIPT = (1<<1);
		
		// <summary>
        // A flag that indicates whether this about: URI doesn't want to be listed
        // in about:about, especially if it's not useful without a query string.
        // </summary>
		public const ulong HIDE_FROM_ABOUTABOUT = (1<<2);
		
		// <summary>
        // A flag that indicates whether this about: URI wants Indexed DB enabled.
        // </summary>
		public const ulong ENABLE_INDEXED_DB = (1<<3);
		
		// <summary>
        // A flag that indicates that this URI can be loaded in a child process
        // </summary>
		public const ulong URI_CAN_LOAD_IN_CHILD = (1<<4);
		
		// <summary>
        // A flag that indicates that this URI must be loaded in a child process
        // </summary>
		public const ulong URI_MUST_LOAD_IN_CHILD = (1<<5);
		
		// <summary>
        // Obsolete. This flag no longer has any effect and will be removed in future.
        // </summary>
		public const ulong MAKE_UNLINKABLE = (1<<6);
		
		// <summary>
        // A flag that indicates that this URI should be linkable from content.
        // Ignored unless URI_SAFE_FOR_UNTRUSTED_CONTENT is also specified.
        // </summary>
		public const ulong MAKE_LINKABLE = (1<<7);
	}
}
