using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Boolean
    {
        static public RectF2 GetEncompassing(this RectF2 item, RectF2 rect)
        {
            return RectF2Extensions.CreateStrictMinMaxRectF2(
                item.GetLeft().Min(rect.GetLeft()),
                item.GetBottom().Min(rect.GetBottom()),

                item.GetRight().Max(rect.GetRight()),
                item.GetTop().Max(rect.GetTop())
            );
        }

        static public bool TryGetIntersection(this RectF2 item, RectF2 rect, out RectF2 intersection)
        {
            return RectF2Extensions.TryCreateStrictMinMaxRectF2(
                item.GetLeft().Max(rect.GetLeft()),
                item.GetBottom().Max(rect.GetBottom()),

                item.GetRight().Min(rect.GetRight()),
                item.GetTop().Min(rect.GetTop()),
                out intersection
            );
        }
        static public RectF2 GetIntersection(this RectF2 item, RectF2 rect)
        {
            RectF2 intersection;

            item.TryGetIntersection(rect, out intersection);
            return intersection;
        }

        static public IEnumerable<RectF2> GetSubtraction(this RectF2 item, RectF2 to_subtract)
        {
            if (item.TryGetIntersection(to_subtract, out to_subtract) == false)
                yield return item;
            else
            {
                RectF2 left;
                if (RectF2Extensions.TryCreateStrictMinMaxRectF2(
                    item.GetLeft(), to_subtract.GetBottom(),
                    to_subtract.GetLeft(), to_subtract.GetTop(),
                    out left
                )) yield return left;

                RectF2 right;
                if (RectF2Extensions.TryCreateStrictMinMaxRectF2(
                    to_subtract.GetRight(), to_subtract.GetBottom(),
                    item.GetRight(), to_subtract.GetTop(),
                    out right
                )) yield return right;

                RectF2 bottom;
                if (RectF2Extensions.TryCreateStrictMinMaxRectF2(
                    item.GetLeft(), item.GetBottom(),
                    item.GetRight(), to_subtract.GetBottom(),
                    out bottom
                )) yield return bottom;

                RectF2 top;
                if (RectF2Extensions.TryCreateStrictMinMaxRectF2(
                    item.GetLeft(), to_subtract.GetTop(),
                    item.GetRight(), item.GetTop(),
                    out top
                )) yield return top;
            }
        }
    }
}