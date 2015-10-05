using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']"
	[global::Android.Runtime.Register ("io/flic/lib/FlicManager", DoNotGenerateAcw=true)]
	public sealed partial class FlicManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/field[@name='GRAB_BUTTON_REQUEST_CODE']"
		[Register ("GRAB_BUTTON_REQUEST_CODE")]
		public const int GrabButtonRequestCode = (int) 52875;
		// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager.FlicManagerCallback']"
		[global::Android.Runtime.Register ("io/flic/lib/FlicManager$FlicManagerCallback", DoNotGenerateAcw=true)]
		public partial class FlicManagerCallback : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/flic/lib/FlicManager$FlicManagerCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FlicManagerCallback); }
			}

			protected FlicManagerCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onInitialized;
#pragma warning disable 0169
			static Delegate GetOnInitializedHandler ()
			{
				if (cb_onInitialized == null)
					cb_onInitialized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInitialized);
				return cb_onInitialized;
			}

			static void n_OnInitialized (IntPtr jnienv, IntPtr native__this)
			{
				global::IO.Flic.Lib.FlicManager.FlicManagerCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicManager.FlicManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInitialized ();
			}
#pragma warning restore 0169

			static IntPtr id_onInitialized;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager.FlicManagerCallback']/method[@name='onInitialized' and count(parameter)=0]"
			[Register ("onInitialized", "()V", "GetOnInitializedHandler")]
			public virtual unsafe void OnInitialized ()
			{
				if (id_onInitialized == IntPtr.Zero)
					id_onInitialized = JNIEnv.GetMethodID (class_ref, "onInitialized", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInitialized);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInitialized", "()V"));
				} finally {
				}
			}

			static Delegate cb_onUninitialized;
#pragma warning disable 0169
			static Delegate GetOnUninitializedHandler ()
			{
				if (cb_onUninitialized == null)
					cb_onUninitialized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUninitialized);
				return cb_onUninitialized;
			}

			static void n_OnUninitialized (IntPtr jnienv, IntPtr native__this)
			{
				global::IO.Flic.Lib.FlicManager.FlicManagerCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicManager.FlicManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUninitialized ();
			}
