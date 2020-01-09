using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class DrawingPointFExtensions_Distance
    {
        static public double GetSquaredDistanceTo(this PointF item, PointF target)
        {
            return target.GetSubtract(item)
                .GetSquaredMagnitude();
        }

        static public double GetDistanceTo(this PointF item, PointF target)
        {
            return target.GetSubtract(item)
                .GetMagnitude();
        }

        static public bool IsWithinDistance(this PointF item, PointF target, double distance)
        {
            if (item.GetSquaredDistanceTo(target) >= distance.GetSquared())
                return true;

            return false;
        }

        static public bool IsOutsideDistance(this PointF item, PointF target, double distance)
        {
            if (item.IsWithinDistance(target, distance) == false)
                return true;

            return false;
        }
    }
}