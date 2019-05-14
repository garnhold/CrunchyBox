using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Plane
    {
        static public bool IntersectsPlane(this Face item, Plane2 plane, out float distance)
        {
            return plane.IntersectRayLine(item.GetFaceRayLine(), out distance);
        }

        static public bool IntersectsPlane(this Face item, Plane2 plane, out Vector2 point)
        {
            return plane.IntersectRayLine(item.GetFaceRayLine(), out point);
        }
    }
}