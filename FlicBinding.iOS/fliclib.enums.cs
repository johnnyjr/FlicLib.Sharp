namespace FlicLib {

	[Native]
	public enum SCLFlicButtonConnectionState : int /* nint */ {
		Connected = 0,
		Connecting,
		Disconnected,
		Disconnecting
	}

	[Native]
	public enum SCLFlicButtonMode : int /* nint */ {
		Active = 0,
		ActiveKeepAlive = 1,
		SuperActive = 2,
		Passive = 3
	}

	[Native]
	public enum SCLFlicButtonLEDIndicateCount : int /* nint */ {
		1 = 1,
		2,
		3,
		4,
		5
	}

	[Native]
	public enum SCLFlicButtonTriggerBehavior : int /* nint */ {
		ClickAndHold = 0,
		ClickAndDoubleClick,
		ClickAndDoubleClickAndHold
	}

	[Native]
	public enum SCLFlicError : int /* nint */ {
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
	public enum SCLFlicManagerBluetoothState : int /* nint */ {
		PoweredOn = 0,
		PoweredOff,
		Resetting,
		Unsupported,
		Unauthorized,
		Unknown
	}
}
