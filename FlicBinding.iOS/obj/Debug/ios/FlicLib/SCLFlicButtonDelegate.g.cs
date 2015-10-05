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
	[Register("SCLFlicButtonDelegate", false)]
	[Model]
	public unsafe partial class SCLFlicButtonDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCLFlicButtonDelegate () : base (NSObjectFlag.Empty)
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
		protected SCLFlicButtonDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCLFlicButtonDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("flicButton:didDisconnectWithError:")]
		[CompilerGenerated]
		public virtual void DidDisconnectWithError (SCLFlicButton button, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didFailToConnectWithError:")]
		[CompilerGenerated]
		public virtual void DidFailToConnectWithError (SCLFlicButton button, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didReceiveButtonClick:age:")]
		[CompilerGenerated]
		public virtual void DidReceiveButtonClick (SCLFlicButton button, bool queued, global::System.nint age)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didReceiveButtonDoubleClick:age:")]
		[CompilerGenerated]
		public virtual void DidReceiveButtonDoubleClick (SCLFlicButton button, bool queued, global::System.nint age)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didReceiveButtonDown:age:")]
		[CompilerGenerated]
		public virtual void DidReceiveButtonDown (SCLFlicButton button, bool queued, global::System.nint age)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didReceiveButtonHold:age:")]
		[CompilerGenerated]
		public virtual void DidReceiveButtonHold (SCLFlicButton button, bool queued, global::System.nint age)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didReceiveButtonUp:age:")]
		[CompilerGenerated]
		public virtual void DidReceiveButtonUp (SCLFlicButton button, bool queued, global::System.nint age)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButton:didUpdateRSSI:error:")]
		[CompilerGenerated]
		public virtual void DidUpdateRSSI (SCLFlicButton button, NSNumber RSSI, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButtonDidConnect:")]
		[CompilerGenerated]
		public virtual void FlicButtonDidConnect (SCLFlicButton button)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("flicButtonIsReady:")]
		[CompilerGenerated]
		public virtual void FlicButtonIsReady (SCLFlicButton button)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SCLFlicButtonDelegate */
}
