//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace FlicLib {
	[Register("SCLFlicManager", true)]
	public unsafe partial class SCLFlicManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCLFlicManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCLFlicManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCLFlicManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCLFlicManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:appID:appSecret:backgroundExecution:andRestoreState:")]
		[CompilerGenerated]
		public SCLFlicManager (SCLFlicManagerDelegate del, string appID, string appSecret, bool bExecution, bool restore)
			: base (NSObjectFlag.Empty)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (appID == null)
				throw new ArgumentNullException ("appID");
			if (appSecret == null)
				throw new ArgumentNullException ("appSecret");
			var nsappID = NSString.CreateNative (appID);
			var nsappSecret = NSString.CreateNative (appSecret);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_bool (this.Handle, Selector.GetHandle ("initWithDelegate:appID:appSecret:backgroundExecution:andRestoreState:"), del.Handle, nsappID, nsappSecret, bExecution, restore), "initWithDelegate:appID:appSecret:backgroundExecution:andRestoreState:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_bool (this.SuperHandle, Selector.GetHandle ("initWithDelegate:appID:appSecret:backgroundExecution:andRestoreState:"), del.Handle, nsappID, nsappSecret, bExecution, restore), "initWithDelegate:appID:appSecret:backgroundExecution:andRestoreState:");
			}
			NSString.ReleaseNative (nsappID);
			NSString.ReleaseNative (nsappSecret);
			
		}
		
		[Export ("disable")]
		[CompilerGenerated]
		public virtual void Disable ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disable"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disable"));
			}
		}
		
		[Export ("enable")]
		[CompilerGenerated]
		public virtual void Enable ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("enable"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enable"));
			}
		}
		
		[Export ("forgetButton:")]
		[CompilerGenerated]
		public virtual void ForgetButton (SCLFlicButton button)
		{
			if (button == null)
				throw new ArgumentNullException ("button");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("forgetButton:"), button.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("forgetButton:"), button.Handle);
			}
		}
		
		[Export ("generateButtonFromURL:")]
		[CompilerGenerated]
		public virtual SCLFlicButton GenerateButtonFromURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<SCLFlicButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("generateButtonFromURL:"), url.Handle));
			} else {
				return  Runtime.GetNSObject<SCLFlicButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("generateButtonFromURL:"), url.Handle));
			}
		}
		
		[Export ("knownButtons")]
		[CompilerGenerated]
		public virtual NSDictionary KnownButtons ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("knownButtons")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("knownButtons")));
			}
		}
		
		[Export ("requestButtonFromFlicAppWithCallback:")]
		[CompilerGenerated]
		public virtual void RequestButtonFromFlicAppWithCallback (string callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nscallback = NSString.CreateNative (callback);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("requestButtonFromFlicAppWithCallback:"), nscallback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("requestButtonFromFlicAppWithCallback:"), nscallback);
			}
			NSString.ReleaseNative (nscallback);
			
		}
		
		[CompilerGenerated]
		public virtual SCLFlicManagerBluetoothState BluetoothState {
			[Export ("bluetoothState")]
			get {
				SCLFlicManagerBluetoothState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicManagerBluetoothState) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("bluetoothState"));
					} else {
						ret = (SCLFlicManagerBluetoothState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("bluetoothState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicManagerBluetoothState) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bluetoothState"));
					} else {
						ret = (SCLFlicManagerBluetoothState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bluetoothState"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public SCLFlicManagerDelegate Delegate {
			get {
				return WeakDelegate as /**/SCLFlicManagerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class SCLFlicManager */
}
