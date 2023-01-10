using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneSpaceExtensions_Intersect_Plane
    {
        static public bool IsIntersecting(this PlaneSpace item, Plane plane, out Plane2 output)
        {
            Ray ray;

            if (item.plane.IsIntersecting(plane, out ray))
            {
                output = Plane2Extensions.CreatePointsAndInsidePoint(
                    item.DeflatePoint(ray.origin),
                    item.DeflatePoint(ray.origin + ray.direction),
                    item.DeflatePoint(ray.origin - plane.normal)
                );
                return true;
            }

            output = default(Plane2);
            return false;
        }
    }
}