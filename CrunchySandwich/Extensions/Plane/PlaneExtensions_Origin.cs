using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Origin
    {
        static public Vector3 GetOrigin(this Plane item)
        {
            return item.normal * -item.distance;
        }
    }
}