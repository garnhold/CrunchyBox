using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector3Extensions_MoveInterpolate
    {
        static public bool GetMoveInterpolate(this Vector3 item, Vector3 target, float amount, out Vector3 output, float tolerance = 1e-2f)
        {
            output = item.GetInterpolate(target, amount);

            if (output.IsWithinDistance(target, tolerance))
                return true;

            return false;
        }

        static public bool GetDirectionMoveInterpolate(this Vector3 item, Vector3 target, float amount, out Vector3 output, float tolerance = 1e-2f)
        {
            output = item.GetDirectionInterpolate(target, amount);

            if (output.IsWithinDistance(target, tolerance))
                return true;

            return false;
        }
    }
}