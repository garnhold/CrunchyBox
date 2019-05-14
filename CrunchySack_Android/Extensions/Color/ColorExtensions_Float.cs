using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ColorExtensions_Float
    {
        static public float GetRedFloat(this Color item)
        {
            return item.R.GetFloatPercent();
        }

        static public float GetGreenFloat(this Color item)
        {
            return item.G.GetFloatPercent();
        }

        static public float GetBlueFloat(this Color item)
        {
            return item.B.GetFloatPercent();
        }

        static public float GetAlphaFloat(this Color item)
        {
            return item.A.GetFloatPercent();
        }
    }
}