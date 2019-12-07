using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class RayExtensions_Transform
    {
        static public Ray GetReverse(this Ray item)
        {
            return new Ray(item.origin, -item.direction);
        }
    }
}