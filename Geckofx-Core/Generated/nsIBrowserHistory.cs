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
// Generated by IDLImporter from file nsIBrowserHistory.idl
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
    /// browser-specific interface to global history
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("20d31479-38de-49f4-9300-566d6e834c66")]
	public interface nsIBrowserHistory
	{
		
		/// <summary>
        /// Removes all global history information about pages for a given host.
        ///
        /// @param aHost
        /// Hostname to be removed.
        /// An empty host name means local files and anything else with no
        /// hostname.  You can also pass in the localized "(local files)"
        /// title given to you from a history query to remove all
        /// history information from local files.
        /// @param aEntireDomain
        /// If true, will also delete pages from sub hosts (so if
        /// passed in "microsoft.com" will delete "www.microsoft.com",
        /// "msdn.microsoft.com", etc.).
        ///
        /// @note The removal happens in a batch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePagesFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.U1)] bool aEntireDomain);
		
		/// <summary>
        /// Removes all pages for a given timeframe.
        /// Limits are included: aBeginTime <= timeframe <= aEndTime
        ///
        /// @param aBeginTime
        /// Microseconds from epoch, representing the initial time.
        /// @param aEndTime
        /// Microseconds from epoch, representing the final time.
        ///
        /// @note The removal happens in a batch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePagesByTimeframe(long aBeginTime, long aEndTime);
	}
}
