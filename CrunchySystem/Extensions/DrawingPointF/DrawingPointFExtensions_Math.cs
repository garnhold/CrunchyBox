using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
    static public class DrawingPointFExtensions_Math
    {
        static public PointF GetAdd(this PointF item, PointF target)
        {
            return new PointF(item.X + target.X, item.Y + target.Y);
        }

        static public PointF GetSubtract(this PointF item, PointF target)
        {
            return new PointF(item.X - target.X, item.Y - target.Y);
        }

        static public PointF GetAbs(this PointF item)
        {
            return new PointF(Math.Abs(item.X), Math.Abs(item.Y));
        }
    }
}