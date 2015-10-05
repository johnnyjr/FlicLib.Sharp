using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']"
	[global::Android.Runtime.Register ("io/flic/lib/FlicButtonCallbackFlags", DoNotGenerateAcw=true)]
	public partial class FlicButtonCallbackFlags : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']/field[@name='ALL']"
		[Register ("ALL")]
		public const int All = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']/field[@name='CLICK_OR_DOUBLE_CLICK']"
		[Register ("CLICK_OR_DOUBLE_CLICK")]
		public const int ClickOrDoubleClick = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']/field[@name='CLICK_OR_DOUBLE_CLICK_OR_HOLD']"
		[Register ("CLICK_OR_DOUBLE_CLICK_OR_HOLD")]
		public const int ClickOrDoubleClickOrHold = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']/field[@name='CLICK_OR_HOLD']"
		[Register ("CLICK_OR_HOLD")]
		public const int ClickOrHold = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']/field[@name='UP_OR_DOWN']"
		[Register ("UP_OR_DOWN")]
		public const int UpOrDown = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/FlicButtonCallbackFlags", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicButtonCallbackFlags); }
		}

		protected FlicButtonCallbackFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallbackFlags']/constructor[@name='FlicButtonCallbackFlags' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlicButtonCallbackFlags ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlicButtonCallbackFlags)) {
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
