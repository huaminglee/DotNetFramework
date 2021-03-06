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
// Generated by IDLImporter from file nsIProfiler.idl
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
	
	
	/// <summary>
    ///-*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    /// Version: MPL 1.1/GPL 2.0/LGPL 2.1
    ///
    /// The contents of this file are subject to the Mozilla Public License Version
    /// 1.1 (the "License"); you may not use this file except in compliance with
    /// the License. You may obtain a copy of the License at
    /// http://www.mozilla.org/MPL/
    ///
    /// Software distributed under the License is distributed on an "AS IS" basis,
    /// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
    /// for the specific language governing rights and limitations under the
    /// License.
    ///
    /// The Initial Developer of the Original Code is
    /// Mozilla Foundation
    /// Portions created by the Initial Developer are Copyright (C) 2011
    /// the Initial Developer. All Rights Reserved.
    ///
    /// Contributor(s):
    /// Benoit Girard <bgirard@mozilla.com>
    ///
    /// Alternatively, the contents of this file may be used under the terms of
    /// either of the GNU General Public License Version 2 or later (the "GPL"),
    /// or the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
    /// in which case the provisions of the GPL or the LGPL are applicable instead
    /// of those above. If you wish to allow use of your version of this file only
    /// under the terms of either the GPL or the LGPL, and not to allow others to
    /// use your version of this file under the terms of the MPL, indicate your
    /// decision by deleting the provisions above and replace them with the notice
    /// and other provisions required by the GPL or the LGPL. If you do not delete
    /// the provisions above, a recipient may use your version of this file under
    /// the terms of any one of the MPL, the GPL or the LGPL.
    ///
    /// ***** END LICENSE BLOCK ***** </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e388fded-1321-41af-a988-861a2bc5cfc3")]
	public interface nsIProfiler
	{
		
		/// <summary>
        ///-*- Mode: IDL; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        /// Version: MPL 1.1/GPL 2.0/LGPL 2.1
        ///
        /// The contents of this file are subject to the Mozilla Public License Version
        /// 1.1 (the "License"); you may not use this file except in compliance with
        /// the License. You may obtain a copy of the License at
        /// http://www.mozilla.org/MPL/
        ///
        /// Software distributed under the License is distributed on an "AS IS" basis,
        /// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
        /// for the specific language governing rights and limitations under the
        /// License.
        ///
        /// The Initial Developer of the Original Code is
        /// Mozilla Foundation
        /// Portions created by the Initial Developer are Copyright (C) 2011
        /// the Initial Developer. All Rights Reserved.
        ///
        /// Contributor(s):
        /// Benoit Girard <bgirard@mozilla.com>
        ///
        /// Alternatively, the contents of this file may be used under the terms of
        /// either of the GNU General Public License Version 2 or later (the "GPL"),
        /// or the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
        /// in which case the provisions of the GPL or the LGPL are applicable instead
        /// of those above. If you wish to allow use of your version of this file only
        /// under the terms of either the GPL or the LGPL, and not to allow others to
        /// use your version of this file under the terms of the MPL, indicate your
        /// decision by deleting the provisions above and replace them with the notice
        /// and other provisions required by the GPL or the LGPL. If you do not delete
        /// the provisions above, a recipient may use your version of this file under
        /// the terms of any one of the MPL, the GPL or the LGPL.
        ///
        /// ***** END LICENSE BLOCK ***** </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartProfiler(uint aInterval, uint aEntries, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] string[] aFeatures, uint aFeatureCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopProfiler();
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetProfile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetProfileData(System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsActive();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponsivenessTimes(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref double[] aResult);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFeatures(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] aFeatures);
		
		/// <summary>
        /// Returns a JSON string of an array of shared library objects.
        /// Every object has three properties: start, end, and name.
        /// start and end are integers describing the address range that the library
        /// occupies in memory. name is the path of the library as a string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSharedLibraryInformation([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
	}
}
