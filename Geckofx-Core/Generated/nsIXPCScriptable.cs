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
// Generated by IDLImporter from file nsIXPCScriptable.idl
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
    /// Note: This is not really an XPCOM interface.  For example, callers must
    /// guarantee that they set the *_retval of the various methods that return a
    /// boolean to PR_TRUE before making the call.  Implementations may skip writing
    /// to *_retval unless they want to return PR_FALSE.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("19b70b26-7c3f-437f-a04a-2a8f9e28b617")]
	public interface nsIXPCScriptable
	{
		
		/// <summary>
        /// Note: This is not really an XPCOM interface.  For example, callers must
        /// guarantee that they set the *_retval of the various methods that return a
        /// boolean to PR_TRUE before making the call.  Implementations may skip writing
        /// to *_retval unless they want to return PR_FALSE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aClassName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetScriptableFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        nsISupports GetClass();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        nsISupports GetJSClass();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreCreate([MarshalAs(UnmanagedType.Interface)] nsISupports nativeObj, System.IntPtr cx, System.IntPtr globalObj, ref System.IntPtr parentObj);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Enumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewEnumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr properties);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Resolve([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, [MarshalAs(UnmanagedType.U1)] ref bool resolvedp);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finalize([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr fop, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Call([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr args);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Construct([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr args);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasInstance([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, ref Gecko.JsVal val, [MarshalAs(UnmanagedType.U1)] ref bool bp);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreatePrototype(System.IntPtr cx, System.IntPtr proto);
	}
}
