using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ColorExtensions_Float_GetWith
    {
        static public Color GetWithFloatRed(this Color item, float red)
        {
            return item.GetWithRed(red.GetBytePercent());
        }

        static public Color GetWithFloatGreen(this Color item, float green)
        {
            return item.GetWithGreen(green.GetBytePercent());
        }

        static public Color GetWithFloatBlue(this Color item, float blue)
        {
            return item.GetWithBlue(blue.GetBytePercent());
        }

        static public Color GetWithFloatAlpha(this Color item, float alpha)
        {
            return item.GetWithAlpha(alpha.GetBytePercent());
        }
    }
}