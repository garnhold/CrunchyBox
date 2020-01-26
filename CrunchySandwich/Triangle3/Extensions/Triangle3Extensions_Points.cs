using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Triangle3Extensions_Points
    {
        static public IEnumerable<Vector3> GetPoints(this Triangle3 item)
        {
            yield return item.v0;
            yield return item.v1;
            yield return item.v2;
        }

        static public Vector3 GetCenter(this Triangle3 item)
        {
            return item.GetPoints().Average();
        }

        static public Vector3 GetPointOnEdgeByPercent(this Triangle3 item, float percent)
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