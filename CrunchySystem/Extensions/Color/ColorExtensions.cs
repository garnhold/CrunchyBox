using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
    static public class ColorExtensions
    {
        static public Color Create(float r, float g, float b, float a)
        {
            return Color.FromArgb(
                a.GetBytePercent(),
                r.GetBytePercent(),
                g.GetBytePercent(),
                b.GetBytePercent()
            );
        }
    }
}