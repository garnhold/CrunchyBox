using System;
using System.Drawing;

namespace Crunchy.System
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class ColorExtensions_GetDistance
    {
        static public float GetDistance(this Color item, Color other)
        {
            item = item.ConvertStraightToPremultiplied();
            other = other.ConvertStraightToPremultiplied();

            return Mathq.Sqrt(
                (item.R - other.R).GetSquared() +
                (item.G - other.G).GetSquared() +
                (item.B - other.B).GetSquared()
            );
        }
    }
}