using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace FlicLib {

	// @interface SCLFlicButton : NSObject
	[BaseType (typeof (NSObject))]
	interface SCLFlicButton {

		// @property (nonatomic, weak) id<SCLFlicButtonDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCLFlicButtonDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCLFlicButtonDelegate Delegate { get; set; }

		// @property (readonly, nonatomic, strong) NSUUID * buttonIdentifier;
		[Export ("buttonIdentifier", ArgumentSemantic.Retain)]
		NSUuid ButtonIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * buttonPublicKey;
		[Export ("buttonPublicKey", ArgumentSemantic.Retain)]
		string ButtonPublicKey { get; }

		// @property (readonly, atomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; }

		// @property (readonly, atomic) SCLFlicButtonConnectionState connectionState;
		[Export ("connectionState")]
		SCLFlicButtonConnectionState ConnectionState { get; }

		// @property (readwrite, nonatomic) SCLFlicButtonMode mode;
		[Export ("mode")]
		SCLFlicButtonMode Mode { get; set; }

		// @property (readwrite, nonatomic) SCLFlicButtonTriggerBehavior triggerBehavior;
		[Export ("triggerBehavior")]
		SCLFlicButtonTriggerBehavior TriggerBehavior { get; set; }

		// @property (readonly, nonatomic) int pressCount;
		[Export ("pressCount")]
		int PressCount { get; }

		// -(void)connect;
		[Export ("connect")]
		void Connect ();

		// -(void)disconnect;
		[Export ("disconnect")]
		void Disconnect ();

		// -(void)indicateLED:(SCLFlicButtonLEDIndicateCount)count;
		[Export ("indicateLED:")]
		void IndicateLED (SCLFlicButtonLEDIndicateCount count);

		// -(void)readRSSI;
		[Export ("readRSSI")]
		void ReadRSSI ();
	}

	// @protocol SCLFlicButtonDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface SCLFlicButtonDelegate {

		// @optional -(void)flicButton:(SCLFlicButton *)button didReceiveButtonDown:(BOOL)queued age:(NSInteger)age;
		[Export ("flicButton:didReceiveButtonDown:age:")]
		void DidReceiveButtonDown (SCLFlicButton button, bool queued, nint age);

		// @optional -(void)flicButton:(SCLFlicButton *)button didReceiveButtonUp:(BOOL)queued age:(NSInteger)age;
		[Export ("flicButton:didReceiveButtonUp:age:")]
		void DidReceiveButtonUp (SCLFlicButton button, bool queued, nint age);

		// @optional -(void)flicButton:(SCLFlicButton *)button didReceiveButtonClick:(BOOL)queued age:(NSInteger)age;
		[Export ("flicButton:didReceiveButtonClick:age:")]
		void DidReceiveButtonClick (SCLFlicButton button, bool queued, nint age);

		// @optional -(void)flicButton:(SCLFlicButton *)button didReceiveButtonDoubleClick:(BOOL)queued age:(NSInteger)age;
		[Export ("flicButton:didReceiveButtonDoubleClick:age:")]
		void DidReceiveButtonDoubleClick (SCLFlicButton button, bool queued, nint age);

		// @optional -(void)flicButton:(SCLFlicButton *)button didReceiveButtonHold:(BOOL)queued age:(NSInteger)age;
		[Export ("flicButton:didReceiveButtonHold:age:")]
		void DidReceiveButtonHold (SCLFlicButton button, bool queued, nint age);

		// @optional -(void)flicButtonDidConnect:(SCLFlicButton *)button;
		[Export ("flicButtonDidConnect:")]
		void FlicButtonDidConnect (SCLFlicButton button);

		// @optional -(void)flicButtonIsReady:(SCLFlicButton *)button;
		[Export ("flicButtonIsReady:")]
		void FlicButtonIsReady (SCLFlicButton button);

		// @optional -(void)flicButton:(SCLFlicButton *)button didDisconnectWithError:(NSError *)error;
		[Export ("flicButton:didDisconnectWithError:")]
		void DidDisconnectWithError (SCLFlicButton button, NSError error);

		// @optional -(void)flicButton:(SCLFlicButton *)button didFailToConnectWithError:(NSError *)error;
		[Export ("flicButton:didFailToConnectWithError:")]
		void DidFailToConnectWithError (SCLFlicButton button, NSError error);

		// @optional -(void)flicButton:(SCLFlicButton *)button didUpdateRSSI:(NSNumber *)RSSI error:(NSError *)error;
		[Export ("flicButton:didUpdateRSSI:error:")]
		void DidUpdateRSSI (SCLFlicButton button, NSNumber RSSI, NSError error);
	}

	// @interface SCLFlicManager : NSObject
	[BaseType (typeof (NSObject))]
	interface SCLFlicManager {

		// -(instancetype)initWithDelegate:(id<SCLFlicManagerDelegate>)delegate appID:(NSString *)appID appSecret:(NSString *)appSecret backgroundExecution:(BOOL)bExecution andRestoreState:(BOOL)restore;
		[Export ("initWithDelegate:appID:appSecret:backgroundExecution:andRestoreState:")]
		IntPtr Constructor (SCLFlicManagerDelegate del, string appID, string appSecret, bool bExecution, bool restore);

		// @property (nonatomic, weak) id<SCLFlicManagerDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SCLFlicManagerDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SCLFlicManagerDelegate Delegate { get; set; }

		// @property (readonly, nonatomic) SCLFlicManagerBluetoothState bluetoothState;
		[Export ("bluetoothState")]
		SCLFlicManagerBluetoothState BluetoothState { get; }

		// @property (readonly, getter = isEnabled) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; }

		// -(NSDictionary *)knownButtons;
		[Export ("knownButtons")]
		NSDictionary KnownButtons ();

		// -(void)forgetButton:(SCLFlicButton *)button;
		[Export ("forgetButton:")]
		void ForgetButton (SCLFlicButton button);

		// -(void)disable;
		[Export ("disable")]
		void Disable ();

		// -(void)enable;
		[Export ("enable")]
		void Enable ();

		// -(void)requestButtonFromFlicAppWithCallback:(NSString *)callback;
		[Export ("requestButtonFromFlicAppWithCallback:")]
		void RequestButtonFromFlicAppWithCallback (string callback);

		// -(SCLFlicButton *)generateButtonFromURL:(NSURL *)url;
		[Export ("generateButtonFromURL:")]
		SCLFlicButton GenerateButtonFromURL (NSUrl url);
	}

	// @protocol SCLFlicManagerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface SCLFlicManagerDelegate {

		// @optional -(void)flicManager:(SCLFlicManager *)manager didChangeBluetoothState:(SCLFlicManagerBluetoothState)state;
		[Export ("flicManager:didChangeBluetoothState:")]
		void DidChangeBluetoothState (SCLFlicManager manager, SCLFlicManagerBluetoothState state);

		// @optional -(void)flicManagerDidRestoreState:(SCLFlicManager *)manager;
		[Export ("flicManagerDidRestoreState:")]
		void FlicManagerDidRestoreState (SCLFlicManager manager);

		// @optional -(void)flicManager:(SCLFlicManager *)manager didForgetButton:(NSUUID *)buttonIdentifier error:(NSError *)error;
		[Export ("flicManager:didForgetButton:error:")]
		void DidForgetButton (SCLFlicManager manager, NSUuid buttonIdentifier, NSError error);
	}
}


