using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Boolean
    {
        static public RectI2 GetEncompassing(this RectI2 item, RectI2 rect)
        {
            return RectI2Extensions.CreateStrictMinMaxRectI2(
                item.GetLeft().Min(rect.GetLeft()),
                item.GetBottom().Min(rect.GetBottom()),

                item.GetRight().Max(rect.GetRight()),
                item.GetTop().Max(rect.GetTop())
            );
        }

        static public bool TryGetIntersection(this RectI2 item, RectI2 rect, out RectI2 intersection)
        {
            return RectI2Extensions.TryCreateStrictMinMaxRectI2(
                item.GetLeft().Max(rect.GetLeft()),
                item.GetBottom().Max(rect.GetBottom()),

                item.GetRight().Min(rect.GetRight()),
                item.GetTop().Min(rect.GetTop()),
                out intersection
            );
        }
        static public RectI2 GetIntersection(this RectI2 item, RectI2 rect)
        {
            RectI2 intersection;

            item.TryGetIntersection(rect, out intersection);
            return intersection;
        }

        static public IEnumerable<RectI2> GetSubtraction(this RectI2 item, RectI2 to_subtract)
        {
            if (item.TryGetIntersection(to_subtract, out to_subtract) == false)
                yield return item;
            else
            {
                RectI2 left;
                if (RectI2Extensions.TryCreateStrictMinMaxRectI2(
                    item.GetLeft(), to_subtract.GetBottom(),
                    to_subtract.GetLeft(), to_subtract.GetTop(),
                    out left
                )) yield return left;

                RectI2 right;
                if (RectI2Extensions.TryCreateStrictMinMaxRectI2(
                    to_subtract.GetRight(), to_subtract.GetBottom(),
                    item.GetRight(), to_subtract.GetTop(),
                    out right
                )) yield return right;

                RectI2 bottom;
                if (RectI2Extensions.TryCreateStrictMinMaxRectI2(
                    item.GetLeft(), item.GetBottom(),
                    item.GetRight(), to_subtract.GetBottom(),
                    out bottom
                )) yield return bottom;

                RectI2 top;
                if (RectI2Extensions.TryCreateStrictMinMaxRectI2(
                    item.GetLeft(), to_subtract.GetTop(),
                    item.GetRight(), item.GetTop(),
                    out top
                )) yield return top;
            }
        }
    }
}