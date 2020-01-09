using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector3Extensions_Interpolate
    {
        static public Vector3 GetInterpolate(this Vector3 item, Vector3 target, float amount)
        {
            amount = amount.BindBetween(0.0f, 1.0f);

            return item * (1.0f - amount) + target * amount;
        }

        static public Vector3 GetMidpoint(this Vector3 item, Vector3 target)
        {
            return (item + target) * 0.5f;
        }
    }
}