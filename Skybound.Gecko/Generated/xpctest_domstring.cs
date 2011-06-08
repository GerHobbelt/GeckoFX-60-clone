// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: xpctest_domstring.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file xpctest_domstring.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIXPCTestDOMString </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("646d0b6b-6872-43b9-aa73-3c6b89ac3080")]
	public interface nsIXPCTestDOMString
	{
		
		/// <summary>Member HereHaveADOMString </summary>
		/// <param name='str'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HereHaveADOMString([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		/// <summary>Member DontKeepThisOne </summary>
		/// <param name='str'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DontKeepThisOne([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		/// <summary>Member GiveDOMStringTo </summary>
		/// <param name='recv'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GiveDOMStringTo([MarshalAs(UnmanagedType.LPStruct)] nsAString recv);
		
		/// <summary>Member PassDOMStringThroughTo </summary>
		/// <param name='str'> </param>
		/// <param name='recv'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PassDOMStringThroughTo([MarshalAs(UnmanagedType.LPStruct)] nsAString str, [MarshalAs(UnmanagedType.LPStruct)] nsAString recv);
	}
}