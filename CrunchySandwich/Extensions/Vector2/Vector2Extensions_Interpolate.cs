using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Interpolate
    {
        static public Vector2 GetInterpolate(this Vector2 item, Vector2 target, float amount)
        {
            amount = amount.BindBetween(0.0f, 1.0f);

            return item * (1.0f - amount) + target * amount;
        }

        static public Vector2 GetMidpoint(this Vector2 item, Vector2 target)
        {
            return (item + target) * 0.5f;
        }
    }
}