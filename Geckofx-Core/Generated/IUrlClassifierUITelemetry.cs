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
// Generated by IDLImporter from file IUrlClassifierUITelemetry.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6c62ce5-3a95-41bb-b0f1-8cd4f4ca00e3")]
	public interface IUrlClassifierUITelemetry
	{
	}
	
	/// <summary>IUrlClassifierUITelemetryConsts </summary>
	public class IUrlClassifierUITelemetryConsts
	{
		
		// <summary>
        //-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        //
        // This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const long WARNING_MALWARE_PAGE_TOP = 1;
		
		// 
		public const long WARNING_MALWARE_PAGE_TOP_WHY_BLOCKED = 2;
		
		// 
		public const long WARNING_MALWARE_PAGE_TOP_GET_ME_OUT_OF_HERE = 3;
		
		// 
		public const long WARNING_MALWARE_PAGE_TOP_IGNORE_WARNING = 4;
		
		// 
		public const long WARNING_MALWARE_PAGE_FRAME = 5;
		
		// 
		public const long WARNING_MALWARE_PAGE_FRAME_WHY_BLOCKED = 6;
		
		// 
		public const long WARNING_MALWARE_PAGE_FRAME_GET_ME_OUT_OF_HERE = 7;
		
		// 
		public const long WARNING_MALWARE_PAGE_FRAME_IGNORE_WARNING = 8;
		
		// 
		public const long WARNING_PHISHING_PAGE_TOP = 9;
		
		// 
		public const long WARNING_PHISHING_PAGE_TOP_WHY_BLOCKED = 10;
		
		// 
		public const long WARNING_PHISHING_PAGE_TOP_GET_ME_OUT_OF_HERE = 11;
		
		// 
		public const long WARNING_PHISHING_PAGE_TOP_IGNORE_WARNING = 12;
		
		// 
		public const long WARNING_PHISHING_PAGE_FRAME = 13;
		
		// 
		public const long WARNING_PHISHING_PAGE_FRAME_WHY_BLOCKED = 14;
		
		// 
		public const long WARNING_PHISHING_PAGE_FRAME_GET_ME_OUT_OF_HERE = 15;
		
		// 
		public const long WARNING_PHISHING_PAGE_FRAME_IGNORE_WARNING = 16;
		
		// 
		public const long WARNING_UNWANTED_PAGE_TOP = 17;
		
		// 
		public const long WARNING_UNWANTED_PAGE_TOP_WHY_BLOCKED = 18;
		
		// 
		public const long WARNING_UNWANTED_PAGE_TOP_GET_ME_OUT_OF_HERE = 19;
		
		// 
		public const long WARNING_UNWANTED_PAGE_TOP_IGNORE_WARNING = 20;
		
		// 
		public const long WARNING_UNWANTED_PAGE_FRAME = 21;
		
		// 
		public const long WARNING_UNWANTED_PAGE_FRAME_WHY_BLOCKED = 22;
		
		// 
		public const long WARNING_UNWANTED_PAGE_FRAME_GET_ME_OUT_OF_HERE = 23;
		
		// 
		public const long WARNING_UNWANTED_PAGE_FRAME_IGNORE_WARNING = 24;
		
		// 
		public const long WARNING_HARMFUL_PAGE_TOP = 25;
		
		// 
		public const long WARNING_HARMFUL_PAGE_TOP_WHY_BLOCKED = 26;
		
		// 
		public const long WARNING_HARMFUL_PAGE_TOP_GET_ME_OUT_OF_HERE = 27;
		
		// 
		public const long WARNING_HARMFUL_PAGE_TOP_IGNORE_WARNING = 28;
		
		// 
		public const long WARNING_HARMFUL_PAGE_FRAME = 29;
		
		// 
		public const long WARNING_HARMFUL_PAGE_FRAME_WHY_BLOCKED = 30;
		
		// 
		public const long WARNING_HARMFUL_PAGE_FRAME_GET_ME_OUT_OF_HERE = 31;
		
		// 
		public const long WARNING_HARMFUL_PAGE_FRAME_IGNORE_WARNING = 32;
	}
}
