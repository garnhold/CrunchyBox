using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_RelativePoint
    {
        static public RelativePoint CreateRelativePointFromLocalPoint(this Transform item, Vector3 local_point)
        {
            return RelativePoint.FromLocalPoint(item, local_point);
        }

        static public RelativePoint CreateRelativePointFromWorldPoint(this Transform item, Vector3 world_point)
        {
            return RelativePoint.FromWorldPoint(item, world_point);
        }
    }
}