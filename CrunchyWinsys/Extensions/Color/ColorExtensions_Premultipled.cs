using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class ColorExtensions_Premultipled
    {
        static public Color ConvertStraightToPremultiplied(this Color item)
        {
            float alpha = item.GetAlphaFloat();

            return ColorExtensions.Create(
                item.GetRedFloat() * alpha,
                item.GetGreenFloat() * alpha,
                item.GetBlueFloat() * alpha,
                alpha
            );
        }

        static public Color ConvertPremultipliedToStraight(this Color item)
        {
            float alpha = item.GetAlphaFloat();

            return ColorExtensions.Create(
                item.GetRedFloat() / alpha,
                item.GetGreenFloat() / alpha,
                item.GetBlueFloat() / alpha,
                alpha
            );
        }
    }
}