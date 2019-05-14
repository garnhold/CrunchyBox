using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
    static public class DrawingPointFExtensions_Magnitude
    {
        static public double GetSquaredMagnitude(this PointF item)
        {
            return item.X.GetSquared() + item.Y.GetSquared();
        }

        static public double GetMagnitude(this PointF item)
        {
            return Math.Sqrt(item.GetSquaredMagnitude());
        }
    }
}