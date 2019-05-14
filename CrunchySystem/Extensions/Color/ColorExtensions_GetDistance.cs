using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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