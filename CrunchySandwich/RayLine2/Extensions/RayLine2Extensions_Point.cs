using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLine2Extensions_Point
    {
        static public Vector2 GetPointAlong(this RayLine2 item, float distance)
        {
            return item.GetRay().GetPointAlong(distance.BindBelow(item.GetLength()));
        }
    }
}