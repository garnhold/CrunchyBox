using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_Boolean
    {
        static public Rect GetEncompassing(this Rect item, Rect rect)
        {
            return RectExtensions.CreateStrictMinMaxRect(
                item.xMin.Min(rect.xMin),
                item.yMin.Min(rect.yMin),

                item.xMax.Max(rect.xMax),
                item.yMax.Max(rect.yMax)
            );
        }

        static public bool TryGetIntersection(this Rect item, Rect rect, out Rect intersection)
        {
            return RectExtensions.TryCreateStrictMinMaxRect(
                item.xMin.Max(rect.xMin),
                item.yMin.Max(rect.yMin),

                item.xMax.Min(rect.xMax),
                item.yMax.Min(rect.yMax),
                out intersection
            );
        }
        static public Rect GetIntersection(this Rect item, Rect rect)
        {
            Rect intersection;

            item.TryGetIntersection(rect, out intersection);
            return intersection;
        }

        static public IEnumerable<Rect> GetSubtraction(this Rect item, Rect to_subtract)
        {
            if (item.TryGetIntersection(to_subtract, out to_subtract) == false)
                yield return new Rect(item);
            else
            {
                Rect left;
                if (RectExtensions.TryCreateStrictMinMaxRect(
                    item.xMin, to_subtract.yMin,
                    to_subtract.xMin, to_subtract.yMax,
                    out left
                )) yield return left;

                Rect right;
                if (RectExtensions.TryCreateStrictMinMaxRect(
                    to_subtract.xMax, to_subtract.yMin,
                    item.xMax, to_subtract.yMax,
                    out right
                )) yield return right;

                Rect bottom;
                if (RectExtensions.TryCreateStrictMinMaxRect(
                    item.xMin, item.yMin,
                    item.xMax, to_subtract.yMin,
                    out bottom
                )) yield return bottom;

                Rect top;
                if (RectExtensions.TryCreateStrictMinMaxRect(
                    item.xMin, to_subtract.yMax,
                    item.xMax, item.yMax,
                    out top
                )) yield return top;
            }
        }
    }
}