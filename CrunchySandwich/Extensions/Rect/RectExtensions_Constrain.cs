using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class RectExtensions_Constrain
    {
        static public Rect GetConstrainedBelowX(this Rect item, float x)
        {
            if (item.xMax > x)
                item.x -= item.xMax - x;

            return item;
        }

        static public Rect GetConstrainedAboveX(this Rect item, float x)
        {
            if (item.xMin < x)
                item.x += x - item.xMin;

            return item;
        }

        static public Rect GetConstrainedBelowY(this Rect item, float y)
        {
            if (item.yMax > y)
                item.y -= item.yMax - y;

            return item;
        }

        static public Rect GetConstrainedAboveY(this Rect item, float y)
        {
            if (item.yMin < y)
                item.y += y - item.yMin;

            return item;
        }

        static public bool TryGetConstrainedBy(this Rect item, Rect bounds, out Rect output)
        {
            output = item.GetConstrainedAboveX(bounds.xMin)
                .GetConstrainedBelowX(bounds.xMax)
                .GetConstrainedAboveY(bounds.yMin)
                .GetConstrainedBelowY(bounds.yMax);

            if (bounds.FullyContains(output))
                return true;

            return false;
        }

        static public Rect GetConstrainedByOrShrunk(this Rect item, Rect bounds)
        {
            if (item.TryGetConstrainedBy(bounds, out item))
                return item;

            return bounds.GetIntersection(item);
        }
    }
}