// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsITestProxy.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsITestProxy.idl
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
	
	
	/// <summary>nsITestProxy </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1979e980-1cfd-11d3-915e-0000863011c4")]
	public interface nsITestProxy
	{
		
		/// <summary>Member Test </summary>
		/// <param name='p1'> </param>
		/// <param name='p2'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Test(System.Int32  p1, System.Int32  p2);
		
		/// <summary>Member Test2 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Test2();
		
		/// <summary>Member Test3 </summary>
		/// <param name='p1'> </param>
		/// <param name='p2'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Test3([MarshalAs(UnmanagedType.Interface)] nsISupports  p1, [MarshalAs(UnmanagedType.Interface)] out nsISupports  p2);
	}
}