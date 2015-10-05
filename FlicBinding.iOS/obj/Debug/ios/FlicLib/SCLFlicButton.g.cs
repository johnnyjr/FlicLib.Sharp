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
	[Register("SCLFlicButton", true)]
	public unsafe partial class SCLFlicButton : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCLFlicButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCLFlicButton () : base (NSObjectFlag.Empty)
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
		protected SCLFlicButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCLFlicButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("connect")]
		[CompilerGenerated]
		public virtual void Connect ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("connect"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connect"));
			}
		}
		
		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disconnect"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disconnect"));
			}
		}
		
		[Export ("indicateLED:")]
		[CompilerGenerated]
		public virtual void IndicateLED (SCLFlicButtonLEDIndicateCount count)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("indicateLED:"), (Int64)count);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("indicateLED:"), (int)count);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("indicateLED:"), (Int64)count);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("indicateLED:"), (int)count);
				}
			}
		}
		
		[Export ("readRSSI")]
		[CompilerGenerated]
		public virtual void ReadRSSI ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("readRSSI"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readRSSI"));
			}
		}
		
		[CompilerGenerated]
		object __mt_ButtonIdentifier_var;
		[CompilerGenerated]
		public virtual NSUuid ButtonIdentifier {
			[Export ("buttonIdentifier", ArgumentSemantic.Retain)]
			get {
				NSUuid ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUuid> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonIdentifier")));
				} else {
					ret =  Runtime.GetNSObject<NSUuid> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonIdentifier")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ButtonIdentifier_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ButtonPublicKey {
			[Export ("buttonPublicKey", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonPublicKey")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonPublicKey")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual SCLFlicButtonConnectionState ConnectionState {
			[Export ("connectionState")]
			get {
				SCLFlicButtonConnectionState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicButtonConnectionState) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("connectionState"));
					} else {
						ret = (SCLFlicButtonConnectionState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("connectionState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicButtonConnectionState) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionState"));
					} else {
						ret = (SCLFlicButtonConnectionState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionState"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public SCLFlicButtonDelegate Delegate {
			get {
				return WeakDelegate as /**/SCLFlicButtonDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual SCLFlicButtonMode Mode {
			[Export ("mode")]
			get {
				SCLFlicButtonMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicButtonMode) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("mode"));
					} else {
						ret = (SCLFlicButtonMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("mode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicButtonMode) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mode"));
					} else {
						ret = (SCLFlicButtonMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mode"));
					}
				}
				return ret;
			}
			
			[Export ("setMode:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMode:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setMode:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMode:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int PressCount {
			[Export ("pressCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("pressCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pressCount"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual SCLFlicButtonTriggerBehavior TriggerBehavior {
			[Export ("triggerBehavior")]
			get {
				SCLFlicButtonTriggerBehavior ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicButtonTriggerBehavior) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("triggerBehavior"));
					} else {
						ret = (SCLFlicButtonTriggerBehavior) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("triggerBehavior"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (SCLFlicButtonTriggerBehavior) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("triggerBehavior"));
					} else {
						ret = (SCLFlicButtonTriggerBehavior) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("triggerBehavior"));
					}
				}
				return ret;
			}
			
			[Export ("setTriggerBehavior:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setTriggerBehavior:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setTriggerBehavior:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setTriggerBehavior:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setTriggerBehavior:"), (int)value);
					}
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
				__mt_ButtonIdentifier_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class SCLFlicButton */
}
