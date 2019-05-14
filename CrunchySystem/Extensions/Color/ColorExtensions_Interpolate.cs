using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
    static public class ColorExtensions_Interpolate
    {
        static public Color GetInterpolate(this Color item, Color target, float amount)
        {
            amount = amount.BindBetween(0.0f, 1.0f);

            return item.GetScaled(1.0f - amount).GetAdded(
                target.GetScaled(amount)
            );
        }
    }
}