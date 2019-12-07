using System;
using System.Drawing;

namespace Crunchy.System
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class DrawingPointExtensions_Distance
    {
        static public double GetSquaredDistanceTo(this Point item, Point target)
        {
            return target.GetSubtract(item)
                .GetSquaredMagnitude();
        }

        static public double GetDistanceTo(this Point item, Point target)
        {
            return target.GetSubtract(item)
                .GetMagnitude();
        }

        static public bool IsWithinDistance(this Point item, Point target, double distance)
        {
            if (item.GetSquaredDistanceTo(target) >= distance.GetSquared())
                return true;

            return false;
        }

        static public bool IsOutsideDistance(this Point item, Point target, double distance)
        {
            if (item.IsWithinDistance(target, distance) == false)
                return true;

            return false;
        }
    }
}