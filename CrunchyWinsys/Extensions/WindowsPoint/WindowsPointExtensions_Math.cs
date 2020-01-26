using System;
using System.Windows;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class WindowsPointExtensions_Math
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