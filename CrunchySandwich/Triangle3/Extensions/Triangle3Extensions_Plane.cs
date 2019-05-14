using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Plane
    {
        static public Plane GetPlane(this Triangle3 item)
        {
            return PlaneExtensions.CreatePoints(item.v0, item.v1, item.v2);
        }
    }
}