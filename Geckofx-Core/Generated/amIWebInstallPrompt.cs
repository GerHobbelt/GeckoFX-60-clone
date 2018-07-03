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
// Generated by IDLImporter from file amIWebInstallPrompt.idl
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
    /// amIWebInstallPrompt is used, if available, by the default implementation of
    /// amIWebInstallInfo to display a confirmation UI to the user before running
    /// installs.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("386906f1-4d18-45bf-bc81-5dcd68e42c3b")]
	public interface amIWebInstallPrompt
	{
		
		/// <summary>
        /// Get a confirmation that the user wants to start the installs.
        ///
        /// @param  aBrowser
        /// The browser that triggered the installs
        /// @param  aUri
        /// The URI of the site that triggered the installs
        /// @param  aInstalls
        /// The AddonInstalls that were requested
        /// @param  aCount
        /// The number of AddonInstalls
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Confirm([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aBrowser, [MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] nsIVariant[] aInstalls, uint aCount);
	}
}
