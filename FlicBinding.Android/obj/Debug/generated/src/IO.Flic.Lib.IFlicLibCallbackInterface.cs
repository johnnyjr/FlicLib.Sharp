using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']"
	[global::Android.Runtime.Register ("io/flic/lib/IFlicLibCallbackInterface$Stub", DoNotGenerateAcw=true)]
	public abstract partial class FlicLibCallbackInterfaceStub : global::Android.OS.Binder, global::IO.Flic.Lib.IFlicLibCallbackInterface {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']"
		[global::Android.Runtime.Register ("io/flic/lib/IFlicLibCallbackInterface$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::IO.Flic.Lib.IFlicLibCallbackInterface {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/flic/lib/IFlicLibCallbackInterface$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getInterfaceDescriptor;
#pragma warning disable 0169
			static Delegate GetGetInterfaceDescriptorHandler ()
			{
				if (cb_getInterfaceDescriptor == null)
					cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptor);
				return cb_getInterfaceDescriptor;
			}

			static IntPtr n_GetInterfaceDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
				[Register ("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
				get {
					if (id_getInterfaceDescriptor == IntPtr.Zero)
						id_getInterfaceDescriptor = JNIEnv.GetMethodID (class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterfaceDescriptor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder AsBinder ()
			{
				if (id_asBinder == IntPtr.Zero)
					id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_onButtonClickOrHold_Ljava_lang_String_ZII;
#pragma warning disable 0169
			static Delegate GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler ()
			{
				if (cb_onButtonClickOrHold_Ljava_lang_String_ZII == null)
					cb_onButtonClickOrHold_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonClickOrHold_Ljava_lang_String_ZII);
				return cb_onButtonClickOrHold_Ljava_lang_String_ZII;
			}

			static void n_OnButtonClickOrHold_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnButtonClickOrHold (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onButtonClickOrHold_Ljava_lang_String_ZII;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onButtonClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onButtonClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler")]
			public virtual unsafe void OnButtonClickOrHold (string p0, bool p1, int p2, int p3)
			{
				if (id_onButtonClickOrHold_Ljava_lang_String_ZII == IntPtr.Zero)
					id_onButtonClickOrHold_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonClickOrHold", "(Ljava/lang/String;ZII)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onButtonClickOrHold_Ljava_lang_String_ZII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonClickOrHold", "(Ljava/lang/String;ZII)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
#pragma warning disable 0169
			static Delegate GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler ()
			{
				if (cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII == null)
					cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonSingleOrDoubleClick_Ljava_lang_String_ZII);
				return cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
			}

			static void n_OnButtonSingleOrDoubleClick_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnButtonSingleOrDoubleClick (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onButtonSingleOrDoubleClick' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler")]
			public virtual unsafe void OnButtonSingleOrDoubleClick (string p0, bool p1, int p2, int p3)
			{
				if (id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII == IntPtr.Zero)
					id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
#pragma warning disable 0169
			static Delegate GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler ()
			{
				if (cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII == null)
					cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII);
				return cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
			}

			static void n_OnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnButtonSingleOrDoubleClickOrHold (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onButtonSingleOrDoubleClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler")]
			public virtual unsafe void OnButtonSingleOrDoubleClickOrHold (string p0, bool p1, int p2, int p3)
			{
				if (id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII == IntPtr.Zero)
					id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onButtonUpOrDown_Ljava_lang_String_ZII;
#pragma warning disable 0169
			static Delegate GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler ()
			{
				if (cb_onButtonUpOrDown_Ljava_lang_String_ZII == null)
					cb_onButtonUpOrDown_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonUpOrDown_Ljava_lang_String_ZII);
				return cb_onButtonUpOrDown_Ljava_lang_String_ZII;
			}

			static void n_OnButtonUpOrDown_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnButtonUpOrDown (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onButtonUpOrDown_Ljava_lang_String_ZII;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onButtonUpOrDown' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onButtonUpOrDown", "(Ljava/lang/String;ZII)V", "GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler")]
			public virtual unsafe void OnButtonUpOrDown (string p0, bool p1, int p2, int p3)
			{
				if (id_onButtonUpOrDown_Ljava_lang_String_ZII == IntPtr.Zero)
					id_onButtonUpOrDown_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonUpOrDown", "(Ljava/lang/String;ZII)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onButtonUpOrDown_Ljava_lang_String_ZII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onButtonUpOrDown", "(Ljava/lang/String;ZII)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onConnect_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnConnect_Ljava_lang_String_Handler ()
			{
				if (cb_onConnect_Ljava_lang_String_ == null)
					cb_onConnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnect_Ljava_lang_String_);
				return cb_onConnect_Ljava_lang_String_;
			}

			static void n_OnConnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnect (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onConnect_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onConnect", "(Ljava/lang/String;)V", "GetOnConnect_Ljava_lang_String_Handler")]
			public virtual unsafe void OnConnect (string p0)
			{
				if (id_onConnect_Ljava_lang_String_ == IntPtr.Zero)
					id_onConnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnect", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onConnect_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnect", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onConnectionFailed_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetOnConnectionFailed_Ljava_lang_String_IHandler ()
			{
				if (cb_onConnectionFailed_Ljava_lang_String_I == null)
					cb_onConnectionFailed_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnConnectionFailed_Ljava_lang_String_I);
				return cb_onConnectionFailed_Ljava_lang_String_I;
			}

			static void n_OnConnectionFailed_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionFailed (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onConnectionFailed_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onConnectionFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("onConnectionFailed", "(Ljava/lang/String;I)V", "GetOnConnectionFailed_Ljava_lang_String_IHandler")]
			public virtual unsafe void OnConnectionFailed (string p0, int p1)
			{
				if (id_onConnectionFailed_Ljava_lang_String_I == IntPtr.Zero)
					id_onConnectionFailed_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Ljava/lang/String;I)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onConnectionFailed_Ljava_lang_String_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionFailed", "(Ljava/lang/String;I)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onDisconnect_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetOnDisconnect_Ljava_lang_String_IHandler ()
			{
				if (cb_onDisconnect_Ljava_lang_String_I == null)
					cb_onDisconnect_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDisconnect_Ljava_lang_String_I);
				return cb_onDisconnect_Ljava_lang_String_I;
			}

			static void n_OnDisconnect_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnect (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onDisconnect_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("onDisconnect", "(Ljava/lang/String;I)V", "GetOnDisconnect_Ljava_lang_String_IHandler")]
			public virtual unsafe void OnDisconnect (string p0, int p1)
			{
				if (id_onDisconnect_Ljava_lang_String_I == IntPtr.Zero)
					id_onDisconnect_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onDisconnect", "(Ljava/lang/String;I)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onDisconnect_Ljava_lang_String_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnect", "(Ljava/lang/String;I)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onReadRemoteRSSI_Ljava_lang_String_II;
#pragma warning disable 0169
			static Delegate GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler ()
			{
				if (cb_onReadRemoteRSSI_Ljava_lang_String_II == null)
					cb_onReadRemoteRSSI_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnReadRemoteRSSI_Ljava_lang_String_II);
				return cb_onReadRemoteRSSI_Ljava_lang_String_II;
			}

			static void n_OnReadRemoteRSSI_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadRemoteRSSI (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onReadRemoteRSSI_Ljava_lang_String_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onReadRemoteRSSI' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onReadRemoteRSSI", "(Ljava/lang/String;II)V", "GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler")]
			public virtual unsafe void OnReadRemoteRSSI (string p0, int p1, int p2)
			{
				if (id_onReadRemoteRSSI_Ljava_lang_String_II == IntPtr.Zero)
					id_onReadRemoteRSSI_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onReadRemoteRSSI", "(Ljava/lang/String;II)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onReadRemoteRSSI_Ljava_lang_String_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReadRemoteRSSI", "(Ljava/lang/String;II)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onReady_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnReady_Ljava_lang_String_Handler ()
			{
				if (cb_onReady_Ljava_lang_String_ == null)
					cb_onReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReady_Ljava_lang_String_);
				return cb_onReady_Ljava_lang_String_;
			}

			static void n_OnReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReady (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onReady_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub.Proxy']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onReady", "(Ljava/lang/String;)V", "GetOnReady_Ljava_lang_String_Handler")]
			public virtual unsafe void OnReady (string p0)
			{
				if (id_onReady_Ljava_lang_String_ == IntPtr.Zero)
					id_onReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReady", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onReady_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReady", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/IFlicLibCallbackInterface$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicLibCallbackInterfaceStub); }
		}

		protected FlicLibCallbackInterfaceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/constructor[@name='IFlicLibCallbackInterface.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlicLibCallbackInterfaceStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlicLibCallbackInterfaceStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lio/flic/lib/IFlicLibCallbackInterface;", "")]
		public static unsafe global::IO.Flic.Lib.IFlicLibCallbackInterface AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lio/flic/lib/IFlicLibCallbackInterface;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Flic.Lib.IFlicLibCallbackInterface __ret = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onButtonClickOrHold_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonClickOrHold_Ljava_lang_String_ZII == null)
				cb_onButtonClickOrHold_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonClickOrHold_Ljava_lang_String_ZII);
			return cb_onButtonClickOrHold_Ljava_lang_String_ZII;
		}

		static void n_OnButtonClickOrHold_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonClickOrHold (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler")]
		public abstract void OnButtonClickOrHold (string p0, bool p1, int p2, int p3);

		static Delegate cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII == null)
				cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonSingleOrDoubleClick_Ljava_lang_String_ZII);
			return cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
		}

		static void n_OnButtonSingleOrDoubleClick_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonSingleOrDoubleClick (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonSingleOrDoubleClick' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler")]
		public abstract void OnButtonSingleOrDoubleClick (string p0, bool p1, int p2, int p3);

		static Delegate cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII == null)
				cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII);
			return cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
		}

		static void n_OnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonSingleOrDoubleClickOrHold (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonSingleOrDoubleClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler")]
		public abstract void OnButtonSingleOrDoubleClickOrHold (string p0, bool p1, int p2, int p3);

		static Delegate cb_onButtonUpOrDown_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonUpOrDown_Ljava_lang_String_ZII == null)
				cb_onButtonUpOrDown_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonUpOrDown_Ljava_lang_String_ZII);
			return cb_onButtonUpOrDown_Ljava_lang_String_ZII;
		}

		static void n_OnButtonUpOrDown_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonUpOrDown (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonUpOrDown' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonUpOrDown", "(Ljava/lang/String;ZII)V", "GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler")]
		public abstract void OnButtonUpOrDown (string p0, bool p1, int p2, int p3);

		static Delegate cb_onConnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConnect_Ljava_lang_String_Handler ()
		{
			if (cb_onConnect_Ljava_lang_String_ == null)
				cb_onConnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnect_Ljava_lang_String_);
			return cb_onConnect_Ljava_lang_String_;
		}

		static void n_OnConnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnect", "(Ljava/lang/String;)V", "GetOnConnect_Ljava_lang_String_Handler")]
		public abstract void OnConnect (string p0);

		static Delegate cb_onConnectionFailed_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Ljava_lang_String_IHandler ()
		{
			if (cb_onConnectionFailed_Ljava_lang_String_I == null)
				cb_onConnectionFailed_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnConnectionFailed_Ljava_lang_String_I);
			return cb_onConnectionFailed_Ljava_lang_String_I;
		}

		static void n_OnConnectionFailed_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onConnectionFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onConnectionFailed", "(Ljava/lang/String;I)V", "GetOnConnectionFailed_Ljava_lang_String_IHandler")]
		public abstract void OnConnectionFailed (string p0, int p1);

		static Delegate cb_onDisconnect_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnDisconnect_Ljava_lang_String_IHandler ()
		{
			if (cb_onDisconnect_Ljava_lang_String_I == null)
				cb_onDisconnect_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDisconnect_Ljava_lang_String_I);
			return cb_onDisconnect_Ljava_lang_String_I;
		}

		static void n_OnDisconnect_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onDisconnect", "(Ljava/lang/String;I)V", "GetOnDisconnect_Ljava_lang_String_IHandler")]
		public abstract void OnDisconnect (string p0, int p1);

		static Delegate cb_onReadRemoteRSSI_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler ()
		{
			if (cb_onReadRemoteRSSI_Ljava_lang_String_II == null)
				cb_onReadRemoteRSSI_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnReadRemoteRSSI_Ljava_lang_String_II);
			return cb_onReadRemoteRSSI_Ljava_lang_String_II;
		}

		static void n_OnReadRemoteRSSI_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReadRemoteRSSI (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onReadRemoteRSSI' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onReadRemoteRSSI", "(Ljava/lang/String;II)V", "GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler")]
		public abstract void OnReadRemoteRSSI (string p0, int p1, int p2);

		static Delegate cb_onReady_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReady_Ljava_lang_String_Handler ()
		{
			if (cb_onReady_Ljava_lang_String_ == null)
				cb_onReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReady_Ljava_lang_String_);
			return cb_onReady_Ljava_lang_String_;
		}

		static void n_OnReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.FlicLibCallbackInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibCallbackInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReady (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReady", "(Ljava/lang/String;)V", "GetOnReady_Ljava_lang_String_Handler")]
		public abstract void OnReady (string p0);

	}

	[global::Android.Runtime.Register ("io/flic/lib/IFlicLibCallbackInterface$Stub", DoNotGenerateAcw=true)]
	internal partial class FlicLibCallbackInterfaceStubInvoker : FlicLibCallbackInterfaceStub {

		public FlicLibCallbackInterfaceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicLibCallbackInterfaceStubInvoker); }
		}

		static IntPtr id_onButtonClickOrHold_Ljava_lang_String_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler")]
		public override unsafe void OnButtonClickOrHold (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonClickOrHold_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonClickOrHold_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonClickOrHold", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_onButtonClickOrHold_Ljava_lang_String_ZII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonSingleOrDoubleClick' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler")]
		public override unsafe void OnButtonSingleOrDoubleClick (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonSingleOrDoubleClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler")]
		public override unsafe void OnButtonSingleOrDoubleClickOrHold (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onButtonUpOrDown_Ljava_lang_String_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onButtonUpOrDown' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonUpOrDown", "(Ljava/lang/String;ZII)V", "GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler")]
		public override unsafe void OnButtonUpOrDown (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonUpOrDown_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonUpOrDown_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonUpOrDown", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_onButtonUpOrDown_Ljava_lang_String_ZII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onConnect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnect", "(Ljava/lang/String;)V", "GetOnConnect_Ljava_lang_String_Handler")]
		public override unsafe void OnConnect (string p0)
		{
			if (id_onConnect_Ljava_lang_String_ == IntPtr.Zero)
				id_onConnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_onConnect_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onConnectionFailed_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onConnectionFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onConnectionFailed", "(Ljava/lang/String;I)V", "GetOnConnectionFailed_Ljava_lang_String_IHandler")]
		public override unsafe void OnConnectionFailed (string p0, int p1)
		{
			if (id_onConnectionFailed_Ljava_lang_String_I == IntPtr.Zero)
				id_onConnectionFailed_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_onConnectionFailed_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onDisconnect_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onDisconnect", "(Ljava/lang/String;I)V", "GetOnDisconnect_Ljava_lang_String_IHandler")]
		public override unsafe void OnDisconnect (string p0, int p1)
		{
			if (id_onDisconnect_Ljava_lang_String_I == IntPtr.Zero)
				id_onDisconnect_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onDisconnect", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_onDisconnect_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onReadRemoteRSSI_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onReadRemoteRSSI' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onReadRemoteRSSI", "(Ljava/lang/String;II)V", "GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler")]
		public override unsafe void OnReadRemoteRSSI (string p0, int p1, int p2)
		{
			if (id_onReadRemoteRSSI_Ljava_lang_String_II == IntPtr.Zero)
				id_onReadRemoteRSSI_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onReadRemoteRSSI", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_onReadRemoteRSSI_Ljava_lang_String_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onReady_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibCallbackInterface.Stub']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReady", "(Ljava/lang/String;)V", "GetOnReady_Ljava_lang_String_Handler")]
		public override unsafe void OnReady (string p0)
		{
			if (id_onReady_Ljava_lang_String_ == IntPtr.Zero)
				id_onReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReady", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_onReady_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']"
	[Register ("io/flic/lib/IFlicLibCallbackInterface", "", "IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker")]
	public partial interface IFlicLibCallbackInterface : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onButtonClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnButtonClickOrHold (string p0, bool p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onButtonSingleOrDoubleClick' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnButtonSingleOrDoubleClick (string p0, bool p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onButtonSingleOrDoubleClickOrHold' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V", "GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnButtonSingleOrDoubleClickOrHold (string p0, bool p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onButtonUpOrDown' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onButtonUpOrDown", "(Ljava/lang/String;ZII)V", "GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnButtonUpOrDown (string p0, bool p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnect", "(Ljava/lang/String;)V", "GetOnConnect_Ljava_lang_String_Handler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnConnect (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onConnectionFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onConnectionFailed", "(Ljava/lang/String;I)V", "GetOnConnectionFailed_Ljava_lang_String_IHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnConnectionFailed (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onDisconnect", "(Ljava/lang/String;I)V", "GetOnDisconnect_Ljava_lang_String_IHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnDisconnect (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onReadRemoteRSSI' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onReadRemoteRSSI", "(Ljava/lang/String;II)V", "GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnReadRemoteRSSI (string p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibCallbackInterface']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReady", "(Ljava/lang/String;)V", "GetOnReady_Ljava_lang_String_Handler:IO.Flic.Lib.IFlicLibCallbackInterfaceInvoker, FlicBinding.Android")]
		void OnReady (string p0);

	}

	[global::Android.Runtime.Register ("io/flic/lib/IFlicLibCallbackInterface", DoNotGenerateAcw=true)]
	internal class IFlicLibCallbackInterfaceInvoker : global::Java.Lang.Object, IFlicLibCallbackInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/flic/lib/IFlicLibCallbackInterface");
		IntPtr class_ref;

		public static IFlicLibCallbackInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlicLibCallbackInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.flic.lib.IFlicLibCallbackInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlicLibCallbackInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFlicLibCallbackInterfaceInvoker); }
		}

		static Delegate cb_onButtonClickOrHold_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonClickOrHold_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonClickOrHold_Ljava_lang_String_ZII == null)
				cb_onButtonClickOrHold_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonClickOrHold_Ljava_lang_String_ZII);
			return cb_onButtonClickOrHold_Ljava_lang_String_ZII;
		}

		static void n_OnButtonClickOrHold_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonClickOrHold (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onButtonClickOrHold_Ljava_lang_String_ZII;
		public unsafe void OnButtonClickOrHold (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonClickOrHold_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonClickOrHold_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonClickOrHold", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onButtonClickOrHold_Ljava_lang_String_ZII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonSingleOrDoubleClick_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII == null)
				cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonSingleOrDoubleClick_Ljava_lang_String_ZII);
			return cb_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
		}

		static void n_OnButtonSingleOrDoubleClick_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonSingleOrDoubleClick (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII;
		public unsafe void OnButtonSingleOrDoubleClick (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClick", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onButtonSingleOrDoubleClick_Ljava_lang_String_ZII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII == null)
				cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII);
			return cb_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
		}

		static void n_OnButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonSingleOrDoubleClickOrHold (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII;
		public unsafe void OnButtonSingleOrDoubleClickOrHold (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonSingleOrDoubleClickOrHold", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onButtonSingleOrDoubleClickOrHold_Ljava_lang_String_ZII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onButtonUpOrDown_Ljava_lang_String_ZII;
#pragma warning disable 0169
		static Delegate GetOnButtonUpOrDown_Ljava_lang_String_ZIIHandler ()
		{
			if (cb_onButtonUpOrDown_Ljava_lang_String_ZII == null)
				cb_onButtonUpOrDown_Ljava_lang_String_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int, int>) n_OnButtonUpOrDown_Ljava_lang_String_ZII);
			return cb_onButtonUpOrDown_Ljava_lang_String_ZII;
		}

		static void n_OnButtonUpOrDown_Ljava_lang_String_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonUpOrDown (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onButtonUpOrDown_Ljava_lang_String_ZII;
		public unsafe void OnButtonUpOrDown (string p0, bool p1, int p2, int p3)
		{
			if (id_onButtonUpOrDown_Ljava_lang_String_ZII == IntPtr.Zero)
				id_onButtonUpOrDown_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "onButtonUpOrDown", "(Ljava/lang/String;ZII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onButtonUpOrDown_Ljava_lang_String_ZII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onConnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConnect_Ljava_lang_String_Handler ()
		{
			if (cb_onConnect_Ljava_lang_String_ == null)
				cb_onConnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnect_Ljava_lang_String_);
			return cb_onConnect_Ljava_lang_String_;
		}

		static void n_OnConnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnect_Ljava_lang_String_;
		public unsafe void OnConnect (string p0)
		{
			if (id_onConnect_Ljava_lang_String_ == IntPtr.Zero)
				id_onConnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onConnect_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onConnectionFailed_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Ljava_lang_String_IHandler ()
		{
			if (cb_onConnectionFailed_Ljava_lang_String_I == null)
				cb_onConnectionFailed_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnConnectionFailed_Ljava_lang_String_I);
			return cb_onConnectionFailed_Ljava_lang_String_I;
		}

		static void n_OnConnectionFailed_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionFailed_Ljava_lang_String_I;
		public unsafe void OnConnectionFailed (string p0, int p1)
		{
			if (id_onConnectionFailed_Ljava_lang_String_I == IntPtr.Zero)
				id_onConnectionFailed_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onConnectionFailed_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDisconnect_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnDisconnect_Ljava_lang_String_IHandler ()
		{
			if (cb_onDisconnect_Ljava_lang_String_I == null)
				cb_onDisconnect_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDisconnect_Ljava_lang_String_I);
			return cb_onDisconnect_Ljava_lang_String_I;
		}

		static void n_OnDisconnect_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnect_Ljava_lang_String_I;
		public unsafe void OnDisconnect (string p0, int p1)
		{
			if (id_onDisconnect_Ljava_lang_String_I == IntPtr.Zero)
				id_onDisconnect_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onDisconnect", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onDisconnect_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onReadRemoteRSSI_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnReadRemoteRSSI_Ljava_lang_String_IIHandler ()
		{
			if (cb_onReadRemoteRSSI_Ljava_lang_String_II == null)
				cb_onReadRemoteRSSI_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnReadRemoteRSSI_Ljava_lang_String_II);
			return cb_onReadRemoteRSSI_Ljava_lang_String_II;
		}

		static void n_OnReadRemoteRSSI_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReadRemoteRSSI (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onReadRemoteRSSI_Ljava_lang_String_II;
		public unsafe void OnReadRemoteRSSI (string p0, int p1, int p2)
		{
			if (id_onReadRemoteRSSI_Ljava_lang_String_II == IntPtr.Zero)
				id_onReadRemoteRSSI_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onReadRemoteRSSI", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_onReadRemoteRSSI_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onReady_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReady_Ljava_lang_String_Handler ()
		{
			if (cb_onReady_Ljava_lang_String_ == null)
				cb_onReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReady_Ljava_lang_String_);
			return cb_onReady_Ljava_lang_String_;
		}

		static void n_OnReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReady_Ljava_lang_String_;
		public unsafe void OnReady (string p0)
		{
			if (id_onReady_Ljava_lang_String_ == IntPtr.Zero)
				id_onReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReady", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onReady_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Flic.Lib.IFlicLibCallbackInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
