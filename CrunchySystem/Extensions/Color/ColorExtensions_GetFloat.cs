using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
    static public class ColorExtensions_GetFloat
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