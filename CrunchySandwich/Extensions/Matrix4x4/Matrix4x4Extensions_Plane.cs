using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Matrix4x4Extensions_Plane
    {
        static public Plane MultiplyPlane(this Matrix4x4 item, Plane plane)
        {
            return PlaneExtensions.CreateNormalAndPoint(
                item.MultiplyVector(plane.normal),
                item.MultiplyPoint(plane.GetOrigin())
            );
        }
    }
}