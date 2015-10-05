using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManagerUninitializedCallback']"
	[global::Android.Runtime.Register ("io/flic/lib/FlicManagerUninitializedCallback", DoNotGenerateAcw=true)]
	public partial class FlicManagerUninitializedCallback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/FlicManagerUninitializedCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicManagerUninitializedCallback); }
		}

		protected FlicManagerUninitializedCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManagerUninitializedCallback']/constructor[@name='FlicManagerUninitializedCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlicManagerUninitializedCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlicManagerUninitializedCallback)) {
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

		static Delegate cb_onUninitialized_Lio_flic_lib_FlicManager_;
#pragma warning disable 0169
		static Delegate GetOnUninitialized_Lio_flic_lib_FlicManager_Handler ()
		{
			if (cb_onUninitialized_Lio_flic_lib_FlicManager_ == null)
				cb_onUninitialized_Lio_flic_lib_FlicManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUninitialized_Lio_flic_lib_FlicManager_);
			return cb_onUninitialized_Lio_flic_lib_FlicManager_;
		}

		static void n_OnUninitialized_Lio_flic_lib_FlicManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.FlicManagerUninitializedCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicManagerUninitializedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicManager p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUninitialized (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUninitialized_Lio_flic_lib_FlicManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManagerUninitializedCallback']/method[@name='onUninitialized' and count(parameter)=1 and parameter[1][@type='io.flic.lib.FlicManager']]"
		[Register ("onUninitialized", "(Lio/flic/lib/FlicManager;)V", "GetOnUninitialized_Lio_flic_lib_FlicManager_Handler")]
		public virtual unsafe void OnUninitialized (global::IO.Flic.Lib.FlicManager p0)
		{
			if (id_onUninitialized_Lio_flic_lib_FlicManager_ == IntPtr.Zero)
				id_onUninitialized_Lio_flic_lib_FlicManager_ = JNIEnv.GetMethodID (class_ref, "onUninitialized", "(Lio/flic/lib/FlicManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUninitialized_Lio_flic_lib_FlicManager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUninitialized", "(Lio/flic/lib/FlicManager;)V"), __args);
			} finally {
			}
		}

	}
}
