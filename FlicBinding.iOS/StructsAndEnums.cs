using System;
using ObjCRuntime;

namespace FlicLib {

	[Native]
	public enum SCLFlicButtonConnectionState : long /* nint */ {
		Connected = 0,
		Connecting,
		Disconnected,
		Disconnecting
	}

	[Native]
	public enum SCLFlicButtonMode : long /* nint */ {
		Active = 0,
		ActiveKeepAlive = 1,
		SuperActive = 2,
		Passive = 3
	}

	[Native]
	public enum SCLFlicButtonLEDIndicateCount : long /* nint */ {
		one=1,
		two=2,
		three=3,
		four=4,
		five=5
	}

	[Native]
	public enum SCLFlicButtonTriggerBehavior : long /* nint */ {
		ClickAndHold = 0,
		ClickAndDoubleClick,
		ClickAndDoubleClickAndHold
	}

	[Native]
	public enum SCLFlicError : long /* nint */ {
		Unknown = 0,
		CouldNotCompleteTask,
		ConnectionFailed,
		CouldNotUpdateRSSI,
		DatabaseError,
		UnknownDataReceived,
		VerificationTimeOut,
		BackendUnreachable,
		NoInternetConnection,
		CredentialsNotMatching,
		ButtonIsPrivate,
		CryptographicFailure,
		ButtonDisconnectedDuringVerification
	}

	[Native]
	public enum SCLFlicManagerBluetoothState : long /* nint */ {
		PoweredOn = 0,
		PoweredOff,
		Resetting,
		Unsupported,
		Unauthorized,
		Unknown
	}
}
