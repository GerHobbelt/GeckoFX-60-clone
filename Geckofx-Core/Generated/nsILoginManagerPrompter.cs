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
// Generated by IDLImporter from file nsILoginManagerPrompter.idl
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
	[Guid("425f73b9-b2db-4e8a-88c5-9ac2512934ce")]
	public interface nsILoginManagerPrompter
	{
		
		/// <summary>
        /// Initialize the prompter. Must be called before using other interfaces.
        ///
        /// @param aWindow
        /// The window in which the user is doing some login-related action that's
        /// resulting in a need to prompt them for something. The prompt
        /// will be associated with this window (or, if a notification bar
        /// is being used, topmost opener in some cases).
        ///
        /// aWindow can be null if there is no associated window, e.g. in a JSM
        /// or Sandbox. In this case there will be no checkbox to save the login
        /// since the window is needed to know if this is a private context.
        ///
        /// If this window is a content window, the corresponding window and browser
        /// elements will be calculated. If this window is a chrome window, the
        /// corresponding browser element needs to be set using setBrowser.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// The browser this prompter is being created for.
        /// This is required if the init function received a chrome window as argument.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetBrowserAttribute();
		
		/// <summary>
        /// The browser this prompter is being created for.
        /// This is required if the init function received a chrome window as argument.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBrowserAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aBrowser);
		
		/// <summary>
        /// The opener that was used to open the window passed to init.
        /// The opener can be used to determine in which window the prompt
        /// should be shown. Must be a content window that is not a frame window,
        /// make sure to pass the top window using e.g. window.top.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetOpenerAttribute();
		
		/// <summary>
        /// The opener that was used to open the window passed to init.
        /// The opener can be used to determine in which window the prompt
        /// should be shown. Must be a content window that is not a frame window,
        /// make sure to pass the top window using e.g. window.top.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOpenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aOpener);
		
		/// <summary>
        /// Ask the user if they want to save a login (Yes, Never, Not Now)
        ///
        /// @param aLogin
        /// The login to be saved.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PromptToSavePassword([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLogin);
		
		/// <summary>
        /// Ask the user if they want to change a login's password or username.
        /// If the user consents, modifyLogin() will be called.
        ///
        /// @param aOldLogin
        /// The existing login (with the old password).
        /// @param aNewLogin
        /// The new login.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PromptToChangePassword([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aOldLogin, [MarshalAs(UnmanagedType.Interface)] nsILoginInfo aNewLogin);
		
		/// <summary>
        /// Ask the user if they want to change the password for one of
        /// multiple logins, when the caller can't determine exactly which
        /// login should be changed. If the user consents, modifyLogin() will
        /// be called.
        ///
        /// @param logins
        /// An array of existing logins.
        /// @param count
        /// (length of the array)
        /// @param aNewLogin
        /// The new login.
        ///
        /// Note: Because the caller does not know the username of the login
        /// to be changed, aNewLogin.username and aNewLogin.usernameField
        /// will be set (using the user's selection) before modifyLogin()
        /// is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PromptToChangePasswordWithUsernames([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsILoginInfo[] logins, uint count, [MarshalAs(UnmanagedType.Interface)] nsILoginInfo aNewLogin);
	}
}
