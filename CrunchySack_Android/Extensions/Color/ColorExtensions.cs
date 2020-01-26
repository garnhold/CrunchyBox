using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
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