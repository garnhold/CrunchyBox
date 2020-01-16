using System;

using Avalonia;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class PointExtensions_Math
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