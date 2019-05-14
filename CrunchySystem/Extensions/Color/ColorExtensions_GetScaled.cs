using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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