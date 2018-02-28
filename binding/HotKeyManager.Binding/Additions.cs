using System;

namespace HotKeyManager
{
    enum EModifierKeys
    {
        ActiveFlag = 1 << 0,
        BtnState = 1 << 7,
        CmdKey = 1 << 8,
        ShiftKey = 1 << 9,
        AlphaLock = 1 << 10,
        OptionKey = 1 << 11,
        ControlKey = 1 << 12,
        RightShiftKey = 1 << 13, /* Not supported on Mac OS X.*/
        RightOptionKey = 1 << 14, /* Not supported on Mac OS X.*/
        RightControlKey = 1 << 15 /* Not supported on Mac OS X.*/
    };
}
