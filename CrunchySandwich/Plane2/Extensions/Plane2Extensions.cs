using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Plane2Extensions
    {
        static public Plane2 CreateNormalAndDistance(Vector2 normal, float distance)
        {
            return new Plane2(normal, -distance);
        }

        static public Plane2 CreateNormalAndPoint(Vector2 normal, Vector2 point)
        {
            normal = normal.GetNormalized();

            return CreateNormalAndDistance(normal, normal.GetDot(point));
        }

        static public Plane2 CreatePoints(Vector2 v0, Vector2 v1)
        {
            return CreateNormalAndPoint((v1 - v0).GetNormal(), v0);
        }

        static public Plane2 CreatePointsAndInsidePoint(Vector2 v0, Vector2 v1, Vector2 inside)
        {
            Plane2 plane = CreatePoints(v0, v1);

            if (plane.IsInside(inside))
                return plane;

            return plane.GetFlipped();
        }
        static public Plane2 CreatePointsAndOutsidePoint(Vector2 v0, Vector2 v1, Vector2 outside)
        {
            return CreatePointsAndInsidePoint(v0, v1, outside).GetFlipped();
        }
    }
}