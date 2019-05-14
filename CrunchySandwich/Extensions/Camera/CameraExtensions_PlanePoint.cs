using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_PlanePoint
    {
        static private readonly Plane PLANAR_WORLD_PLANE = PlaneExtensions.CreateNormalAndDistance(new Vector3(0.0f, 0.0f, 1.0f), -0.1f);
        static private readonly Plane AREA_WORLD_PLANE = PlaneExtensions.CreateNormalAndDistance(new Vector3(0.0f, 1.0f, 0.0f), -0.1f);

        static public Vector3 ScreenToWorldPlanePoint(this Camera item, Plane plane, Vector2 point)
        {
            return plane.IntersectRay(item.ScreenPointToRay(point));
        }

        static public Vector2 ScreenToWorldPlanarPoint(this Camera item, Vector2 point)
        {
            if (item.orthographic)
                return item.ScreenToWorldPoint(point);

            return item.ScreenToWorldPlanePoint(PLANAR_WORLD_PLANE, point);
        }

        static public Vector3 ScreenToWorldAreaPoint(this Camera item, Vector2 point)
        {
            return item.ScreenToWorldPlanePoint(AREA_WORLD_PLANE, point);
        }
    }
}