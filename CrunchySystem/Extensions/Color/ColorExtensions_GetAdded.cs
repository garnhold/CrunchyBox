using System;
using System.Drawing;

namespace Crunchy.System
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class ColorExtensions_GetAdded
    {
        static public Color GetAdded(this Color item, Color other)
        {
            return Color.FromArgb(
                item.A + other.A,
                item.R + other.R,
                item.G + other.G,
                item.B + other.B
            );
        }
    }
}