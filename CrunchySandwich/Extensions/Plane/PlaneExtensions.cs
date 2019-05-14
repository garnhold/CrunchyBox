using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions
    {
        static public Plane CreateNormalAndDistance(Vector3 normal, float distance)
        {
            return new Plane(normal, -distance);
        }

        static public Plane CreateNormalAndPoint(Vector3 normal, Vector3 point)
        {
            normal = normal.GetNormalized();

            return CreateNormalAndDistance(normal, normal.GetDot(point));
        }

        static public Plane CreatePoints(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            return CreateNormalAndPoint((v1 - v0).GetCross(v2 - v1), v0);
        }

        static public Plane CreatePointsAndInsidePoint(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 inside)
        {
            Plane plane = CreatePoints(v0, v1, v2);

            if (plane.IsInside(inside))
                return plane;

            return plane.GetFlipped();
        }
        static public Plane CreatePointsAndOutsidePoint(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 outside)
        {
            return CreatePointsAndInsidePoint(v0, v1, v2, outside).GetFlipped();
        }
    }
}