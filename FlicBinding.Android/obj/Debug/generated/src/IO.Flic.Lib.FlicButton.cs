using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Flic.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']"
	[global::Android.Runtime.Register ("io/flic/lib/FlicButton", DoNotGenerateAcw=true)]
	public sealed partial class FlicButton : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/field[@name='BUTTON_CONNECTION_COMPLETED']"
		[Register ("BUTTON_CONNECTION_COMPLETED")]
		public const int ButtonConnectionCompleted = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/field[@name='BUTTON_CONNECTION_STARTED']"
		[Register ("BUTTON_CONNECTION_STARTED")]
		public const int ButtonConnectionStarted = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/field[@name='BUTTON_DISCONNECTED']"
		[Register ("BUTTON_DISCONNECTED")]
		public const int ButtonDisconnected = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/flic/lib/FlicButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlicButton); }
		}

		internal FlicButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getButtonId;
		public unsafe string ButtonId {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='getButtonId' and count(parameter)=0]"
			[Register ("getButtonId", "()Ljava/lang/String;", "GetGetButtonIdHandler")]
			get {
				if (id_getButtonId == IntPtr.Zero)
					id_getButtonId = JNIEnv.GetMethodID (class_ref, "getButtonId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getButtonId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCallbackFlags;
		public unsafe int CallbackFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='getCallbackFlags' and count(parameter)=0]"
			[Register ("getCallbackFlags", "()I", "GetGetCallbackFlagsHandler")]
			get {
				if (id_getCallbackFlags == IntPtr.Zero)
					id_getCallbackFlags = JNIEnv.GetMethodID (class_ref, "getCallbackFlags", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCallbackFlags);
				} finally {
				}
			}
		}

		static IntPtr id_getColor;
		public unsafe string Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()Ljava/lang/String;", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColor), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getConnectionStatus;
		public unsafe int ConnectionStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='getConnectionStatus' and count(parameter)=0]"
			[Register ("getConnectionStatus", "()I", "GetGetConnectionStatusHandler")]
			get {
				if (id_getConnectionStatus == IntPtr.Zero)
					id_getConnectionStatus = JNIEnv.GetMethodID (class_ref, "getConnectionStatus", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getConnectionStatus);
				} finally {
				}
			}
		}

		static IntPtr id_addFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='addFlicButtonCallback' and count(parameter)=1 and parameter[1][@type='io.flic.lib.FlicButtonCallback']]"
		[Register ("addFlicButtonCallback", "(Lio/flic/lib/FlicButtonCallback;)V", "")]
		public unsafe void AddFlicButtonCallback (global::IO.Flic.Lib.FlicButtonCallback p0)
		{
			if (id_addFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_ == IntPtr.Zero)
				id_addFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_ = JNIEnv.GetMethodID (class_ref, "addFlicButtonCallback", "(Lio/flic/lib/FlicButtonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_addFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_readRemoteRSSI;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='readRemoteRSSI' and count(parameter)=0]"
		[Register ("readRemoteRSSI", "()Z", "")]
		public unsafe bool ReadRemoteRSSI ()
		{
			if (id_readRemoteRSSI == IntPtr.Zero)
				id_readRemoteRSSI = JNIEnv.GetMethodID (class_ref, "readRemoteRSSI", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_readRemoteRSSI);
			} finally {
			}
		}

		static IntPtr id_removeAllFlicButtonCallbacks;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='removeAllFlicButtonCallbacks' and count(parameter)=0]"
		[Register ("removeAllFlicButtonCallbacks", "()V", "")]
		public unsafe void RemoveAllFlicButtonCallbacks ()
		{
			if (id_removeAllFlicButtonCallbacks == IntPtr.Zero)
				id_removeAllFlicButtonCallbacks = JNIEnv.GetMethodID (class_ref, "removeAllFlicButtonCallbacks", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_removeAllFlicButtonCallbacks);
			} finally {
			}
		}

		static IntPtr id_removeFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='removeFlicButtonCallback' and count(parameter)=1 and parameter[1][@type='io.flic.lib.FlicButtonCallback']]"
		[Register ("removeFlicButtonCallback", "(Lio/flic/lib/FlicButtonCallback;)V", "")]
		public unsafe void RemoveFlicButtonCallback (global::IO.Flic.Lib.FlicButtonCallback p0)
		{
			if (id_removeFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_ == IntPtr.Zero)
				id_removeFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_ = JNIEnv.GetMethodID (class_ref, "removeFlicButtonCallback", "(Lio/flic/lib/FlicButtonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_removeFlicButtonCallback_Lio_flic_lib_FlicButtonCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_setActiveMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='setActiveMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setActiveMode", "(Z)Z", "")]
		public unsafe bool SetActiveMode (bool p0)
		{
			if (id_setActiveMode_Z == IntPtr.Zero)
				id_setActiveMode_Z = JNIEnv.GetMethodID (class_ref, "setActiveMode", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_setActiveMode_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setFlicButtonCallbackFlags_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.flic.lib']/class[@name='FlicButton']/method[@name='setFlicButtonCallbackFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFlicButtonCallbackFlags", "(I)Z", "")]
		public unsafe bool SetFlicButtonCallbackFlags (int p0)
		{
			if (id_setFlicButtonCallbackFlags_I == IntPtr.Zero)
				id_setFlicButtonCallbackFlags_I = JNIEnv.GetMethodID (class_ref, "setFlicButtonCallbackFlags", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_setFlicButtonCallbackFlags_I, __args);
			} finally {
			}
		}

	}
}
