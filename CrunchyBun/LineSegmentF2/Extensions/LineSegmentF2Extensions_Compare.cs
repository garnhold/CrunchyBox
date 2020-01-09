using System;

namespace Crunchy.Bun
{
    static public class LineSegmentF2Extensions_Compare
    {
        static public bool IsTerminus(this LineSegmentF2 item, VectorF2 point)
        {
            if (item.p1 == point || item.p2 == point)
                return true;

            return false;
        }

        static public bool IsContinuation(this LineSegmentF2 item, LineSegmentF2 line_segment)
        {
            if (item.IsTerminus(line_segment.p1) || item.IsTerminus(line_segment.p2))
                return true;

            return false;
        }
    }
}