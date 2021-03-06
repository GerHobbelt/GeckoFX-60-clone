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
// Generated by IDLImporter from file nsIURIMutator.idl
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
	[Guid("1fc53257-898b-4c5e-b69c-05bc84b4cd8f")]
	public interface nsIURISetSpec
	{
		
		/// <summary>
        /// This setter is different from all other setters because it may be used to
        /// initialize the object. We define it separately allowing mutator implementors
        /// to define it separately, while the rest of the setters may be simply
        /// forwarded to the mutable URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetSpec([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
	}
	
	/// <summary>
    /// These methods allow the mutator to change various parts of the URI.
    /// They return the same nsIURIMutator so that we may chain setter operations:
    /// Example:
    /// let newURI = uri.mutate()
    /// .setSpec("http://example.com")
    /// .setQuery("hello")
    /// .finalize();
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5403a6ec-99d7-405e-8b45-9f805bbdfcef")]
	public interface nsIURISetters : nsIURISetSpec
	{
		
		/// <summary>
        /// This setter is different from all other setters because it may be used to
        /// initialize the object. We define it separately allowing mutator implementors
        /// to define it separately, while the rest of the setters may be simply
        /// forwarded to the mutable URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetSpec([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
		
		/// <summary>
        /// Setting the scheme outside of a protocol handler implementation is highly
        /// discouraged since that will generally lead to incorrect results.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aScheme);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetUserPass([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetUsername([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetPassword([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);
		
		/// <summary>
        /// If you setHostPort to a value that only has a host part, the port
        /// will not be reset. To reset the port set it to -1 beforehand.
        /// If setting the host succeeds, this method will return NS_OK, even if
        /// setting the port fails (error in parsing the port, or value out of range)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetHostPort([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetPort(int aPort);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetPathQueryRef([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPathQueryRef);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetRef([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetFilePath([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilePath);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetQuery([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQuery);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIMutator SetQueryWithEncoding([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase query, nsISupports encoding);
	}
	
	/// <summary>nsIURIMutator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4d1f3103-1c44-4dcd-b717-5d22a697a7d9")]
	public interface nsIURIMutator : nsIURISetters
	{
		
		/// <summary>
        /// This setter is different from all other setters because it may be used to
        /// initialize the object. We define it separately allowing mutator implementors
        /// to define it separately, while the rest of the setters may be simply
        /// forwarded to the mutable URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetSpec([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
		
		/// <summary>
        /// Setting the scheme outside of a protocol handler implementation is highly
        /// discouraged since that will generally lead to incorrect results.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aScheme);
		
		/// <summary>Member SetUserPass </summary>
		/// <param name='aUserPass'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetUserPass([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);
		
		/// <summary>Member SetUsername </summary>
		/// <param name='aUsername'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetUsername([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);
		
		/// <summary>Member SetPassword </summary>
		/// <param name='aPassword'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetPassword([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);
		
		/// <summary>
        /// If you setHostPort to a value that only has a host part, the port
        /// will not be reset. To reset the port set it to -1 beforehand.
        /// If setting the host succeeds, this method will return NS_OK, even if
        /// setting the port fails (error in parsing the port, or value out of range)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetHostPort([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);
		
		/// <summary>Member SetHost </summary>
		/// <param name='aHost'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>Member SetPort </summary>
		/// <param name='aPort'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetPort(int aPort);
		
		/// <summary>Member SetPathQueryRef </summary>
		/// <param name='aPathQueryRef'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetPathQueryRef([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPathQueryRef);
		
		/// <summary>Member SetRef </summary>
		/// <param name='aRef'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetRef([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);
		
		/// <summary>Member SetFilePath </summary>
		/// <param name='aFilePath'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetFilePath([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilePath);
		
		/// <summary>Member SetQuery </summary>
		/// <param name='aQuery'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetQuery([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQuery);
		
		/// <summary>Member SetQueryWithEncoding </summary>
		/// <param name='query'> </param>
		/// <param name='encoding'> </param>
		/// <returns>A nsIURIMutator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURIMutator SetQueryWithEncoding([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase query, nsISupports encoding);
		
		/// <summary>
        /// Initializes the URI by reading from the input stream.
        /// The input stream must contain the serialization of the same object type.
        /// See nsISerializable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);
		
		/// <summary>
        /// Initalizes the URI by reading IPC URIParams.
        /// See nsIIPCSerializableURI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Deserialize(nsISupports aParams);
		
		/// <summary>
        /// Finishes changing or constructing the URI and returns an immutable URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI Finalize();
	}
}
