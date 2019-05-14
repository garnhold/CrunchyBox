using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Interpolate
    {
        static public VectorF2 GetInterpolate(this VectorF2 item, VectorF2 target, float amount)
        {
            amount = amount.BindBetween(0.0f, 1.0f);

            return item * (1.0f - amount) + target * amount;
        }

        static public VectorF2 GetMidpoint(this VectorF2 item, VectorF2 target)
        {
            return (item + target) * 0.5f;
        }
    }
}