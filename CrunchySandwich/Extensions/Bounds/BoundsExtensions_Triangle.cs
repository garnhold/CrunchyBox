using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class BoundsExtensions_Triangle
    {
        static public bool FullyContains(this Bounds item, Triangle3 triangle)
        {
            if (
                item.Contains(triangle.v0) &&
                item.Contains(triangle.v1) &&
                item.Contains(triangle.v2)
            )
            {
                return true;
            }

            return false;
        }
    }
}