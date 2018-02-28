using ObjCRuntime;

[assembly: LinkWith("libHotKeyManager.a", LinkTarget.x86_64, IsCxx = true, SmartLink = true, ForceLoad = true, Frameworks = "Cocoa Carbon", WeakFrameworks = "", LinkerFlags = "")]