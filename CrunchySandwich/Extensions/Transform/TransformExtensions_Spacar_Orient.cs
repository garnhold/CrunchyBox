using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_Spacar_Orient
    {
        static public void OrientSpacarLocalToWorld(this Transform item, Vector3 l1, Vector3 l2, Vector3 l3, Vector3 w1, Vector3 w2, Vector3 w3)
        {
            Vector3 src1 = item.TransformPoint(l1);
            Vector3 src2 = item.TransformPoint(l2);
            Vector3 src3 = item.TransformPoint(l3);

            item.AdjustSpacarPosition(w1 - src1);

            Vector3 from_up = src1.GetNormal(src2, src3);
            Vector3 to_up = w1.GetNormal(w2, w3);

            item.AdjustSpacarQuaternion(Quaternion.FromToRotation(from_up, to_up));

            float from_distance = src1.GetDistanceTo(src2);
            float to_distance = w1.GetDistanceTo(w2);

            item.ScaleSpacarScale(to_distance / from_distance);
        }
    }
}