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
// Generated by IDLImporter from file nsIScreen.idl
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
	
	
	/// <summary>nsIScreen </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d961f76e-8437-4bc6-9ada-a1c98ace9560")]
	public interface nsIScreen
	{
		
		/// <summary>Member GetRect </summary>
		/// <param name='left'> </param>
		/// <param name='top'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRect(ref int left, ref int top, ref int width, ref int height);
		
		/// <summary>Member GetAvailRect </summary>
		/// <param name='left'> </param>
		/// <param name='top'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAvailRect(ref int left, ref int top, ref int width, ref int height);
		
		/// <summary>
        /// Locks the minimum brightness of the screen, forcing it to be at
        /// least as bright as a certain brightness level. Each call to this
        /// function must eventually be followed by a corresponding call to
        /// unlockMinimumBrightness, with the same brightness level.
        ///
        /// @param brightness A brightness level, one of the above constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockMinimumBrightness(uint brightness);
		
		/// <summary>
        /// Releases a lock on the screen brightness. This must be called
        /// (eventually) after a corresponding call to lockMinimumBrightness.
        ///
        /// @param brightness A brightness level, one of the above constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockMinimumBrightness(uint brightness);
		
		/// <summary>Member GetPixelDepthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPixelDepthAttribute();
		
		/// <summary>Member GetColorDepthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColorDepthAttribute();
		
		/// <summary>
        /// Get/set the screen rotation, on platforms that support changing
        /// screen rotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRotationAttribute();
		
		/// <summary>
        /// Get/set the screen rotation, on platforms that support changing
        /// screen rotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRotationAttribute(uint aRotation);
	}
	
	/// <summary>nsIScreenConsts </summary>
	public class nsIScreenConsts
	{
		
		// <summary>
        // Levels of brightness for the screen, from off to full brightness.
        // </summary>
		public const ulong BRIGHTNESS_DIM = 0;
		
		// 
		public const ulong BRIGHTNESS_FULL = 1;
		
		// <summary>
        //The number of different brightness levels </summary>
		public const ulong BRIGHTNESS_LEVELS = 2;
		
		// <summary>
        // Allowable screen rotations, when the underlying widget toolkit
        // supports rotating the screen.
        //
        // ROTATION_0_DEG is the default, unrotated configuration.
        // </summary>
		public const ulong ROTATION_0_DEG = 0;
		
		// 
		public const ulong ROTATION_90_DEG = 1;
		
		// 
		public const ulong ROTATION_180_DEG = 2;
		
		// 
		public const ulong ROTATION_270_DEG = 3;
	}
}
