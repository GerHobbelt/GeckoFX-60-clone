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
// Generated by IDLImporter from file nsIDOMSVGAnimatedNumber.idl
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
    /// The nsIDOMSVGAnimatedNumber interface is the interface to an SVG
    /// Animated Number.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/SVG11/types.html
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("716e3b11-b03b-49f7-b82d-5383922b0ab3")]
	public interface nsIDOMSVGAnimatedNumber
	{
		
		/// <summary>
        /// The nsIDOMSVGAnimatedNumber interface is the interface to an SVG
        /// Animated Number.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/SVG11/types.html
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetBaseValAttribute();
		
		/// <summary>
        /// The nsIDOMSVGAnimatedNumber interface is the interface to an SVG
        /// Animated Number.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/SVG11/types.html
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseValAttribute(float aBaseVal);
		
		/// <summary>
        /// raises DOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetAnimValAttribute();
	}
}