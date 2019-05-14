using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

using CrunchyDough;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ColorExtensions
    {
        static public Color CreateFloatColor(float r, float g, float b, float a = 1.0f)
        {
            return new Color(
                r.GetBytePercent(),
                g.GetBytePercent(),
                b.GetBytePercent(),
                a.GetBytePercent()
            );
        }
    }
}