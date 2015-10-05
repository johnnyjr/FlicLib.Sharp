using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']"
	[global::Android.Runtime.Register ("io/flic/lib/FlicError", DoNotGenerateAcw=true)]
	public partial class FlicError : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='BACKEND_UNREACHABLE']"
		[Register ("BACKEND_UNREACHABLE")]
		public const int BackendUnreachable = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='BUTTON_DISCONNECTED_DURING_VERIFICATION']"
		[Register ("BUTTON_DISCONNECTED_DURING_VERIFICATION")]
		public const int ButtonDisconnectedDuringVerification = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='BUTTON_IS_PRIVATE']"
		[Register ("BUTTON_IS_PRIVATE")]
		public const int ButtonIsPrivate = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='CONNECTION_FAILED']"
		[Register ("CONNECTION_FAILED")]
		public const int ConnectionFailed = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='CREDENTIALS_NOT_MATCHING']"
		[Register ("CREDENTIALS_NOT_MATCHING")]
		public const int CredentialsNotMatching = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='CRYPTOGRAPHIC_FAILURE']"
		[Register ("CRYPTOGRAPHIC_FAILURE")]
		public const int CryptographicFailure = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='INVALID_BUTTON']"
		[Register ("INVALID_BUTTON")]
		public const int InvalidButton = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='NO_ERROR']"
		[Register ("NO_ERROR")]
		public const int NoError = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='NO_INTERNET_CONNECTION']"
		[Register ("NO_INTERNET_CONNECTION")]
		public const int NoInternetConnection = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='REBONDING']"
		[Register ("REBONDING")]
		public const int Rebonding = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public const int Unknown = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='UNKNOWN_DATA_RECEIVED']"
		[Register ("UNKNOWN_DATA_RECEIVED")]
		public const int UnknownDataReceived = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/field[@name='VERIFICATION_TIME_OUT']"
		[Register ("VERIFICATION_TIME_OUT")]
		public const int VerificationTimeOut = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/FlicError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicError); }
		}

		protected FlicError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicError']/constructor[@name='FlicError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlicError ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlicError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
