using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']"
	[global::Android.Runtime.Register ("io/flic/lib/IFlicLibInterface$Stub", DoNotGenerateAcw=true)]
	public abstract partial class FlicLibInterfaceStub : global::Android.OS.Binder, global::IO.Flic.Lib.IFlicLibInterface {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']"
		[global::Android.Runtime.Register ("io/flic/lib/IFlicLibInterface$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::IO.Flic.Lib.IFlicLibInterface {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/flic/lib/IFlicLibInterface$Stub$Proxy", ref java_class_handle);
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
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate cb_getColor_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetColor_JLjava_lang_String_Handler ()
			{
				if (cb_getColor_JLjava_lang_String_ == null)
					cb_getColor_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetColor_JLjava_lang_String_);
				return cb_getColor_JLjava_lang_String_;
			}

			static IntPtr n_GetColor_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetColor (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getColor_JLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("getColor", "(JLjava/lang/String;)Ljava/lang/String;", "GetGetColor_JLjava_lang_String_Handler")]
			public virtual unsafe string GetColor (long p0, string p1)
			{
				if (id_getColor_JLjava_lang_String_ == IntPtr.Zero)
					id_getColor_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColor", "(JLjava/lang/String;)Ljava/lang/String;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					string __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColor_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "(JLjava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_getConnectionStatus_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetConnectionStatus_JLjava_lang_String_Handler ()
			{
				if (cb_getConnectionStatus_JLjava_lang_String_ == null)
					cb_getConnectionStatus_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_GetConnectionStatus_JLjava_lang_String_);
				return cb_getConnectionStatus_JLjava_lang_String_;
			}

			static int n_GetConnectionStatus_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetConnectionStatus (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getConnectionStatus_JLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='getConnectionStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("getConnectionStatus", "(JLjava/lang/String;)I", "GetGetConnectionStatus_JLjava_lang_String_Handler")]
			public virtual unsafe int GetConnectionStatus (long p0, string p1)
			{
				if (id_getConnectionStatus_JLjava_lang_String_ == IntPtr.Zero)
					id_getConnectionStatus_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectionStatus", "(JLjava/lang/String;)I");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_getConnectionStatus_JLjava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionStatus", "(JLjava/lang/String;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_listenForConnectionCallbacks_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetListenForConnectionCallbacks_JLjava_lang_String_Handler ()
			{
				if (cb_listenForConnectionCallbacks_JLjava_lang_String_ == null)
					cb_listenForConnectionCallbacks_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_ListenForConnectionCallbacks_JLjava_lang_String_);
				return cb_listenForConnectionCallbacks_JLjava_lang_String_;
			}

			static void n_ListenForConnectionCallbacks_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ListenForConnectionCallbacks (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_listenForConnectionCallbacks_JLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='listenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("listenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetListenForConnectionCallbacks_JLjava_lang_String_Handler")]
			public virtual unsafe void ListenForConnectionCallbacks (long p0, string p1)
			{
				if (id_listenForConnectionCallbacks_JLjava_lang_String_ == IntPtr.Zero)
					id_listenForConnectionCallbacks_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "listenForConnectionCallbacks", "(JLjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_listenForConnectionCallbacks_JLjava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listenForConnectionCallbacks", "(JLjava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_readRemoteRSSI_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetReadRemoteRSSI_JLjava_lang_String_Handler ()
			{
				if (cb_readRemoteRSSI_JLjava_lang_String_ == null)
					cb_readRemoteRSSI_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_ReadRemoteRSSI_JLjava_lang_String_);
				return cb_readRemoteRSSI_JLjava_lang_String_;
			}

			static bool n_ReadRemoteRSSI_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ReadRemoteRSSI (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_readRemoteRSSI_JLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='readRemoteRSSI' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("readRemoteRSSI", "(JLjava/lang/String;)Z", "GetReadRemoteRSSI_JLjava_lang_String_Handler")]
			public virtual unsafe bool ReadRemoteRSSI (long p0, string p1)
			{
				if (id_readRemoteRSSI_JLjava_lang_String_ == IntPtr.Zero)
					id_readRemoteRSSI_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readRemoteRSSI", "(JLjava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_readRemoteRSSI_JLjava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readRemoteRSSI", "(JLjava/lang/String;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_RegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_);
				return cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
			}

			static long n_RegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::IO.Flic.Lib.IFlicLibCallbackInterface p0 = (global::IO.Flic.Lib.IFlicLibCallbackInterface)global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				long __ret = __this.RegisterCallback (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='registerCallback' and count(parameter)=3 and parameter[1][@type='io.flic.lib.IFlicLibCallbackInterface'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J", "GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe long RegisterCallback (global::IO.Flic.Lib.IFlicLibCallbackInterface p0, string p1, string p2)
			{
				if (id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);

					long __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallLongMethod  (Handle, id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_setActiveMode_JLjava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetSetActiveMode_JLjava_lang_String_ZHandler ()
			{
				if (cb_setActiveMode_JLjava_lang_String_Z == null)
					cb_setActiveMode_JLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, bool>) n_SetActiveMode_JLjava_lang_String_Z);
				return cb_setActiveMode_JLjava_lang_String_Z;
			}

			static void n_SetActiveMode_JLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, bool p2)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetActiveMode (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_setActiveMode_JLjava_lang_String_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='setActiveMode' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
			[Register ("setActiveMode", "(JLjava/lang/String;Z)V", "GetSetActiveMode_JLjava_lang_String_ZHandler")]
			public virtual unsafe void SetActiveMode (long p0, string p1, bool p2)
			{
				if (id_setActiveMode_JLjava_lang_String_Z == IntPtr.Zero)
					id_setActiveMode_JLjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setActiveMode", "(JLjava/lang/String;Z)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setActiveMode_JLjava_lang_String_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveMode", "(JLjava/lang/String;Z)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_setButtonCallbacks_JLjava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetSetButtonCallbacks_JLjava_lang_String_IHandler ()
			{
				if (cb_setButtonCallbacks_JLjava_lang_String_I == null)
					cb_setButtonCallbacks_JLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_SetButtonCallbacks_JLjava_lang_String_I);
				return cb_setButtonCallbacks_JLjava_lang_String_I;
			}

			static void n_SetButtonCallbacks_JLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetButtonCallbacks (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_setButtonCallbacks_JLjava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='setButtonCallbacks' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("setButtonCallbacks", "(JLjava/lang/String;I)V", "GetSetButtonCallbacks_JLjava_lang_String_IHandler")]
			public virtual unsafe void SetButtonCallbacks (long p0, string p1, int p2)
			{
				if (id_setButtonCallbacks_JLjava_lang_String_I == IntPtr.Zero)
					id_setButtonCallbacks_JLjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setButtonCallbacks", "(JLjava/lang/String;I)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setButtonCallbacks_JLjava_lang_String_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButtonCallbacks", "(JLjava/lang/String;I)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_unListenForConnectionCallbacks_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler ()
			{
				if (cb_unListenForConnectionCallbacks_JLjava_lang_String_ == null)
					cb_unListenForConnectionCallbacks_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UnListenForConnectionCallbacks_JLjava_lang_String_);
				return cb_unListenForConnectionCallbacks_JLjava_lang_String_;
			}

			static void n_UnListenForConnectionCallbacks_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.UnListenForConnectionCallbacks (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_unListenForConnectionCallbacks_JLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='unListenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
			[Register ("unListenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler")]
			public virtual unsafe void UnListenForConnectionCallbacks (long p0, string p1)
			{
				if (id_unListenForConnectionCallbacks_JLjava_lang_String_ == IntPtr.Zero)
					id_unListenForConnectionCallbacks_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unListenForConnectionCallbacks", "(JLjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_unListenForConnectionCallbacks_JLjava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unListenForConnectionCallbacks", "(JLjava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_unregisterCallback_J;
#pragma warning disable 0169
			static Delegate GetUnregisterCallback_JHandler ()
			{
				if (cb_unregisterCallback_J == null)
					cb_unregisterCallback_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_UnregisterCallback_J);
				return cb_unregisterCallback_J;
			}

			static void n_UnregisterCallback_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.UnregisterCallback (p0);
			}
#pragma warning restore 0169

			static IntPtr id_unregisterCallback_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub.Proxy']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("unregisterCallback", "(J)V", "GetUnregisterCallback_JHandler")]
			public virtual unsafe void UnregisterCallback (long p0)
			{
				if (id_unregisterCallback_J == IntPtr.Zero)
					id_unregisterCallback_J = JNIEnv.GetMethodID (class_ref, "unregisterCallback", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_unregisterCallback_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterCallback", "(J)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/IFlicLibInterface$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicLibInterfaceStub); }
		}

		protected FlicLibInterfaceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/constructor[@name='IFlicLibInterface.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlicLibInterfaceStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlicLibInterfaceStub)) {
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
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lio/flic/lib/IFlicLibInterface;", "")]
		public static unsafe global::IO.Flic.Lib.IFlicLibInterface AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lio/flic/lib/IFlicLibInterface;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Flic.Lib.IFlicLibInterface __ret = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_getColor_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColor_JLjava_lang_String_Handler ()
		{
			if (cb_getColor_JLjava_lang_String_ == null)
				cb_getColor_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetColor_JLjava_lang_String_);
			return cb_getColor_JLjava_lang_String_;
		}

		static IntPtr n_GetColor_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetColor (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getColor", "(JLjava/lang/String;)Ljava/lang/String;", "GetGetColor_JLjava_lang_String_Handler")]
		public abstract string GetColor (long p0, string p1);

		static Delegate cb_getConnectionStatus_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnectionStatus_JLjava_lang_String_Handler ()
		{
			if (cb_getConnectionStatus_JLjava_lang_String_ == null)
				cb_getConnectionStatus_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_GetConnectionStatus_JLjava_lang_String_);
			return cb_getConnectionStatus_JLjava_lang_String_;
		}

		static int n_GetConnectionStatus_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetConnectionStatus (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='getConnectionStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConnectionStatus", "(JLjava/lang/String;)I", "GetGetConnectionStatus_JLjava_lang_String_Handler")]
		public abstract int GetConnectionStatus (long p0, string p1);

		static Delegate cb_listenForConnectionCallbacks_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetListenForConnectionCallbacks_JLjava_lang_String_Handler ()
		{
			if (cb_listenForConnectionCallbacks_JLjava_lang_String_ == null)
				cb_listenForConnectionCallbacks_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_ListenForConnectionCallbacks_JLjava_lang_String_);
			return cb_listenForConnectionCallbacks_JLjava_lang_String_;
		}

		static void n_ListenForConnectionCallbacks_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ListenForConnectionCallbacks (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='listenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("listenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetListenForConnectionCallbacks_JLjava_lang_String_Handler")]
		public abstract void ListenForConnectionCallbacks (long p0, string p1);

		static Delegate cb_readRemoteRSSI_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadRemoteRSSI_JLjava_lang_String_Handler ()
		{
			if (cb_readRemoteRSSI_JLjava_lang_String_ == null)
				cb_readRemoteRSSI_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_ReadRemoteRSSI_JLjava_lang_String_);
			return cb_readRemoteRSSI_JLjava_lang_String_;
		}

		static bool n_ReadRemoteRSSI_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReadRemoteRSSI (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='readRemoteRSSI' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("readRemoteRSSI", "(JLjava/lang/String;)Z", "GetReadRemoteRSSI_JLjava_lang_String_Handler")]
		public abstract bool ReadRemoteRSSI (long p0, string p1);

		static Delegate cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_RegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
		}

		static long n_RegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.IFlicLibCallbackInterface p0 = (global::IO.Flic.Lib.IFlicLibCallbackInterface)global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.RegisterCallback (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='registerCallback' and count(parameter)=3 and parameter[1][@type='io.flic.lib.IFlicLibCallbackInterface'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J", "GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract long RegisterCallback (global::IO.Flic.Lib.IFlicLibCallbackInterface p0, string p1, string p2);

		static Delegate cb_setActiveMode_JLjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetActiveMode_JLjava_lang_String_ZHandler ()
		{
			if (cb_setActiveMode_JLjava_lang_String_Z == null)
				cb_setActiveMode_JLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, bool>) n_SetActiveMode_JLjava_lang_String_Z);
			return cb_setActiveMode_JLjava_lang_String_Z;
		}

		static void n_SetActiveMode_JLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, bool p2)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveMode (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='setActiveMode' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("setActiveMode", "(JLjava/lang/String;Z)V", "GetSetActiveMode_JLjava_lang_String_ZHandler")]
		public abstract void SetActiveMode (long p0, string p1, bool p2);

		static Delegate cb_setButtonCallbacks_JLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetButtonCallbacks_JLjava_lang_String_IHandler ()
		{
			if (cb_setButtonCallbacks_JLjava_lang_String_I == null)
				cb_setButtonCallbacks_JLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_SetButtonCallbacks_JLjava_lang_String_I);
			return cb_setButtonCallbacks_JLjava_lang_String_I;
		}

		static void n_SetButtonCallbacks_JLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetButtonCallbacks (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='setButtonCallbacks' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setButtonCallbacks", "(JLjava/lang/String;I)V", "GetSetButtonCallbacks_JLjava_lang_String_IHandler")]
		public abstract void SetButtonCallbacks (long p0, string p1, int p2);

		static Delegate cb_unListenForConnectionCallbacks_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler ()
		{
			if (cb_unListenForConnectionCallbacks_JLjava_lang_String_ == null)
				cb_unListenForConnectionCallbacks_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UnListenForConnectionCallbacks_JLjava_lang_String_);
			return cb_unListenForConnectionCallbacks_JLjava_lang_String_;
		}

		static void n_UnListenForConnectionCallbacks_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnListenForConnectionCallbacks (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='unListenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("unListenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler")]
		public abstract void UnListenForConnectionCallbacks (long p0, string p1);

		static Delegate cb_unregisterCallback_J;
#pragma warning disable 0169
		static Delegate GetUnregisterCallback_JHandler ()
		{
			if (cb_unregisterCallback_J == null)
				cb_unregisterCallback_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_UnregisterCallback_J);
			return cb_unregisterCallback_J;
		}

		static void n_UnregisterCallback_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Flic.Lib.FlicLibInterfaceStub __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.FlicLibInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("unregisterCallback", "(J)V", "GetUnregisterCallback_JHandler")]
		public abstract void UnregisterCallback (long p0);

	}

	[global::Android.Runtime.Register ("io/flic/lib/IFlicLibInterface$Stub", DoNotGenerateAcw=true)]
	internal partial class FlicLibInterfaceStubInvoker : FlicLibInterfaceStub {

		public FlicLibInterfaceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicLibInterfaceStubInvoker); }
		}

		static IntPtr id_getColor_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getColor", "(JLjava/lang/String;)Ljava/lang/String;", "GetGetColor_JLjava_lang_String_Handler")]
		public override unsafe string GetColor (long p0, string p1)
		{
			if (id_getColor_JLjava_lang_String_ == IntPtr.Zero)
				id_getColor_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColor", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColor_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getConnectionStatus_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='getConnectionStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConnectionStatus", "(JLjava/lang/String;)I", "GetGetConnectionStatus_JLjava_lang_String_Handler")]
		public override unsafe int GetConnectionStatus (long p0, string p1)
		{
			if (id_getConnectionStatus_JLjava_lang_String_ == IntPtr.Zero)
				id_getConnectionStatus_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectionStatus", "(JLjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getConnectionStatus_JLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_listenForConnectionCallbacks_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='listenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("listenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetListenForConnectionCallbacks_JLjava_lang_String_Handler")]
		public override unsafe void ListenForConnectionCallbacks (long p0, string p1)
		{
			if (id_listenForConnectionCallbacks_JLjava_lang_String_ == IntPtr.Zero)
				id_listenForConnectionCallbacks_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "listenForConnectionCallbacks", "(JLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_listenForConnectionCallbacks_JLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readRemoteRSSI_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='readRemoteRSSI' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("readRemoteRSSI", "(JLjava/lang/String;)Z", "GetReadRemoteRSSI_JLjava_lang_String_Handler")]
		public override unsafe bool ReadRemoteRSSI (long p0, string p1)
		{
			if (id_readRemoteRSSI_JLjava_lang_String_ == IntPtr.Zero)
				id_readRemoteRSSI_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readRemoteRSSI", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_readRemoteRSSI_JLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='registerCallback' and count(parameter)=3 and parameter[1][@type='io.flic.lib.IFlicLibCallbackInterface'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J", "GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe long RegisterCallback (global::IO.Flic.Lib.IFlicLibCallbackInterface p0, string p1, string p2)
		{
			if (id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setActiveMode_JLjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='setActiveMode' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("setActiveMode", "(JLjava/lang/String;Z)V", "GetSetActiveMode_JLjava_lang_String_ZHandler")]
		public override unsafe void SetActiveMode (long p0, string p1, bool p2)
		{
			if (id_setActiveMode_JLjava_lang_String_Z == IntPtr.Zero)
				id_setActiveMode_JLjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setActiveMode", "(JLjava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_setActiveMode_JLjava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setButtonCallbacks_JLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='setButtonCallbacks' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setButtonCallbacks", "(JLjava/lang/String;I)V", "GetSetButtonCallbacks_JLjava_lang_String_IHandler")]
		public override unsafe void SetButtonCallbacks (long p0, string p1, int p2)
		{
			if (id_setButtonCallbacks_JLjava_lang_String_I == IntPtr.Zero)
				id_setButtonCallbacks_JLjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setButtonCallbacks", "(JLjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_setButtonCallbacks_JLjava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_unListenForConnectionCallbacks_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='unListenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("unListenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler")]
		public override unsafe void UnListenForConnectionCallbacks (long p0, string p1)
		{
			if (id_unListenForConnectionCallbacks_JLjava_lang_String_ == IntPtr.Zero)
				id_unListenForConnectionCallbacks_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unListenForConnectionCallbacks", "(JLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_unListenForConnectionCallbacks_JLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_unregisterCallback_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='IFlicLibInterface.Stub']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("unregisterCallback", "(J)V", "GetUnregisterCallback_JHandler")]
		public override unsafe void UnregisterCallback (long p0)
		{
			if (id_unregisterCallback_J == IntPtr.Zero)
				id_unregisterCallback_J = JNIEnv.GetMethodID (class_ref, "unregisterCallback", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_unregisterCallback_J, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']"
	[Register ("io/flic/lib/IFlicLibInterface", "", "IO.Flic.Lib.IFlicLibInterfaceInvoker")]
	public partial interface IFlicLibInterface : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getColor", "(JLjava/lang/String;)Ljava/lang/String;", "GetGetColor_JLjava_lang_String_Handler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		string GetColor (long p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='getConnectionStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConnectionStatus", "(JLjava/lang/String;)I", "GetGetConnectionStatus_JLjava_lang_String_Handler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		int GetConnectionStatus (long p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='listenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("listenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetListenForConnectionCallbacks_JLjava_lang_String_Handler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		void ListenForConnectionCallbacks (long p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='readRemoteRSSI' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("readRemoteRSSI", "(JLjava/lang/String;)Z", "GetReadRemoteRSSI_JLjava_lang_String_Handler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		bool ReadRemoteRSSI (long p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='registerCallback' and count(parameter)=3 and parameter[1][@type='io.flic.lib.IFlicLibCallbackInterface'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J", "GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		long RegisterCallback (global::IO.Flic.Lib.IFlicLibCallbackInterface p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='setActiveMode' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("setActiveMode", "(JLjava/lang/String;Z)V", "GetSetActiveMode_JLjava_lang_String_ZHandler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		void SetActiveMode (long p0, string p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='setButtonCallbacks' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setButtonCallbacks", "(JLjava/lang/String;I)V", "GetSetButtonCallbacks_JLjava_lang_String_IHandler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		void SetButtonCallbacks (long p0, string p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='unListenForConnectionCallbacks' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("unListenForConnectionCallbacks", "(JLjava/lang/String;)V", "GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		void UnListenForConnectionCallbacks (long p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/interface[@name='IFlicLibInterface']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("unregisterCallback", "(J)V", "GetUnregisterCallback_JHandler:IO.Flic.Lib.IFlicLibInterfaceInvoker, FlicBinding.Android")]
		void UnregisterCallback (long p0);

	}

	[global::Android.Runtime.Register ("io/flic/lib/IFlicLibInterface", DoNotGenerateAcw=true)]
	internal class IFlicLibInterfaceInvoker : global::Java.Lang.Object, IFlicLibInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/flic/lib/IFlicLibInterface");
		IntPtr class_ref;

		public static IFlicLibInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlicLibInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.flic.lib.IFlicLibInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlicLibInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFlicLibInterfaceInvoker); }
		}

		static Delegate cb_getColor_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColor_JLjava_lang_String_Handler ()
		{
			if (cb_getColor_JLjava_lang_String_ == null)
				cb_getColor_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetColor_JLjava_lang_String_);
			return cb_getColor_JLjava_lang_String_;
		}

		static IntPtr n_GetColor_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetColor (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColor_JLjava_lang_String_;
		public unsafe string GetColor (long p0, string p1)
		{
			if (id_getColor_JLjava_lang_String_ == IntPtr.Zero)
				id_getColor_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColor", "(JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getColor_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getConnectionStatus_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnectionStatus_JLjava_lang_String_Handler ()
		{
			if (cb_getConnectionStatus_JLjava_lang_String_ == null)
				cb_getConnectionStatus_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int>) n_GetConnectionStatus_JLjava_lang_String_);
			return cb_getConnectionStatus_JLjava_lang_String_;
		}

		static int n_GetConnectionStatus_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetConnectionStatus (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConnectionStatus_JLjava_lang_String_;
		public unsafe int GetConnectionStatus (long p0, string p1)
		{
			if (id_getConnectionStatus_JLjava_lang_String_ == IntPtr.Zero)
				id_getConnectionStatus_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectionStatus", "(JLjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getConnectionStatus_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_listenForConnectionCallbacks_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetListenForConnectionCallbacks_JLjava_lang_String_Handler ()
		{
			if (cb_listenForConnectionCallbacks_JLjava_lang_String_ == null)
				cb_listenForConnectionCallbacks_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_ListenForConnectionCallbacks_JLjava_lang_String_);
			return cb_listenForConnectionCallbacks_JLjava_lang_String_;
		}

		static void n_ListenForConnectionCallbacks_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ListenForConnectionCallbacks (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_listenForConnectionCallbacks_JLjava_lang_String_;
		public unsafe void ListenForConnectionCallbacks (long p0, string p1)
		{
			if (id_listenForConnectionCallbacks_JLjava_lang_String_ == IntPtr.Zero)
				id_listenForConnectionCallbacks_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "listenForConnectionCallbacks", "(JLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_listenForConnectionCallbacks_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_readRemoteRSSI_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadRemoteRSSI_JLjava_lang_String_Handler ()
		{
			if (cb_readRemoteRSSI_JLjava_lang_String_ == null)
				cb_readRemoteRSSI_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_ReadRemoteRSSI_JLjava_lang_String_);
			return cb_readRemoteRSSI_JLjava_lang_String_;
		}

		static bool n_ReadRemoteRSSI_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReadRemoteRSSI (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readRemoteRSSI_JLjava_lang_String_;
		public unsafe bool ReadRemoteRSSI (long p0, string p1)
		{
			if (id_readRemoteRSSI_JLjava_lang_String_ == IntPtr.Zero)
				id_readRemoteRSSI_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readRemoteRSSI", "(JLjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_readRemoteRSSI_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_RegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
		}

		static long n_RegisterCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Flic.Lib.IFlicLibCallbackInterface p0 = (global::IO.Flic.Lib.IFlicLibCallbackInterface)global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibCallbackInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.RegisterCallback (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_;
		public unsafe long RegisterCallback (global::IO.Flic.Lib.IFlicLibCallbackInterface p0, string p1, string p2)
		{
			if (id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerCallback", "(Lio/flic/lib/IFlicLibCallbackInterface;Ljava/lang/String;Ljava/lang/String;)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			long __ret = JNIEnv.CallLongMethod (Handle, id_registerCallback_Lio_flic_lib_IFlicLibCallbackInterface_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setActiveMode_JLjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetActiveMode_JLjava_lang_String_ZHandler ()
		{
			if (cb_setActiveMode_JLjava_lang_String_Z == null)
				cb_setActiveMode_JLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, bool>) n_SetActiveMode_JLjava_lang_String_Z);
			return cb_setActiveMode_JLjava_lang_String_Z;
		}

		static void n_SetActiveMode_JLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, bool p2)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveMode (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setActiveMode_JLjava_lang_String_Z;
		public unsafe void SetActiveMode (long p0, string p1, bool p2)
		{
			if (id_setActiveMode_JLjava_lang_String_Z == IntPtr.Zero)
				id_setActiveMode_JLjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setActiveMode", "(JLjava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_setActiveMode_JLjava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setButtonCallbacks_JLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetButtonCallbacks_JLjava_lang_String_IHandler ()
		{
			if (cb_setButtonCallbacks_JLjava_lang_String_I == null)
				cb_setButtonCallbacks_JLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, int>) n_SetButtonCallbacks_JLjava_lang_String_I);
			return cb_setButtonCallbacks_JLjava_lang_String_I;
		}

		static void n_SetButtonCallbacks_JLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetButtonCallbacks (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setButtonCallbacks_JLjava_lang_String_I;
		public unsafe void SetButtonCallbacks (long p0, string p1, int p2)
		{
			if (id_setButtonCallbacks_JLjava_lang_String_I == IntPtr.Zero)
				id_setButtonCallbacks_JLjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setButtonCallbacks", "(JLjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_setButtonCallbacks_JLjava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_unListenForConnectionCallbacks_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnListenForConnectionCallbacks_JLjava_lang_String_Handler ()
		{
			if (cb_unListenForConnectionCallbacks_JLjava_lang_String_ == null)
				cb_unListenForConnectionCallbacks_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UnListenForConnectionCallbacks_JLjava_lang_String_);
			return cb_unListenForConnectionCallbacks_JLjava_lang_String_;
		}

		static void n_UnListenForConnectionCallbacks_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnListenForConnectionCallbacks (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_unListenForConnectionCallbacks_JLjava_lang_String_;
		public unsafe void UnListenForConnectionCallbacks (long p0, string p1)
		{
			if (id_unListenForConnectionCallbacks_JLjava_lang_String_ == IntPtr.Zero)
				id_unListenForConnectionCallbacks_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unListenForConnectionCallbacks", "(JLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_unListenForConnectionCallbacks_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_unregisterCallback_J;
#pragma warning disable 0169
		static Delegate GetUnregisterCallback_JHandler ()
		{
			if (cb_unregisterCallback_J == null)
				cb_unregisterCallback_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_UnregisterCallback_J);
			return cb_unregisterCallback_J;
		}

		static void n_UnregisterCallback_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterCallback_J;
		public unsafe void UnregisterCallback (long p0)
		{
			if (id_unregisterCallback_J == IntPtr.Zero)
				id_unregisterCallback_J = JNIEnv.GetMethodID (class_ref, "unregisterCallback", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_unregisterCallback_J, __args);
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
			global::IO.Flic.Lib.IFlicLibInterface __this = global::Java.Lang.Object.GetObject<global::IO.Flic.Lib.IFlicLibInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
