using System;

namespace Crunchy.Dough
{
    static public class LineSegmentF2Extensions_Point
    {
        static public VectorF2 GetPointAlong(this LineSegmentF2 item, float distance)
        {
            return item.GetLine().GetPointAlong(distance);
        }

        static public VectorF2 GetPointInterpolate(this LineSegmentF2 item, float percent)
        {
            return item.p1.GetInterpolate(item.p2, percent);
        }
    }
}