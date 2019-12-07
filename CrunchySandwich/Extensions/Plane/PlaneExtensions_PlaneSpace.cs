using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_PlaneSpace
    {
        static public PlaneSpace GetPlaneSpace(this Plane item)
        {
            return new PlaneSpace(item);
        }
    }
}