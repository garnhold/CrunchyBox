using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_Point
    {
        static public Vector3 GetPointAlong(this Ray item, float distance)
        {
            return item.origin + item.direction * distance;
        }
    }
}