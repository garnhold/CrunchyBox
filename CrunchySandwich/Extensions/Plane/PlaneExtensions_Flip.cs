using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Flip
    {
        static public Plane GetFlipped(this Plane item)
        {
            return PlaneExtensions.CreateNormalAndPoint(-item.normal, item.GetOrigin());
        }
    }
}