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
// Generated by IDLImporter from file nsIPerformanceStats.idl
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
    /// Identification details for a performance group.
    ///
    /// A performance group is a set of JavaScript compartments whose
    /// performance is observed as a single entity. Typical examples of
    /// performance groups: an add-on, a webpage without its frames, a
    /// webpage with all its frames, the entire JS runtime, ...
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("994c56be-939a-4f20-8364-124f6422d86a")]
	public interface nsIPerformanceGroupDetails
	{
		
		/// <summary>
        /// An identifier unique to the component.
        ///
        /// This identifier is somewhat human-readable to aid with debugging,
        /// but clients should not rely upon the format.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGroupIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGroupId);
		
		/// <summary>
        /// A somewhat human-readable name for the component.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		/// <summary>
        /// If the component is an add-on, the ID of the addon,
        /// otherwise an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAddonIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAddonId);
		
		/// <summary>
        /// If the component is code executed in a window, the ID of the topmost
        /// outer window (i.e. the tab), otherwise 0.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetWindowIdAttribute();
		
		/// <summary>
        /// `true` if this component is executed with system privileges
        /// (e.g. the platform itself or an add-on), `false` otherwise
        /// (e.g. webpages).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSystemAttribute();
		
		/// <summary>
        /// The process running this group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetProcessIdAttribute();
		
		/// <summary>
        /// `true` if the code is executed in a content process, `false` otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsContentProcessAttribute();
	}
	
	/// <summary>
    /// Snapshot of the performance of a component, e.g. an add-on, a web
    /// page, system built-ins, a module or the entire process itself.
    ///
    /// All values are monotonic and are updated only when
    /// `nsIPerformanceStatsService.isStopwatchActive` is `true`.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8a635d4b-aa56-466b-9a7d-9f91ca9405ef")]
	public interface nsIPerformanceStats : nsIPerformanceGroupDetails
	{
		
		/// <summary>
        /// An identifier unique to the component.
        ///
        /// This identifier is somewhat human-readable to aid with debugging,
        /// but clients should not rely upon the format.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetGroupIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGroupId);
		
		/// <summary>
        /// A somewhat human-readable name for the component.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		/// <summary>
        /// If the component is an add-on, the ID of the addon,
        /// otherwise an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAddonIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAddonId);
		
		/// <summary>
        /// If the component is code executed in a window, the ID of the topmost
        /// outer window (i.e. the tab), otherwise 0.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ulong GetWindowIdAttribute();
		
		/// <summary>
        /// `true` if this component is executed with system privileges
        /// (e.g. the platform itself or an add-on), `false` otherwise
        /// (e.g. webpages).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsSystemAttribute();
		
		/// <summary>
        /// The process running this group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ulong GetProcessIdAttribute();
		
		/// <summary>
        /// `true` if the code is executed in a content process, `false` otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsContentProcessAttribute();
		
		/// <summary>
        /// Total amount of time spent executing code in this group, in
        /// microseconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTotalUserTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTotalSystemTimeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTotalCPOWTimeAttribute();
		
		/// <summary>
        /// Total number of times code execution entered this group,
        /// since process launch. This may be greater than the number
        /// of times we have entered the event loop.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTicksAttribute();
		
		/// <summary>
        /// Jank indicator.
        ///
        /// durations[i] == number of times execution of this group
        /// lasted at lest 2^i ms.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDurations(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.UInt32[] long aNumberOfOccurrences);
	}
	
	/// <summary>
    /// A snapshot of the performance data of the process.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("13cc235b-739e-4690-b0e3-d89cbe036a93")]
	public interface nsIPerformanceSnapshot
	{
		
		/// <summary>
        /// Data on all individual components.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetComponentsData();
		
		/// <summary>
        /// Information on the process itself.
        ///
        /// This contains the total amount of time spent executing JS code,
        /// the total amount of time spent waiting for system calls while
        /// executing JS code, the total amount of time performing blocking
        /// inter-process calls, etc.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPerformanceStats GetProcessData();
	}
	
	/// <summary>
    /// A performance alert.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("463c92d9-2e55-4f57-9b22-7badbbdfb2b7")]
	public interface nsIPerformanceAlert
	{
		
		/// <summary>
        /// The reason for the alert.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetReasonAttribute();
		
		/// <summary>
        /// Longest interval spent executing code in this group
        /// since the latest alert, in microseconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetHighestJankAttribute();
		
		/// <summary>
        /// Longest interval spent executing CPOW in this group
        /// since the latest alert, in microseconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetHighestCPOWAttribute();
	}
	
	/// <summary>nsIPerformanceAlertConsts </summary>
	public class nsIPerformanceAlertConsts
	{
		
		// <summary>
        // Alert was caused by jank exceeding the threshold.
        // </summary>
		public const ulong REASON_JANK = 0;
	}
	
	/// <summary>
    /// An observer for slow performance alerts.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b746a929-3fec-420b-8ed8-c35d71995e05")]
	public interface nsIPerformanceObserver
	{
		
		/// <summary>
        /// @param target The performance group that caused the jank.
        /// @param alert The performance cost that triggered the alert.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Observe([MarshalAs(UnmanagedType.Interface)] nsIPerformanceGroupDetails target, [MarshalAs(UnmanagedType.Interface)] nsIPerformanceAlert alert);
	}
	
	/// <summary>
    /// A part of the system that may be observed for slow performance.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b85720d0-e328-4342-9e46-8ca1acf8c70e")]
	public interface nsIPerformanceObservable
	{
		
		/// <summary>
        /// If a single group is being observed, information on this group.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPerformanceGroupDetails GetTargetAttribute();
		
		/// <summary>
        /// Add an observer that will be informed in case of jank.
        ///
        /// Set `jankAlertThreshold` to determine how much jank is needed
        /// to trigger alerts.
        ///
        /// If the same observer is added more than once, it will be
        /// triggered as many times as it has been added.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddJankObserver([MarshalAs(UnmanagedType.Interface)] nsIPerformanceObserver observer);
		
		/// <summary>
        /// Remove an observer previously added with `addJankObserver`.
        ///
        /// Noop if the observer hasn't been added.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveJankObserver([MarshalAs(UnmanagedType.Interface)] nsIPerformanceObserver observer);
	}
	
	/// <summary>nsIPerformanceStatsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5675d1d9-638e-4af0-9392-b04aacfad79a")]
	public interface nsIPerformanceStatsService
	{
		
		/// <summary>
        /// `true` if we should monitor CPOW, `false` otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsMonitoringCPOWAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// `true` if we should monitor CPOW, `false` otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsMonitoringCPOWAttribute([MarshalAs(UnmanagedType.U1)] bool aIsMonitoringCPOW, System.IntPtr jsContext);
		
		/// <summary>
        /// `true` if we should monitor jank, `false` otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsMonitoringJankAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// `true` if we should monitor jank, `false` otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsMonitoringJankAttribute([MarshalAs(UnmanagedType.U1)] bool aIsMonitoringJank, System.IntPtr jsContext);
		
		/// <summary>
        /// `true` if all compartments need to be monitored individually,
        /// `false` if only performance groups (i.e. entire add-ons, entire
        /// webpages, etc.) need to be monitored.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsMonitoringPerCompartmentAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// `true` if all compartments need to be monitored individually,
        /// `false` if only performance groups (i.e. entire add-ons, entire
        /// webpages, etc.) need to be monitored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsMonitoringPerCompartmentAttribute([MarshalAs(UnmanagedType.U1)] bool aIsMonitoringPerCompartment, System.IntPtr jsContext);
		
		/// <summary>
        /// Capture a snapshot of the performance data.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPerformanceSnapshot GetSnapshot(System.IntPtr jsContext);
		
		/// <summary>
        /// The threshold, in microseconds, above which a performance group is
        /// considered "slow" and should raise performance alerts.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetJankAlertThresholdAttribute();
		
		/// <summary>
        /// The threshold, in microseconds, above which a performance group is
        /// considered "slow" and should raise performance alerts.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetJankAlertThresholdAttribute(ulong aJankAlertThreshold);
		
		/// <summary>
        /// A buffering delay, in milliseconds, used by the service to
        /// regroup performance alerts, before observers are actually
        /// noticed. Higher delays let the system avoid redundant
        /// notifications for the same group, and are generally better for
        /// performance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetJankAlertBufferingDelayAttribute();
		
		/// <summary>
        /// A buffering delay, in milliseconds, used by the service to
        /// regroup performance alerts, before observers are actually
        /// noticed. Higher delays let the system avoid redundant
        /// notifications for the same group, and are generally better for
        /// performance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetJankAlertBufferingDelayAttribute(uint aJankAlertBufferingDelay);
		
		/// <summary>
        /// Get a nsIPerformanceObservable representing an add-on. This
        /// observable may then be used to (un)register for watching
        /// performance alerts for this add-on.
        ///
        /// Note that this method has no way of finding out whether an add-on with this
        /// id is installed on the system. Also note that this covers only the current
        /// process.
        ///
        /// Use special add-on name "*" to get an observable that may be used
        /// to (un)register for watching performance alerts of all add-ons at
        /// once.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPerformanceObservable GetObservableAddon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase addonId);
		
		/// <summary>
        /// Get a nsIPerformanceObservable representing a DOM window. This
        /// observable may then be used to (un)register for watching
        /// performance alerts for this window.
        ///
        /// Note that this covers only the current process.
        ///
        /// Use special window id 0 to get an observable that may be used to
        /// (un)register for watching performance alerts of all windows at
        /// once.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPerformanceObservable GetObservableWindow(ulong windowId);
	}
}
