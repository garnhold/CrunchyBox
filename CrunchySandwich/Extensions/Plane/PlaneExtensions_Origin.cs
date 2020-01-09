using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Origin
    {
        static public Vector3 GetOrigin(this Plane item)
        {
            return item.normal * -item.distance;
        }
    }
}