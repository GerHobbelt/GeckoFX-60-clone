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
// Generated by IDLImporter from file nsIPackagedAppService.idl
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
    /// nsIPackagedAppService
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c96c638-e80c-4dce-abec-c96fdb7a25d8")]
	public interface nsIPackagedAppService
	{
		
		/// <summary>
        /// @param aChannel
        /// this param is passed to the packaged app service in order to provide
        /// info about the requesting channel, which wants to access the contents
        /// of a packaged app resource. Its URI has the following format:
        /// http://domain.com/path/to/package.pak!//path/to/subresource.html
        ///
        /// @param aCallback
        /// an object implementing nsICacheEntryOpenCallback
        /// this is the target of the async result of the operation
        /// aCallback->OnCacheEntryCheck() is called to verify the entry is valid
        /// aCallback->OnCacheEntryAvailable() is called with a pointer to the
        /// the cached entry, if one exists, or an error code otherwise
        /// aCallback is kept alive using an nsCOMPtr until OnCacheEntryAvailable
        /// is called
        ///
        /// Calling this method will either download the package containing the given
        /// resource URI, store it in the cache and pass the cache entry to aCallback,
        /// or if that resource has already been downloaded it will be served from
        /// the cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResource([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.Interface)] nsICacheEntryOpenCallback aCallback);
	}
}
