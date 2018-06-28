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
// Generated by IDLImporter from file nsIMessageLoop.idl
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
    /// This service allows access to the current thread's Chromium MessageLoop
    /// instance, with some extra sugar added.  If you're calling from C++, it may
    /// or may not make sense for you to use this interface.  If you're calling from
    /// JS, you don't have a choice!
    ///
    /// Right now, you can only call PostIdleTask(), and the wrath of khuey is
    /// stopping you from adding other methods.
    ///
    /// nsIMessageLoop's contractid is "@mozilla.org/message-loop;1".
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3E8C58E8-E52C-43E0-8E66-669CA788FF5F")]
	public interface nsIMessageLoop
	{
		
		/// <summary>
        /// Posts a task to be run when this thread's message loop is idle, or after
        /// ensureRunsAfterMS milliseconds have elapsed.  (That is, the task is
        /// guaranteed to run /eventually/.)
        ///
        /// Note that if the event loop is busy, we will hold a reference to the task
        /// until ensureRunsAfterMS milliseconds have elapsed.  Be careful when
        /// specifying long timeouts and tasks which hold references to windows or
        /// other large objects, because you can leak memory in a difficult-to-detect
        /// way!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostIdleTask([MarshalAs(UnmanagedType.Interface)] nsIRunnable task, uint ensureRunsAfterMS);
	}
}
