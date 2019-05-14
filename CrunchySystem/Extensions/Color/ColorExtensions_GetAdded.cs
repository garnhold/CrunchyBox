using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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