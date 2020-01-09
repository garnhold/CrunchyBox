using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Split
    {
        static public IEnumerable<Triangle2> SplitAlongEdge01ByPercent(this Triangle2 item, float percent)
        {
            Vector2 vertex = item.GetEdge01().GetPointOnByPercent(percent);

            yield return new Triangle2(item.v0, vertex, item.v2);
            yield return new Triangle2(vertex, item.v1, item.v2);
        }
        static public IEnumerable<Triangle2> SplitAlongEdge12ByPercent(this Triangle2 item, float percent)
        {
            Vector2 vertex = item.GetEdge12().GetPointOnByPercent(percent);

            yield return new Triangle2(item.v0, item.v1, vertex);
            yield return new Triangle2(vertex, item.v2, item.v0);
        }
        static public IEnumerable<Triangle2> SplitAlongEdge20ByPercent(this Triangle2 item, float percent)
        {
            Vector2 vertex = item.GetEdge20().GetPointOnByPercent(percent);

            yield return new Triangle2(item.v0, item.v1, vertex);
            yield return new Triangle2(vertex, item.v1, item.v2);
        }

        static public IEnumerable<Triangle2> SplitAlongEdgeByPercent(this Triangle2 item, float percent)
        {
            percent = percent.GetLooped(3.0f);

            if (percent < 1.0f)
                return item.SplitAlongEdge01ByPercent(percent);

            if (percent < 2.0f)
                return item.SplitAlongEdge12ByPercent(percent - 1.0f);

            return item.SplitAlongEdge20ByPercent(percent - 2.0f);
        }

        static public IEnumerable<Triangle2> RecursiveSplitAlongEdgeByArea(this Triangle2 item, float p, float min_area, int max_recursions)
        {
            if (item.GetArea() > min_area && max_recursions >= 1)
                return item.SplitAlongEdge01ByPercent(p).Convert(t => t.RecursiveSplitAlongEdgeByArea(p, min_area, max_recursions - 1));

            return item.WrapAsEnumerable();
        }

        static public IEnumerable<Triangle2> RecursiveSplitSpiralAlongEdgeByArea(this Triangle2 item, float p, float dp, float min_area, int max_recursions)
        {
            if (item.GetArea() > min_area && max_recursions >= 1)
                return item.SplitAlongEdgeByPercent(p).Convert(t => t.RecursiveSplitSpiralAlongEdgeByArea(p + dp, dp, min_area, max_recursions - 1));

            return item.WrapAsEnumerable();
        }
    }
}