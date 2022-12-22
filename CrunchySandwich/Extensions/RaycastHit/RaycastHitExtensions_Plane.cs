using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class RaycastHitExtensions_Plane
    {
        static public Plane GetPlane(this RaycastHit item)
        {
            return PlaneExtensions.CreateNormalAndPoint(item.normal, item.point);
        }
    }
}