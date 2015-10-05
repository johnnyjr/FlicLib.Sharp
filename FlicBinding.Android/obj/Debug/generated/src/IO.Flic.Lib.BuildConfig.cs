using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']"
	[global::Android.Runtime.Register ("io/flic/lib/BuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class BuildConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/field[@name='APPLICATION_ID']"
		[Register ("APPLICATION_ID")]
		public const string ApplicationId = (string) "io.flic.lib";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/field[@name='BUILD_TYPE']"
		[Register ("BUILD_TYPE")]
		public const string BuildType = (string) "debug";

		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/field[@name='FLAVOR']"
		[Register ("FLAVOR")]
		public const string Flavor = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/field[@name='VERSION_CODE']"
		[Register ("VERSION_CODE")]
		public const int VersionCode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/field[@name='VERSION_NAME']"
		[Register ("VERSION_NAME")]
		public const string VersionName = (string) "1.0";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/BuildConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BuildConfig); }
		}

		internal BuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='BuildConfig']/constructor[@name='BuildConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BuildConfig)) {
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
