// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIHelperAppLauncherDialog.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIHelperAppLauncherDialog.idl
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
	
	
	/// <summary>nsIHelperAppLauncherDialog </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f3704fdc-8ae6-4eba-a3c3-f02958ac0649")]
	public interface nsIHelperAppLauncherDialog
	{
		
		/// <summary>Member Show </summary>
		/// <param name='aLauncher'> </param>
		/// <param name='aWindowContext'> </param>
		/// <param name='aReason'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Show([MarshalAs(UnmanagedType.Interface)] nsIHelperAppLauncher  aLauncher, [MarshalAs(UnmanagedType.Interface)] nsISupports  aWindowContext, System.UInt32  aReason);
		
		/// <summary>Member PromptForSaveToFile </summary>
		/// <param name='aLauncher'> </param>
		/// <param name='aWindowContext'> </param>
		/// <param name='aDefaultFileName'> </param>
		/// <param name='aSuggestedFileExtension'> </param>
		/// <param name='aForcePrompt'> </param>
		/// <returns>A nsILocalFile</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile PromptForSaveToFile([MarshalAs(UnmanagedType.Interface)] nsIHelperAppLauncher  aLauncher, [MarshalAs(UnmanagedType.Interface)] nsISupports  aWindowContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDefaultFileName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSuggestedFileExtension, System.Boolean  aForcePrompt);
	}
}