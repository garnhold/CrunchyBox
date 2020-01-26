using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_Intersect_Plane
    {
        static public bool IsIntersecting(this Face item, Plane2 plane, out float distance)
        {
            return plane.IsIntersecting(item.GetLineSegment(), out distance);
        }

        static public bool IsIntersecting(this Face item, Plane2 plane, out Vector2 point)
        {
            return plane.IsIntersecting(item.GetLineSegment(), out point);
        }
    }
}