using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class RectF2Extensions_Constrain
    {
        static public RectF2 GetConstrainedBelowX(this RectF2 item, float x)
        {
            if (item.GetRight() > x)
                return item.GetHorizontallyShifted(x - item.GetRight());

            return item;
        }

        static public RectF2 GetConstrainedAboveX(this RectF2 item, float x)
        {
            if (item.GetLeft() < x)
                return item.GetHorizontallyShifted(x - item.GetLeft());

            return item;
        }

        static public RectF2 GetConstrainedBelowY(this RectF2 item, float y)
        {
            if (item.GetTop() > y)
                return item.GetVerticallyShifted(y - item.GetTop());

            return item;
        }

        static public RectF2 GetConstrainedAboveY(this RectF2 item, float y)
        {
            if (item.GetBottom() < y)
                return item.GetVerticallyShifted(y - item.GetBottom());

            return item;
        }

        static public bool TryGetConstrainedBy(this RectF2 item, RectF2 bounds, out RectF2 output)
        {
            output = item.GetConstrainedAboveX(bounds.GetLeft())
                .GetConstrainedBelowX(bounds.GetRight())
                .GetConstrainedAboveY(bounds.GetBottom())
                .GetConstrainedBelowY(bounds.GetTop());

            if (bounds.FullyContains(output))
                return true;

            return false;
        }

        static public RectF2 GetConstrainedByOrShrunk(this RectF2 item, RectF2 bounds)
        {
            if (item.TryGetConstrainedBy(bounds, out item))
                return item;

            return bounds.GetIntersection(item);
        }
    }
}