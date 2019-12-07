using System;

namespace Crunchy.Bun
{
    static public class LineF2Extensions_Intersection
    {
        static public bool IsIntersecting(this LineF2 item, LineF2 line)
        {
            if (item.direction != line.direction)
                return true;

            return false;
        }

        static public bool TryGetIntersection(this LineF2 item, LineF2 line, out float distance)
        {
            VectorF2 offset = item.point - line.point;

            if (item.IsIntersecting(line))
            {
                distance = (line.direction.x * offset.y - line.direction.y * offset.x) /
                    (line.direction.y * item.direction.x - line.direction.x * item.direction.y);

                return true;
            }

            distance = 0.0f;
            return false;
        }

        static public bool TryGetIntersection(this LineF2 item, LineF2 line, out float distance, out VectorF2 point)
        {
            if (item.TryGetIntersection(line, out distance))
            {
                point = item.GetPointAlong(distance);

                return true;
            }

            point = default(VectorF2);
            return false;
        }

        static public bool TryGetIntersection(this LineF2 item, LineF2 line, out VectorF2 point)
        {
            float distance;

            return item.TryGetIntersection(line, out distance, out point);
        }
    }
}