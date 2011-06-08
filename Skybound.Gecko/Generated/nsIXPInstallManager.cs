// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIXPInstallManager.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIXPInstallManager.idl
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
	
	
	/// <summary>nsIXPInstallManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("83fdd52f-2d34-4e22-981d-cf3c4ae76faa")]
	public interface nsIXPInstallManager
	{
		
		/// <summary>Member InitManagerFromChrome </summary>
		/// <param name='aURLs'> </param>
		/// <param name='aURLCount'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitManagerFromChrome([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string aURLs, System.UInt32  aURLCount, [MarshalAs(UnmanagedType.Interface)] nsIXPIProgressDialog  aListener);
		
		/// <summary>Member InitManagerWithHashes </summary>
		/// <param name='aURLs'> </param>
		/// <param name='aHashes'> </param>
		/// <param name='aURLCount'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitManagerWithHashes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)] string aURLs, [MarshalAs(UnmanagedType.LPStr, SizeParamIndex=2)] System.String  aHashes, System.UInt32  aURLCount, [MarshalAs(UnmanagedType.Interface)] nsIXPIProgressDialog  aListener);
		
		/// <summary>Member InitManagerWithInstallInfo </summary>
		/// <param name='aInstallInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitManagerWithInstallInfo([MarshalAs(UnmanagedType.Interface)] nsIXPIInstallInfo  aInstallInfo);
	}
}