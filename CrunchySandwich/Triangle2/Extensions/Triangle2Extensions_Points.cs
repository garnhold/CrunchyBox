using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Points
    {
        static public IEnumerable<Vector2> GetPoints(this Triangle2 item)
        {
            yield return item.v0;
            yield return item.v1;
            yield return item.v2;
        }

        static public Vector2 GetCenter(this Triangle2 item)
        {
            return item.GetPoints().Average();
        }

        static public Vector2 GetPointOnEdgeByPercent(this Triangle2 item, float percent)
        {
            percent = percent.GetLooped(3.0f);

            if (percent < 1.0f)
                return item.GetEdge01().GetPointOnByPercent(percent);

            if (percent < 2.0f)
                return item.GetEdge12().GetPointOnByPercent(percent - 1.0f);

            return item.GetEdge20().GetPointOnByPercent(percent - 2.0f);
        }

        
    }
}