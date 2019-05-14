using System;
using System.Drawing;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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