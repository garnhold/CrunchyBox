using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class LineSegmentF2Extensions_Intersection_LineSegmentF2
    {
        static public bool TryGetIntersection(this LineSegmentF2 item, LineSegmentF2 line_segment, out float distance, out VectorF2 point)
        {
            if (item.TryGetIntersection(line_segment.GetLine(), out distance, out point))
            {
                if (line_segment.GetRectF2().Contains(point))
                    return true;
            }

            return false;
        }
        static public bool TryGetIntersection(this LineSegmentF2 item, LineSegmentF2 line_segment, out float distance)
        {
            VectorF2 point;

            return item.TryGetIntersection(line_segment, out distance, out point);
        }
        static public bool TryGetIntersection(this LineSegmentF2 item, LineSegmentF2 line_segment, out VectorF2 point)
        {
            float distance;

            return item.TryGetIntersection(line_segment, out distance, out point);
        }
        static public bool IsIntersecting(this LineSegmentF2 item, LineSegmentF2 line_segment)
        {
            float distance;
            VectorF2 point;

            return item.TryGetIntersection(line_segment, out distance, out point);
        }

        static public bool TryGetIntersectionPercent(this LineSegmentF2 item, LineSegmentF2 line_segment, out float percent, out VectorF2 point)
        {
            float distance;

            if (item.TryGetIntersection(line_segment, out distance, out point))
            {
                percent = distance / item.GetLength();

                return true;
            }

            percent = 0.0f;
            return false;
        }
        static public bool TryGetIntersectionPercent(this LineSegmentF2 item, LineSegmentF2 line_segment, out float percent)
        {
            VectorF2 point;

            return item.TryGetIntersectionPercent(line_segment, out percent, out point);
        }
    }
}