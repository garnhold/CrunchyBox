using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector3Extensions_Interpolate
    {
        static public Vector3 GetInterpolate(this Vector3 item, Vector3 target, float amount)
        {
            amount = amount.BindPercent();

            return item * (1.0f - amount) + target * amount;
        }

        static public Vector3 GetMidpoint(this Vector3 item, Vector3 target)
        {
            return (item + target) * 0.5f;
        }

        static public Vector3 GetDirectionInterpolate(this Vector3 item, Vector3 target, float amount)
        {
            return Quaternion.Lerp(
                Quaternion.LookRotation(item),
                Quaternion.LookRotation(target),
                amount
            ) * Vector3.forward;
        }
    }
}