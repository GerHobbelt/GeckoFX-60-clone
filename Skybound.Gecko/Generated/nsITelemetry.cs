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
// Generated by IDLImporter from file nsITelemetry.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsITelemetry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("db854295-478d-4de9-8211-d73ed7d81cd0")]
	public interface nsITelemetry
	{
		
		/// <summary>
        /// An object containing a snapshot from all of the currently registered histograms.
        /// { name1: {data1}, name2:{data2}...}
        /// where data is consists of the following properties:
        /// min - Minimal bucket size
        /// max - Maximum bucket size
        /// histogram_type - HISTOGRAM_EXPONENTIAL or HISTOGRAM_LINEAR
        /// counts - array representing contents of the buckets in the histogram
        /// ranges -  an array with calculated bucket sizes
        /// sum - sum of the bucket contents
        /// static - true for histograms defined in TelemetryHistograms.h, false for ones defined with newHistogram
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetHistogramSnapshotsAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// An object containing information about slow SQL prepared statements.
        ///
        /// {
        /// mainThread: { "sqlString1": [<hit count>, <total time>], "sqlString2": [...], ... },
        /// otherThreads: { "sqlString3": [<hit count>, <total time>], "sqlString4": [...], ... }
        /// }
        ///
        /// where:
        /// mainThread: Slow statements that executed on the main thread
        /// otherThreads: Slow statements that executed on a non-main thread
        /// sqlString - String of the offending prepared statement
        /// hit count - The number of times this statement required longer than the threshold time to execute
        /// total time - The sum of all execution times above the threshold time for this statement
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSlowSQLAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// An object whose properties are the names of histograms defined in
        /// TelemetryHistograms.h and whose corresponding values are the textual
        /// comments associated with said histograms.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetRegisteredHistogramsAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// Create and return a histogram where bucket sizes increase exponentially. Parameters:
        ///
        /// @param name Unique histogram name
        /// @param min - Minimal bucket size
        /// @param max - Maximum bucket size
        /// @param bucket_count - number of buckets in the histogram.
        /// @param type - HISTOGRAM_EXPONENTIAL or HISTOGRAM_LINEAR
        /// The returned object has the following functions:
        /// add(int) - Adds an int value to the appropriate bucket
        /// snapshot() - Returns a snapshot of the histogram with the same data fields as in histogramSnapshots()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr NewHistogram([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, uint min, uint max, uint bucket_count, uint histogram_type, System.IntPtr jsContext);
		
		/// <summary>
        /// Create a histogram using the current state of an existing histogram.  The
        /// existing histogram must be registered in TelemetryHistograms.h.
        ///
        /// @param name Unique histogram name
        /// @param existing_name Existing histogram name
        /// The returned object has the same functions as a histogram returned from newHistogram.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr HistogramFrom([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase existing_name, System.IntPtr jsContext);
		
		/// <summary>
        /// Same as newHistogram above, but for histograms registered in TelemetryHistograms.h.
        ///
        /// @param id - unique identifier from TelemetryHistograms.h
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetHistogramById([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase id, System.IntPtr jsContext);
		
		/// <summary>
        /// Set this to false to disable gathering of telemetry statistics.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanRecordAttribute();
		
		/// <summary>
        /// Set this to false to disable gathering of telemetry statistics.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanRecordAttribute([MarshalAs(UnmanagedType.U1)] bool aCanRecord);
	}
}
