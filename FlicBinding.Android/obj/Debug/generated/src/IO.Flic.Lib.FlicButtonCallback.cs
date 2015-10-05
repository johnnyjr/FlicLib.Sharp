using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']"
	[global::Android.Runtime.Register ("io/flic/lib/FlicButtonCallback", DoNotGenerateAcw=true)]
	public partial class FlicButtonCallback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/FlicButtonCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicButtonCallback); }
		}

		protected FlicButtonCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/constructor[@name='FlicButtonCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlicButtonCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlicButtonCallback)) {
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

		static Delegate cb_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ;
#pragma warning disable 0169
		static Delegate GetOnButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZHandler ()
		{
			if (cb_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ == null)
				cb_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, bool, bool>) n_OnButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ);
			return cb_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ;
		}

		static void n_OnButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, bool p3, bool p4)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonClickOrHold (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onButtonClickOrHold' and count(parameter)=5 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("onButtonClickOrHold", "(Lio/flic/lib/FlicButton;ZIZZ)V", "GetOnButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZHandler")]
		public virtual unsafe void OnButtonClickOrHold (global::IO.Flic.Lib.FlicButton p0, bool p1, int p2, bool p3, bool p4)
		{
			if (id_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ == IntPtr.Zero)
				id_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ = JNIEnv.GetMethodID (class_ref, "onButtonClickOrHold", "(Lio/flic/lib/FlicButton;ZIZZ)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onButtonClickOrHold_Lio_flic_lib_FlicButton_ZIZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonClickOrHold", "(Lio/flic/lib/FlicButton;ZIZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ;
#pragma warning disable 0169
		static Delegate GetOnButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZHandler ()
		{
			if (cb_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ == null)
				cb_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, bool, bool>) n_OnButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ);
			return cb_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ;
		}

		static void n_OnButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, bool p3, bool p4)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonSingleOrDoubleClick (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onButtonSingleOrDoubleClick' and count(parameter)=5 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("onButtonSingleOrDoubleClick", "(Lio/flic/lib/FlicButton;ZIZZ)V", "GetOnButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZHandler")]
		public virtual unsafe void OnButtonSingleOrDoubleClick (global::IO.Flic.Lib.FlicButton p0, bool p1, int p2, bool p3, bool p4)
		{
			if (id_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ == IntPtr.Zero)
				id_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClick", "(Lio/flic/lib/FlicButton;ZIZZ)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onButtonSingleOrDoubleClick_Lio_flic_lib_FlicButton_ZIZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonSingleOrDoubleClick", "(Lio/flic/lib/FlicButton;ZIZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ;
#pragma warning disable 0169
		static Delegate GetOnButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZHandler ()
		{
			if (cb_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ == null)
				cb_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, bool, bool, bool>) n_OnButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ);
			return cb_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ;
		}

		static void n_OnButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, bool p3, bool p4, bool p5)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonSingleOrDoubleClickOrHold (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onButtonSingleOrDoubleClickOrHold' and count(parameter)=6 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("onButtonSingleOrDoubleClickOrHold", "(Lio/flic/lib/FlicButton;ZIZZZ)V", "GetOnButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZHandler")]
		public virtual unsafe void OnButtonSingleOrDoubleClickOrHold (global::IO.Flic.Lib.FlicButton p0, bool p1, int p2, bool p3, bool p4, bool p5)
		{
			if (id_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ == IntPtr.Zero)
				id_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClickOrHold", "(Lio/flic/lib/FlicButton;ZIZZZ)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onButtonSingleOrDoubleClickOrHold_Lio_flic_lib_FlicButton_ZIZZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonSingleOrDoubleClickOrHold", "(Lio/flic/lib/FlicButton;ZIZZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ;
#pragma warning disable 0169
		static Delegate GetOnButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZHandler ()
		{
			if (cb_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ == null)
				cb_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, bool, bool>) n_OnButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ);
			return cb_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ;
		}

		static void n_OnButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, bool p3, bool p4)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonUpOrDown (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onButtonUpOrDown' and count(parameter)=5 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("onButtonUpOrDown", "(Lio/flic/lib/FlicButton;ZIZZ)V", "GetOnButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZHandler")]
		public virtual unsafe void OnButtonUpOrDown (global::IO.Flic.Lib.FlicButton p0, bool p1, int p2, bool p3, bool p4)
		{
			if (id_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ == IntPtr.Zero)
				id_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ = JNIEnv.GetMethodID (class_ref, "onButtonUpOrDown", "(Lio/flic/lib/FlicButton;ZIZZ)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onButtonUpOrDown_Lio_flic_lib_FlicButton_ZIZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonUpOrDown", "(Lio/flic/lib/FlicButton;ZIZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionCompleted_Lio_flic_lib_FlicButton_;
#pragma warning disable 0169
		static Delegate GetOnConnectionCompleted_Lio_flic_lib_FlicButton_Handler ()
		{
			if (cb_onConnectionCompleted_Lio_flic_lib_FlicButton_ == null)
				cb_onConnectionCompleted_Lio_flic_lib_FlicButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionCompleted_Lio_flic_lib_FlicButton_);
			return cb_onConnectionCompleted_Lio_flic_lib_FlicButton_;
		}

		static void n_OnConnectionCompleted_Lio_flic_lib_FlicButton_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionCompleted_Lio_flic_lib_FlicButton_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onConnectionCompleted' and count(parameter)=1 and parameter[1][@type='io.flic.lib.FlicButton']]"
		[Register ("onConnectionCompleted", "(Lio/flic/lib/FlicButton;)V", "GetOnConnectionCompleted_Lio_flic_lib_FlicButton_Handler")]
		public virtual unsafe void OnConnectionCompleted (global::IO.Flic.Lib.FlicButton p0)
		{
			if (id_onConnectionCompleted_Lio_flic_lib_FlicButton_ == IntPtr.Zero)
				id_onConnectionCompleted_Lio_flic_lib_FlicButton_ = JNIEnv.GetMethodID (class_ref, "onConnectionCompleted", "(Lio/flic/lib/FlicButton;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConnectionCompleted_Lio_flic_lib_FlicButton_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionCompleted", "(Lio/flic/lib/FlicButton;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionFailed_Lio_flic_lib_FlicButton_I;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Lio_flic_lib_FlicButton_IHandler ()
		{
			if (cb_onConnectionFailed_Lio_flic_lib_FlicButton_I == null)
				cb_onConnectionFailed_Lio_flic_lib_FlicButton_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnConnectionFailed_Lio_flic_lib_FlicButton_I);
			return cb_onConnectionFailed_Lio_flic_lib_FlicButton_I;
		}

		static void n_OnConnectionFailed_Lio_flic_lib_FlicButton_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionFailed_Lio_flic_lib_FlicButton_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onConnectionFailed' and count(parameter)=2 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='int']]"
		[Register ("onConnectionFailed", "(Lio/flic/lib/FlicButton;I)V", "GetOnConnectionFailed_Lio_flic_lib_FlicButton_IHandler")]
		public virtual unsafe void OnConnectionFailed (global::IO.Flic.Lib.FlicButton p0, int p1)
		{
			if (id_onConnectionFailed_Lio_flic_lib_FlicButton_I == IntPtr.Zero)
				id_onConnectionFailed_Lio_flic_lib_FlicButton_I = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lio/flic/lib/FlicButton;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConnectionFailed_Lio_flic_lib_FlicButton_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionFailed", "(Lio/flic/lib/FlicButton;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionStarted_Lio_flic_lib_FlicButton_;
#pragma warning disable 0169
		static Delegate GetOnConnectionStarted_Lio_flic_lib_FlicButton_Handler ()
		{
			if (cb_onConnectionStarted_Lio_flic_lib_FlicButton_ == null)
				cb_onConnectionStarted_Lio_flic_lib_FlicButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionStarted_Lio_flic_lib_FlicButton_);
			return cb_onConnectionStarted_Lio_flic_lib_FlicButton_;
		}

		static void n_OnConnectionStarted_Lio_flic_lib_FlicButton_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionStarted_Lio_flic_lib_FlicButton_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onConnectionStarted' and count(parameter)=1 and parameter[1][@type='io.flic.lib.FlicButton']]"
		[Register ("onConnectionStarted", "(Lio/flic/lib/FlicButton;)V", "GetOnConnectionStarted_Lio_flic_lib_FlicButton_Handler")]
		public virtual unsafe void OnConnectionStarted (global::IO.Flic.Lib.FlicButton p0)
		{
			if (id_onConnectionStarted_Lio_flic_lib_FlicButton_ == IntPtr.Zero)
				id_onConnectionStarted_Lio_flic_lib_FlicButton_ = JNIEnv.GetMethodID (class_ref, "onConnectionStarted", "(Lio/flic/lib/FlicButton;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConnectionStarted_Lio_flic_lib_FlicButton_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionStarted", "(Lio/flic/lib/FlicButton;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDisconnect_Lio_flic_lib_FlicButton_I;
#pragma warning disable 0169
		static Delegate GetOnDisconnect_Lio_flic_lib_FlicButton_IHandler ()
		{
			if (cb_onDisconnect_Lio_flic_lib_FlicButton_I == null)
				cb_onDisconnect_Lio_flic_lib_FlicButton_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDisconnect_Lio_flic_lib_FlicButton_I);
			return cb_onDisconnect_Lio_flic_lib_FlicButton_I;
		}

		static void n_OnDisconnect_Lio_flic_lib_FlicButton_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDisconnect_Lio_flic_lib_FlicButton_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='int']]"
		[Register ("onDisconnect", "(Lio/flic/lib/FlicButton;I)V", "GetOnDisconnect_Lio_flic_lib_FlicButton_IHandler")]
		public virtual unsafe void OnDisconnect (global::IO.Flic.Lib.FlicButton p0, int p1)
		{
			if (id_onDisconnect_Lio_flic_lib_FlicButton_I == IntPtr.Zero)
				id_onDisconnect_Lio_flic_lib_FlicButton_I = JNIEnv.GetMethodID (class_ref, "onDisconnect", "(Lio/flic/lib/FlicButton;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDisconnect_Lio_flic_lib_FlicButton_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnect", "(Lio/flic/lib/FlicButton;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II;
#pragma warning disable 0169
		static Delegate GetOnReadRemoteRSSI_Lio_flic_lib_FlicButton_IIHandler ()
		{
			if (cb_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II == null)
				cb_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnReadRemoteRSSI_Lio_flic_lib_FlicButton_II);
			return cb_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II;
		}

		static void n_OnReadRemoteRSSI_Lio_flic_lib_FlicButton_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Flic.Lib.FlicButtonCallback __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.FlicButton p0 = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicButton> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReadRemoteRSSI (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButtonCallback']/method[@name='onReadRemoteRSSI' and count(parameter)=3 and parameter[1][@type='io.flic.lib.FlicButton'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onReadRemoteRSSI", "(Lio/flic/lib/FlicButton;II)V", "GetOnReadRemoteRSSI_Lio_flic_lib_FlicButton_IIHandler")]
		public virtual unsafe void OnReadRemoteRSSI (global::IO.Flic.Lib.FlicButton p0, int p1, int p2)
		{
			if (id_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II == IntPtr.Zero)
				id_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II = JNIEnv.GetMethodID (class_ref, "onReadRemoteRSSI", "(Lio/flic/lib/FlicButton;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReadRemoteRSSI_Lio_flic_lib_FlicButton_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReadRemoteRSSI", "(Lio/flic/lib/FlicButton;II)V"), __args);
			} finally {
			}
		}

	}
}
