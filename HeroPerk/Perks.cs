using System;

namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        None = 0,
        WarpShift = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
}
