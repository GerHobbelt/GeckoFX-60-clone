// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: xpctest_in.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file xpctest_in.idl
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
	
	
	/// <summary>nsIXPCTestIn </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a3cab49d-ae83-4e63-a735-009b9a759204")]
	public interface nsIXPCTestIn
	{
		
		/// <summary>Member EchoLong </summary>
		/// <param name='l'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int EchoLong(System.Int32  l);
		
		/// <summary>Member EchoShort </summary>
		/// <param name='a'> </param>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short EchoShort(short a);
		
		/// <summary>Member EchoChar </summary>
		/// <param name='c'> </param>
		/// <returns>A System.Char</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		char EchoChar(System.Char  c);
		
		/// <summary>Member EchoBoolean </summary>
		/// <param name='b'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EchoBoolean(System.Boolean  b);
		
		/// <summary>Member EchoOctet </summary>
		/// <param name='o'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr EchoOctet(System.IntPtr  o);
		
		/// <summary>Member EchoLongLong </summary>
		/// <param name='ll'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int EchoLongLong(System.Int32  ll);
		
		/// <summary>Member EchoUnsignedShort </summary>
		/// <param name='us'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint EchoUnsignedShort(ushort us);
		
		/// <summary>Member EchoUnsignedLong </summary>
		/// <param name='ul'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint EchoUnsignedLong(System.UInt32  ul);
		
		/// <summary>Member EchoFloat </summary>
		/// <param name='f'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double EchoFloat(double f);
		
		/// <summary>Member EchoDouble </summary>
		/// <param name='d'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double EchoDouble(double d);
		
		/// <summary>Member EchoWchar </summary>
		/// <param name='wc'> </param>
		/// <returns>A System.Char</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		char EchoWchar(System.Char  wc);
		
		/// <summary>Member EchoString </summary>
		/// <param name='ws'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string EchoString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string ws);
		
		/// <summary>Member EchoPRBool </summary>
		/// <param name='b'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EchoPRBool(System.Boolean  b);
		
		/// <summary>Member EchoPRInt32 </summary>
		/// <param name='l'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int EchoPRInt32(System.Int32  l);
		
		/// <summary>Member EchoPRInt16 </summary>
		/// <param name='l'> </param>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short EchoPRInt16(System.Int16  l);
		
		/// <summary>Member EchoPRInt64 </summary>
		/// <param name='i'> </param>
		/// <returns>A System.Int64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long EchoPRInt64(System.Int64  i);
		
		/// <summary>Member EchoPRUint8 </summary>
		/// <param name='i'> </param>
		/// <returns>A System.Byte</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		byte EchoPRUint8(byte i);
		
		/// <summary>Member EchoPRUint16 </summary>
		/// <param name='i'> </param>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort EchoPRUint16(System.UInt16  i);
		
		/// <summary>Member EchoPRUint32 </summary>
		/// <param name='i'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint EchoPRUint32(System.UInt32  i);
		
		/// <summary>Member EchoPRUint32_2 </summary>
		/// <param name='i'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint EchoPRUint32_2(System.UInt32  i);
		
		/// <summary>Member EchoPRUint64 </summary>
		/// <param name='i'> </param>
		/// <returns>A System.UInt64</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong EchoPRUint64(System.UInt64  i);
		
		/// <summary>Member EchoVoidPtr </summary>
		/// <param name='vs'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr EchoVoidPtr(System.IntPtr  vs);
		
		/// <summary>Member EchoCharPtr </summary>
		/// <param name='cs'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr EchoCharPtr(System.IntPtr  cs);
		
		/// <summary>Member EchoVoid </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EchoVoid();
	}
}