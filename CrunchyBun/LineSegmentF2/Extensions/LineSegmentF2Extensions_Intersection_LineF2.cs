using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class LineSegmentF2Extensions_Intersection_LineF2
    {
        static public bool TryGetIntersection(this LineSegmentF2 item, LineF2 line, out float distance, out VectorF2 point)
        {
            if (item.GetLine().TryGetIntersection(line, out distance, out point))
            {
                if (item.GetRectF2().Contains(point))
                    return true;
            }

            return false;
        }
        static public bool TryGetIntersection(this LineSegmentF2 item, LineF2 line, out float distance)
        {
            VectorF2 point;

            return item.TryGetIntersection(line, out distance, out point);
        }
        static public bool TryGetIntersection(this LineSegmentF2 item, LineF2 line, out VectorF2 point)
        {
            float distance;

            return item.TryGetIntersection(line, out distance, out point);
        }
        static public bool IsIntersecting(this LineSegmentF2 item, LineF2 line)
        {
            float distance;
            VectorF2 point;

            return item.TryGetIntersection(line, out distance, out point);
        }
    }
}