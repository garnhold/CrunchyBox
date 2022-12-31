using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Points
    {
        static public IEnumerable<Vector2> GetPoints(this Quad2 item)
        {
            yield return item.v0;
            yield return item.v1;
            yield return item.v2;
            yield return item.v3;
        }

        static public Vector2 GetCenter(this Quad2 item)
        {
            return item.GetPoints().Average();
        }

        static public Vector2 GetPointOnEdgeByPercent(this Quad2 item, float percent)
        {
            percent = percent.GetLooped(4.0f);

            if (percent < 1.0f)
                return item.GetEdge01().GetPointOnByPercent(percent);

            if (percent < 2.0f)
                return item.GetEdge12().GetPointOnByPercent(percent - 1.0f);

            if (percent < 3.0f)
                return item.GetEdge23().GetPointOnByPercent(percent - 2.0f);

            return item.GetEdge30().GetPointOnByPercent(percent - 3.0f);
        }

        
    }
}