using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Intersect_Plane
    {
        static public bool IsIntersecting(this Plane item, Plane plane, out Ray output)
        {
            Vector3 point;

            if (plane.IsIntersectingLine(new Ray(item.GetOrigin(), item.ProjectVector(plane.normal)), out point))
            {
                output = new Ray(point, item.normal.GetCross(plane.normal));
                return true;
            }

            output = default(Ray);
            return false;
        }
    }
}