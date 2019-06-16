using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_Intersect_Line
    {
        static public bool IsIntersectingLine(this Ray item, Vector3 point, Vector3 normal, out float offset)
        {
            float ray_normal_length = -normal.GetDot(item.direction);
            float normal_distance = normal.GetDot(item.origin - point);

            offset = normal_distance / ray_normal_length;
            if (offset > float.MinValue && offset < float.MaxValue)
                return true;

            return false;
        }
    }
}