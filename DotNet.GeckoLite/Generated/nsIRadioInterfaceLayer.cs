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
// Generated by IDLImporter from file nsIRadioInterfaceLayer.idl
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
	
	
	/// <summary>nsIRILTelephonyCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("03eafd60-d138-4f09-81b4-90cd4996b3c7")]
	public interface nsIRILTelephonyCallback
	{
		
		/// <summary>
        /// Notified when a telephony call changes state.
        ///
        /// @param callIndex
        /// Call identifier assigned by the RIL.
        /// @param callState
        /// One of the nsIRadioInterfaceLayer::CALL_STATE_* values.
        /// @param number
        /// Number of the other party.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CallStateChanged(uint callIndex, ushort callState, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number);
		
		/// <summary>
        /// Called when nsIRadioInterfaceLayer is asked to enumerate the current
        /// telephony call state (nsIRadioInterfaceLayer::enumerateCalls). This is
        /// called once per call that is currently managed by the RIL.
        ///
        /// @param callIndex
        /// Call identifier assigned by the RIL.
        /// @param callState
        /// One of the nsIRadioInterfaceLayer::CALL_STATE_* values.
        /// @param number
        /// Number of the other party.
        /// @param isActive
        /// Indicates whether this call is the active one.
        ///
        /// @return true to continue enumeration or false to cancel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EnumerateCallState(uint callIndex, ushort callState, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number, [MarshalAs(UnmanagedType.U1)] bool isActive);
	}
	
	/// <summary>nsIRILDataCallInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("66a55943-e63b-4731-aece-9c04bfc14019")]
	public interface nsIRILDataCallInfo
	{
		
		/// <summary>Member GetCallStateAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCallStateAttribute();
		
		/// <summary>Member GetCidAttribute </summary>
		/// <param name='aCid'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCid);
		
		/// <summary>Member GetApnAttribute </summary>
		/// <param name='aApn'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetApnAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aApn);
	}
	
	/// <summary>nsIRILDataCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cea91bcb-3cfb-42bb-8638-dae89e8870fc")]
	public interface nsIRILDataCallback
	{
		
		/// <summary>
        /// Notified when a data call changes state.
        ///
        /// @param cid
        /// The CID of the data call.
        /// @param interfaceName
        /// Name of the associated network interface.
        /// @param dataState
        /// One of the nsIRadioInterfaceLayer::DATACALL_STATE_* values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DataCallStateChanged([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase cid, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase interfaceName, ushort callState);
		
		/// <summary>
        /// Called when nsIRadioInterfaceLayer is asked to enumerate the current
        /// data call state.
        ///
        /// @param datacalls
        /// Array of nsIRILDataCallInfo objects.
        /// @param length
        /// Lenght of the aforementioned array.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReceiveDataCallList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsIRILDataCallInfo[] dataCalls, uint length);
	}
	
	/// <summary>nsIRadioInterfaceLayer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("78fc7ef6-0941-4fc8-89ff-de9398ef478a")]
	public interface nsIRadioInterfaceLayer
	{
		
		/// <summary>Member GetRadioStateAttribute </summary>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetRadioStateAttribute();
		
		/// <summary>Member RegisterCallback </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterCallback([MarshalAs(UnmanagedType.Interface)] nsIRILTelephonyCallback callback);
		
		/// <summary>Member UnregisterCallback </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterCallback([MarshalAs(UnmanagedType.Interface)] nsIRILTelephonyCallback callback);
		
		/// <summary>
        /// Will continue calling callback.enumerateCallState until the callback
        /// returns false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnumerateCalls([MarshalAs(UnmanagedType.Interface)] nsIRILTelephonyCallback callback);
		
		/// <summary>
        /// Functionality for making and managing phone calls.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Dial([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number);
		
		/// <summary>Member HangUp </summary>
		/// <param name='callIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HangUp(uint callIndex);
		
		/// <summary>Member StartTone </summary>
		/// <param name='dtmfChar'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartTone([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase dtmfChar);
		
		/// <summary>Member StopTone </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopTone();
		
		/// <summary>Member AnswerCall </summary>
		/// <param name='callIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AnswerCall(uint callIndex);
		
		/// <summary>Member RejectCall </summary>
		/// <param name='callIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RejectCall(uint callIndex);
		
		/// <summary>Member GetMicrophoneMutedAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMicrophoneMutedAttribute();
		
		/// <summary>Member SetMicrophoneMutedAttribute </summary>
		/// <param name='aMicrophoneMuted'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrophoneMutedAttribute([MarshalAs(UnmanagedType.U1)] bool aMicrophoneMuted);
		
		/// <summary>Member GetSpeakerEnabledAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpeakerEnabledAttribute();
		
		/// <summary>Member SetSpeakerEnabledAttribute </summary>
		/// <param name='aSpeakerEnabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeakerEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aSpeakerEnabled);
		
		/// <summary>
        /// PDP APIs
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupDataCall(int radioTech, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase apn, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase user, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase passwd, int chappap, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase pdptype);
		
		/// <summary>Member DeactivateDataCall </summary>
		/// <param name='cid'> </param>
		/// <param name='reason'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeactivateDataCall([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase cid, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase reason);
		
		/// <summary>Member GetDataCallList </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataCallList();
		
		/// <summary>Member RegisterDataCallCallback </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterDataCallCallback([MarshalAs(UnmanagedType.Interface)] nsIRILDataCallback callback);
		
		/// <summary>Member UnregisterDataCallCallback </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterDataCallCallback([MarshalAs(UnmanagedType.Interface)] nsIRILDataCallback callback);
		
		/// <summary>
        /// SMS-related functionality.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumberOfMessagesForText([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase text);
		
		/// <summary>Member SendSMS </summary>
		/// <param name='number'> </param>
		/// <param name='message'> </param>
		/// <param name='requestId'> </param>
		/// <param name='processId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendSMS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase number, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase message, int requestId, ulong processId);
	}
	
	/// <summary>nsIRadioInterfaceLayerConsts </summary>
	public class nsIRadioInterfaceLayerConsts
	{
		
		// 
		public const ulong CALL_STATE_UNKNOWN = 0;
		
		// 
		public const ulong CALL_STATE_DIALING = 1;
		
		// 
		public const ulong CALL_STATE_RINGING = 2;
		
		// 
		public const ulong CALL_STATE_BUSY = 3;
		
		// 
		public const ulong CALL_STATE_CONNECTING = 4;
		
		// 
		public const ulong CALL_STATE_CONNECTED = 5;
		
		// 
		public const ulong CALL_STATE_HOLDING = 6;
		
		// 
		public const ulong CALL_STATE_HELD = 7;
		
		// 
		public const ulong CALL_STATE_RESUMING = 8;
		
		// 
		public const ulong CALL_STATE_DISCONNECTING = 9;
		
		// 
		public const ulong CALL_STATE_DISCONNECTED = 10;
		
		// 
		public const ulong CALL_STATE_INCOMING = 11;
		
		// <summary>
        // Keep consistent with GECKO_DATACALL_STATE_* values in ril_consts.js
        // </summary>
		public const ulong DATACALL_STATE_UNKNOWN = 0;
		
		// 
		public const ulong DATACALL_STATE_CONNECTING = 1;
		
		// 
		public const ulong DATACALL_STATE_CONNECTED = 2;
		
		// 
		public const ulong DATACALL_STATE_DISCONNECTING = 3;
		
		// 
		public const ulong DATACALL_STATE_DISCONNECTED = 4;
	}
}
