using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Plane2Extensions_Origin
    {
        static public Vector2 GetOrigin(this Plane2 item)
        {
            return item.normal * -item.distance;
        }
    }
}