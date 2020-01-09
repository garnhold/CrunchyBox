using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class ColorExtensions_GetScaled
    {
        static public Color GetScaled(this Color item, float scale)
        {
            return Color.FromArgb(
                (int)(item.A * scale),
                (int)(item.R * scale),
                (int)(item.G * scale),
                (int)(item.B * scale)
            );
        }
    }
}