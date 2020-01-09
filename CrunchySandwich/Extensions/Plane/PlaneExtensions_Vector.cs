using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Vector
    {
        static public Vector3 ProjectVector(this Plane item, Vector3 vector)
        {
            return vector - item.normal.GetDot(vector) * item.normal;
        }
    }
}