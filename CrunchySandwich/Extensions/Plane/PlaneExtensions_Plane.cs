using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Plane
    {
        static public bool IntersectsPlane(this Plane item, Plane plane, out Ray ray)
        {
            Vector3 point;

            if (plane.IntersectBiRay(new Ray(item.GetOrigin(), item.ProjectVector(plane.normal)), out point))
            {
                ray = new Ray(point, item.normal.GetCross(plane.normal));
                return true;
            }

            ray = default(Ray);
            return false;
        }
    }
}