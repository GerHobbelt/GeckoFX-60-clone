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
// Generated by IDLImporter from file nsIDOMNetworkStatsManager.idl
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
    /// Represents a data interface for which the manager is recording statistics.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f540615b-d803-43ff-8200-2a9d145a5645")]
	public interface nsIDOMMozNetworkStatsInterface
	{
		
		/// <summary>
        /// Represents a data interface for which the manager is recording statistics.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTypeAttribute();
		
		/// <summary>
        /// Id value is '0' for wifi or the iccid for mobile (SIM).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
	}
	
	/// <summary>nsIDOMMozNetworkStatsAlarm </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("063ebeb2-5c6e-47ae-bdcd-5e6ebdc7a68c")]
	public interface nsIDOMMozNetworkStatsAlarm
	{
		
		/// <summary>Member GetAlarmIdAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAlarmIdAttribute();
		
		/// <summary>Member GetNetworkAttribute </summary>
		/// <returns>A nsIDOMMozNetworkStatsInterface</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozNetworkStatsInterface GetNetworkAttribute();
		
		/// <summary>Member GetThresholdAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetThresholdAttribute();
		
		/// <summary>Member GetDataAttribute </summary>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetDataAttribute();
	}
	
	/// <summary>nsIDOMMozNetworkStatsManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8a66f4c1-0c25-4a66-9fc5-0106947b91f9")]
	public interface nsIDOMMozNetworkStatsManager
	{
		
		/// <summary>
        ///NetworkStatsGetOptions </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetSamples([MarshalAs(UnmanagedType.Interface)] nsIDOMMozNetworkStatsInterface network, Gecko.JsVal start, Gecko.JsVal end, Gecko.JsVal options);
		
		/// <summary>
        ///NetworkStatsAlarmOptions </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest AddAlarm([MarshalAs(UnmanagedType.Interface)] nsIDOMMozNetworkStatsInterface network, int threshold, Gecko.JsVal options);
		
		/// <summary>
        /// Obtain all alarms for those networks returned by getAvailableNetworks().
        /// If a network is provided, only retrieves the alarms for that network.
        /// The network must be one of those returned by getAvailebleNetworks() or an
        /// "InvalidNetwork" exception will be raised.
        ///
        /// Each alarm object has the same fields as that in the system message:
        /// - alarmId
        /// - network
        /// - threshold
        /// - data
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetAllAlarms([MarshalAs(UnmanagedType.Interface)] nsIDOMMozNetworkStatsInterface network);
		
		/// <summary>
        /// Remove all network alarms. If an |alarmId| is provided, then only that
        /// alarm is removed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest RemoveAlarms(int alarmId);
		
		/// <summary>
        /// Remove all stats related with the provided network from DB.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest ClearStats([MarshalAs(UnmanagedType.Interface)] nsIDOMMozNetworkStatsInterface network);
		
		/// <summary>
        /// Remove all stats in the database.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest ClearAllStats();
		
		/// <summary>
        /// Return available networks that used to be saved in the database.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetAvailableNetworks();
		
		/// <summary>
        /// Return available service types that used to be saved in the database.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetAvailableServiceTypes();
		
		/// <summary>
        /// Minimum time in milliseconds between samples stored in the database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSampleRateAttribute();
		
		/// <summary>
        /// Time in milliseconds recorded by the API until present time. All samples
        /// older than maxStorageAge from now are deleted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetMaxStorageAgeAttribute();
	}
	
	/// <summary>nsIDOMMozNetworkStatsManagerConsts </summary>
	public class nsIDOMMozNetworkStatsManagerConsts
	{
		
		// <summary>
        // Constants for known interface types.
        // </summary>
		public const long WIFI = 0;
		
		// 
		public const long MOBILE = 1;
	}
}