#pragma warning restore 0169

			static IntPtr id_onUninitialized;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager.FlicManagerCallback']/method[@name='onUninitialized' and count(parameter)=0]"
			[Register ("onUninitialized", "()V", "GetOnUninitializedHandler")]
			public virtual unsafe void OnUninitialized ()
			{
				if (id_onUninitialized == IntPtr.Zero)
					id_onUninitialized = JNIEnv.GetMethodID (class_ref, "onUninitialized", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onUninitialized);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUninitialized", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/FlicManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicManager); }
		}

		internal FlicManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_getKnownButtons;
		public unsafe global::System.Collections.Generic.IList<global::IO.Flic.Lib.FlicButton> KnownButtons {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='getKnownButtons' and count(parameter)=0]"
			[Register ("getKnownButtons", "()Ljava/util/List;", "GetGetKnownButtonsHandler")]
			get {
				if (id_getKnownButtons == IntPtr.Zero)
					id_getKnownButtons = JNIEnv.GetMethodID (class_ref, "getKnownButtons", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::IO.Flic.Lib.FlicButton>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getKnownButtons), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_completeGrabButton_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='completeGrabButton' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("completeGrabButton", "(IILandroid/content/Intent;)Lio/flic/lib/FlicButton;", "")]
		public unsafe global::IO.Flic.Lib.FlicButton CompleteGrabButton (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_completeGrabButton_IILandroid_content_Intent_ == IntPtr.Zero)
				id_completeGrabButton_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "completeGrabButton", "(IILandroid/content/Intent;)Lio/flic/lib/FlicButton;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::IO.Flic.Lib.FlicButton __ret = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (JNIEnv.CallObjectMethod  (Handle, id_completeGrabButton_IILandroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_destroyInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='destroyInstance' and count(parameter)=0]"
		[Register ("destroyInstance", "()V", "")]
		public static unsafe void DestroyInstance ()
		{
			if (id_destroyInstance == IntPtr.Zero)
				id_destroyInstance = JNIEnv.GetStaticMethodID (class_ref, "destroyInstance", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destroyInstance);
			} finally {
			}
		}

		static IntPtr id_forgetButton_Lio_flic_lib_FlicButton_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='forgetButton' and count(parameter)=1 and parameter[1][@type='io.flic.lib.FlicButton']]"
		[Register ("forgetButton", "(Lio/flic/lib/FlicButton;)V", "")]
		public unsafe void ForgetButton (global::IO.Flic.Lib.FlicButton p0)
		{
			if (id_forgetButton_Lio_flic_lib_FlicButton_ == IntPtr.Zero)
				id_forgetButton_Lio_flic_lib_FlicButton_ = JNIEnv.GetMethodID (class_ref, "forgetButton", "(Lio/flic/lib/FlicButton;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_forgetButton_Lio_flic_lib_FlicButton_, __args);
			} finally {
			}
		}

		static IntPtr id_getButtonByDeviceId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='getButtonByDeviceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getButtonByDeviceId", "(Ljava/lang/String;)Lio/flic/lib/FlicButton;", "")]
		public unsafe global::IO.Flic.Lib.FlicButton GetButtonByDeviceId (string p0)
		{
			if (id_getButtonByDeviceId_Ljava_lang_String_ == IntPtr.Zero)
				id_getButtonByDeviceId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getButtonByDeviceId", "(Ljava/lang/String;)Lio/flic/lib/FlicButton;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Flic.Lib.FlicButton __ret = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (JNIEnv.CallObjectMethod  (Handle, id_getButtonByDeviceId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='io.flic.lib.FlicManagerInitializedCallback']]"
		[Register ("getInstance", "(Landroid/content/Context;Lio/flic/lib/FlicManagerInitializedCallback;)V", "")]
		public static unsafe void GetInstance (global::Android.Content.Context p0, global::IO.Flic.Lib.FlicManagerInitializedCallback p1)
		{
			if (id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Lio/flic/lib/FlicManagerInitializedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_Lio_flic_lib_FlicManagerUninitializedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='io.flic.lib.FlicManagerInitializedCallback'] and parameter[3][@type='io.flic.lib.FlicManagerUninitializedCallback']]"
		[Register ("getInstance", "(Landroid/content/Context;Lio/flic/lib/FlicManagerInitializedCallback;Lio/flic/lib/FlicManagerUninitializedCallback;)V", "")]
		public static unsafe void GetInstance (global::Android.Content.Context p0, global::IO.Flic.Lib.FlicManagerInitializedCallback p1, global::IO.Flic.Lib.FlicManagerUninitializedCallback p2)
		{
			if (id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_Lio_flic_lib_FlicManagerUninitializedCallback_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_Lio_flic_lib_FlicManagerUninitializedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Lio/flic/lib/FlicManagerInitializedCallback;Lio/flic/lib/FlicManagerUninitializedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getInstance_Landroid_content_Context_Lio_flic_lib_FlicManagerInitializedCallback_Lio_flic_lib_FlicManagerUninitializedCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_initiateGrabButton_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='initiateGrabButton' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("initiateGrabButton", "(Landroid/app/Activity;)V", "")]
		public unsafe void InitiateGrabButton (global::Android.App.Activity p0)
		{
			if (id_initiateGrabButton_Landroid_app_Activity_ == IntPtr.Zero)
				id_initiateGrabButton_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "initiateGrabButton", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_initiateGrabButton_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_setAppCredentials_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicManager']/method[@name='setAppCredentials' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAppCredentials", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetAppCredentials (string p0, string p1)
		{
			if (id_setAppCredentials_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppCredentials_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAppCredentials", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppCredentials_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
