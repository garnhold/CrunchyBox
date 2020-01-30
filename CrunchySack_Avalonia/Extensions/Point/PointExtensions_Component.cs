using System;

using Avalonia;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class PointExtensions_Component
    {
        static public Point GetComponentMultiply(this Point item, double x, double y)
        {
            return new Point(item.X * x, item.Y * y);
        }
        static public Point GetComponentMultiply(this Point item, Point other)
        {
            return item.GetComponentMultiply(other.X, other.Y);
        }

        static public Point GetComponentDivide(this Point item, double x, double y)
        {
            return new Point(item.X / x, item.Y / y);
        }
        static public Point GetComponentDivide(this Point item, Point other)
        {
            return item.GetComponentDivide(other.X, other.Y);
        }

        static public double GetMaxComponent(this Point item)
        {
            return item.X.Max(item.Y);
        }

        static public double GetMinComponent(this Point item)
        {
            return item.X.Min(item.Y);
        }
    }
}