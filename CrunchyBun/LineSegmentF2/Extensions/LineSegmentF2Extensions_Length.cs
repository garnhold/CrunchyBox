using System;

namespace Crunchy.Bun
{
    static public class LineSegmentF2Extensions_Length
    {
        static public float GetLength(this LineSegmentF2 item)
        {
            return item.p1.GetDistanceTo(item.p2);
        }

        static public float GetSquaredLength(this LineSegmentF2 item)
        {
            return item.p1.GetSquaredDistanceTo(item.p2);
        }
    }
}