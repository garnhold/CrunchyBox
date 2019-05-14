using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayExtensions_Transform
    {
        static public Ray GetReverse(this Ray item)
        {
            return new Ray(item.origin, -item.direction);
        }
    }
}