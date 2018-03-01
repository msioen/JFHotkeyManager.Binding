[![NuGet Status](http://img.shields.io/nuget/v/HotkeyManager.Binding.svg?style=flat)](https://www.nuget.org/packages/HotkeyManager.Binding/)

# HotkeyManager.Binding

Xamarin binding for the [JFHotkeyManager](https://github.com/jaz303/JFHotkeyManager)

JFHotkeyManager is a small Cocoa convenience wrapper around Carbon's mechanism for implementing global hotkeys. It allows you to add hotkeys to your app with a couple of lines of code.

# Usage

Hotkeys can be bound either by individually specifying keycode/modifiers, or symbolically using a string. The latter is more convenient but probably less reliable across international keyboards.

```c#
// Initialise a new hotkey manager
var hotkeyManager = new JFHotkeyManager();
            
// Bind a hotkey by key code reference number and modifiers:
hotkeyManager.BindKeyRef(49, (uint)(EModifierKeys.CmdKey | EModifierKeys.ShiftKey), this, new ObjCRuntime.Selector("onHotkeyExecuted"));
            
// Bind a hotkey symbolically
hotkeyManager.Bind("command shift up", this, new ObjCRuntime.Selector("onHotkeyExecuted"));

[Export("onHotkeyExecuted")]
void OnHotkeyExecuted()
{
  // do something
}

```