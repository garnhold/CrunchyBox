using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLineExtensions_Point
    {
        static public Vector3 GetPointAlong(this RayLine item, float distance)
        {
            return item.GetRay().GetPointAlong(distance.BindBelow(item.GetLength()));
        }
    }
}