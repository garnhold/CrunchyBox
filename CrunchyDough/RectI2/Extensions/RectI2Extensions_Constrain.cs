using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Constrain
    {
        static public RectI2 GetConstrainedBelowX(this RectI2 item, int x)
        {
            if (item.GetRight() > x)
                return item.GetHorizontallyShifted(x - item.GetRight());

            return item;
        }

        static public RectI2 GetConstrainedAboveX(this RectI2 item, int x)
        {
            if (item.GetLeft() < x)
                return item.GetHorizontallyShifted(x - item.GetLeft());

            return item;
        }

        static public RectI2 GetConstrainedBelowY(this RectI2 item, int y)
        {
            if (item.GetTop() > y)
                return item.GetVerticallyShifted(y - item.GetTop());

            return item;
        }

        static public RectI2 GetConstrainedAboveY(this RectI2 item, int y)
        {
            if (item.GetBottom() < y)
                return item.GetVerticallyShifted(y - item.GetBottom());

            return item;
        }

        static public bool TryGetConstrainedBy(this RectI2 item, RectI2 bounds, out RectI2 output)
        {
            output = item.GetConstrainedAboveX(bounds.GetLeft())
                .GetConstrainedBelowX(bounds.GetRight())
                .GetConstrainedAboveY(bounds.GetBottom())
                .GetConstrainedBelowY(bounds.GetTop());

            if (bounds.FullyContains(output))
                return true;

            return false;
        }

        static public RectI2 GetConstrainedByOrShrunk(this RectI2 item, RectI2 bounds)
        {
            if (item.TryGetConstrainedBy(bounds, out item))
                return item;

            return bounds.GetIntersection(item);
        }
    }
}