using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    static public class ColorExtensions_GetWith
    {
        static public Color GetWithRed(this Color item, byte red)
        {
            return new Color(red, item.G, item.B, item.A);
        }

        static public Color GetWithGreen(this Color item, byte green)
        {
            return new Color(item.R, green, item.B, item.A);
        }

        static public Color GetWithBlue(this Color item, byte blue)
        {
            return new Color(item.R, item.G, blue, item.A);
        }

        static public Color GetWithAlpha(this Color item, byte alpha)
        {
            return new Color(item.R, item.G, item.B, alpha);
        }
    }
}