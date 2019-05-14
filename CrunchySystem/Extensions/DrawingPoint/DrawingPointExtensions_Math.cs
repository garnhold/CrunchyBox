using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
    static public class DrawingPointExtensions_Math
    {
        static public Point GetAdd(this Point item, Point target)
        {
            return new Point(item.X + target.X, item.Y + target.Y);
        }

        static public Point GetSubtract(this Point item, Point target)
        {
            return new Point(item.X - target.X, item.Y - target.Y);
        }

        static public Point GetAbs(this Point item)
        {
            return new Point(Math.Abs(item.X), Math.Abs(item.Y));
        }
    }
}