using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Planar_Orient
    {
        static public void OrientPlanarLocalToWorld(this Transform item, Vector2 l1, Vector2 l2, Vector2 w1, Vector2 w2)
        {
            Vector2 src1 = item.TransformPoint(l1);
            Vector2 src2 = item.TransformPoint(l2);

            item.AdjustPlanarPosition(w1 - src1);

            float from_distance = src1.GetDistanceTo(src2);
            float to_distance = w1.GetDistanceTo(w2);

            item.ScalePlanarScale(to_distance / from_distance);

            float from_angle = (src2 - src1).GetAngleInDegrees();
            float to_angle = (w2 - w1).GetAngleInDegrees();

            item.AdjustPlanarRotation(from_angle.GetDegreeAngleDifference(to_angle));
        }
    }
}