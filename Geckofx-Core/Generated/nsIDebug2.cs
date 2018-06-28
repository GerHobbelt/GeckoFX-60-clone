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
// Generated by IDLImporter from file nsIDebug2.idl
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
    /// For use by consumers in scripted languages (JavaScript, Java, Python,
    /// Perl, ...).
    ///
    /// @note C/C++ consumers who are planning to use the nsIDebug2 interface with
    /// the "@mozilla.org/xpcom;1" contract should use NS_DebugBreak from xpcom
    /// glue instead.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9641dc15-10fb-42e3-a285-18be90a5c10b")]
	public interface nsIDebug2
	{
		
		/// <summary>
        /// Whether XPCOM was compiled with DEBUG defined.  This often
        /// correlates to whether other code (e.g., Firefox, XULRunner) was
        /// compiled with DEBUG defined.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsDebugBuildAttribute();
		
		/// <summary>
        /// The number of assertions since process start.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAssertionCountAttribute();
		
		/// <summary>
        /// Whether a debugger is currently attached.
        /// Supports Windows + Mac
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsDebuggerAttachedAttribute();
		
		/// <summary>
        /// Show an assertion and trigger nsIDebug2.break().
        ///
        /// @param aStr assertion message
        /// @param aExpr expression that failed
        /// @param aFile file containing assertion
        /// @param aLine line number of assertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Assertion([MarshalAs(UnmanagedType.LPStr)] string aStr, [MarshalAs(UnmanagedType.LPStr)] string aExpr, [MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);
		
		/// <summary>
        /// Show a warning.
        ///
        /// @param aStr warning message
        /// @param aFile file containing assertion
        /// @param aLine line number of assertion
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Warning([MarshalAs(UnmanagedType.LPStr)] string aStr, [MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);
		
		/// <summary>
        /// Request to break into a debugger.
        ///
        /// @param aFile file containing break request
        /// @param aLine line number of break request
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Break([MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);
		
		/// <summary>
        /// Request the process to trigger a fatal abort.
        ///
        /// @param aFile file containing abort request
        /// @param aLine line number of abort request
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Abort([MarshalAs(UnmanagedType.LPStr)] string aFile, int aLine);
		
		/// <summary>
        /// Request the process to trigger a fatal panic!() from Rust code.
        ///
        /// @param aMessage the string to pass to panic!().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RustPanic([MarshalAs(UnmanagedType.LPStr)] string aMessage);
	}
}
