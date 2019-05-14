using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_General
    {
        static public bool IntersectsGeneralBi(this Ray item, Vector3 point, Vector3 normal, out float distance)
        {
            float ray_normal_length = -normal.GetDot(item.direction);
            float normal_distance = normal.GetDot(item.origin - point);

            distance = normal_distance / ray_normal_length;
            if (distance > float.MinValue && distance < float.MaxValue)
                return true;

            return false;
        }
    }
}