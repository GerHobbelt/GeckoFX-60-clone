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
// Generated by IDLImporter from file nsIApplicationChooser.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8144404d-e6c7-4861-bcca-47de912ee811")]
	public interface nsIApplicationChooserFinishedCallback
	{
		
		/// <summary>
        ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        ///
        /// This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Done([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp handlerApp);
	}
	
	/// <summary>nsIApplicationChooser </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8413fc42-d6c4-4d78-bf70-64cd78ebcc5c")]
	public interface nsIApplicationChooser
	{
		
		/// <summary>
        /// Initialize the application chooser picker widget.  The application chooser
        /// is not valid until this method is called.
        ///
        /// @param      parent   nsIDOMWindow parent.  This dialog will be dependent
        /// on this parent. parent must be non-null.
        /// @param      title    The title for the file widget
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase title);
		
		/// <summary>
        /// Open application chooser dialog.
        ///
        /// @param    contentType   content type of file to open
        /// @param    applicationChooserFinishedCallback  callback fuction to run when dialog is closed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase contentType, [MarshalAs(UnmanagedType.Interface)] nsIApplicationChooserFinishedCallback applicationChooserFinishedCallback);
	}
}
