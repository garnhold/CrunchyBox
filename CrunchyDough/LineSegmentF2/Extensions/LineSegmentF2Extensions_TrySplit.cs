using System;

namespace Crunchy.Dough
{
    static public class LineSegmentF2Extensions_TrySplit
    {
        static public bool TrySplit(this LineSegmentF2 item, LineF2 line, out LineSegmentF2 line_segment1, out LineSegmentF2 line_segment2)
        {
            VectorF2 point;

            if (item.TryGetIntersection(line, out point))
            {
                line_segment1 = new LineSegmentF2(item.p1, point);
                line_segment2 = new LineSegmentF2(point, item.p2);

                return true;
            }

            line_segment1 = default(LineSegmentF2);
            line_segment2 = default(LineSegmentF2);
            return false;
        }

        static public bool TrySplit(this LineSegmentF2 item, LineSegmentF2 line_segment, out LineSegmentF2 line_segment1, out LineSegmentF2 line_segment2)
        {
            VectorF2 point;

            if (item.TryGetIntersection(line_segment, out point))
            {
                line_segment1 = new LineSegmentF2(item.p1, point);
                line_segment2 = new LineSegmentF2(point, item.p2);

                return true;
            }

            line_segment1 = default(LineSegmentF2);
            line_segment2 = default(LineSegmentF2);
            return false;
        }
    }
}