using System;
using Foundation;
using ObjCRuntime;

namespace HotKeyManager
{
	// @interface JFHotkeyManager : NSObject
	[BaseType (typeof(NSObject))]
	interface JFHotkeyManager
	{
		// -(JFHotKeyRef)bind:(NSString *)commandString target:(id)target action:(SEL)selector;
		[Export ("bind:target:action:")]
		nuint Bind (string commandString, NSObject target, Selector selector);

		// -(JFHotKeyRef)bindKeyRef:(UInt32)keyRef withModifiers:(UInt32)modifiers target:(id)target action:(SEL)selector;
		[Export ("bindKeyRef:withModifiers:target:action:")]
		nuint BindKeyRef (uint keyRef, uint modifiers, NSObject target, Selector selector);

		// -(void)unbind:(JFHotKeyRef)keyRef;
		[Export ("unbind:")]
		void Unbind (nuint keyRef);

		// -(void)_dispatch:(NSUInteger)hotkeyId;
		[Export ("_dispatch:")]
		void _dispatch (nuint hotkeyId);
	}

	// @interface __JFHotkey : NSObject
	[BaseType (typeof(NSObject))]
	interface __JFHotkey
	{
		// -(id)initWithHotkeyID:(UInt32)hotkeyID keyRef:(UInt32)keyRef modifiers:(UInt32)modifiers target:(id)target action:(SEL)selector;
		[Export ("initWithHotkeyID:keyRef:modifiers:target:action:")]
		IntPtr Constructor (uint hotkeyID, uint keyRef, uint modifiers, NSObject target, Selector selector);

		// -(void)invoke;
		[Export ("invoke")]
		void Invoke ();
	}
}
