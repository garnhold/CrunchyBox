using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneSpaceExtensions_Intersect
    {
        static public bool IntersectPlane(this PlaneSpace item, Plane plane, out Plane2 output)
        {
            Ray ray;

            if (item.plane.IntersectsPlane(plane, out ray))
            {
                output = Plane2Extensions.CreatePointsAndInsidePoint(
                    item.ProjectPoint(ray.origin),
                    item.ProjectPoint(ray.origin + ray.direction),
                    item.ProjectPoint(ray.origin - plane.normal)
                );
                return true;
            }

            output = default(Plane2);
            return false;
        }
    }
}