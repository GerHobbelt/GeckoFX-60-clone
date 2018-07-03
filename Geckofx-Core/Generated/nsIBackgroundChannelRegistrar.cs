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
// Generated by IDLImporter from file nsIBackgroundChannelRegistrar.idl
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
    /// Registrar for pairing /* HttpChannelParent */ nsISupports and /* HttpBackgroundChannelParent */ nsISupports via
    /// channel Id. /* HttpChannelParent */ nsISupports::OnBackgroundParentReady and
    /// /* HttpBackgroundChannelParent */ nsISupports::LinkToChannel will be invoked to notify the
    /// existence of associated channel object.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8acaa9b1-f0c4-4ade-baeb-39b0d4b96e5b")]
	public interface nsIBackgroundChannelRegistrar
	{
		
		/// <summary>
        /// Link the provided channel parent actor with the given channel Id.
        /// callbacks will be invoked immediately when the /* HttpBackgroundChannelParent */ nsISupports
        /// associated with the same channel Id is found. Store the /* HttpChannelParent */ nsISupports
        /// until a matched linkBackgroundChannel is invoked.
        ///
        /// @param aKey the channel Id
        /// @param aChannel the channel parent actor to be paired
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LinkHttpChannel(ulong aKey, /* HttpChannelParent */ nsISupports aChannel);
		
		/// <summary>
        /// Link the provided background channel with the given channel Id.
        /// callbacks will be invoked immediately when the /* HttpChannelParent */ nsISupports associated
        /// with the same channel Id is found. Store the /* HttpBackgroundChannelParent */ nsISupports
        /// until a matched linkHttpChannel is invoked.
        ///
        /// @param aKey the channel Id
        /// @param aBgChannel the background channel to be paired
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LinkBackgroundChannel(ulong aKey, /* HttpBackgroundChannelParent */ nsISupports aBgChannel);
		
		/// <summary>
        /// Delete previous stored /* HttpChannelParent */ nsISupports or /* HttpBackgroundChannelParent */ nsISupports
        /// if no need to wait for the paired channel object, e.g. background channel
        /// is destroyed before pairing is completed.
        ///
        /// @param aKey the channel Id
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteChannel(ulong aKey);
	}
}
