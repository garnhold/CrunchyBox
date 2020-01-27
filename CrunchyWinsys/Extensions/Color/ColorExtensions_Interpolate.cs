using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class ColorExtensions_Interpolate
    {
        static public Color GetInterpolate(this Color item, Color target, float amount)
        {
            amount = amount.BindPercent();

            return item.GetScaled(1.0f - amount).GetAdded(
                target.GetScaled(amount)
            );
        }
    }
}