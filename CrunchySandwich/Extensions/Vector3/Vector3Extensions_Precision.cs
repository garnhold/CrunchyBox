using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Vector3Extensions_Precision
    {
        static public Vector3 GetAtPrecision(this Vector3 item, int exponent)
        {
            return new Vector3(
                item.x.GetAtPrecision(exponent),
                item.y.GetAtPrecision(exponent),
                item.z.GetAtPrecision(exponent)
            );
        }
    }
}