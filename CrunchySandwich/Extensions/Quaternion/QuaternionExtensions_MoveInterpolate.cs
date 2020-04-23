using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class QuaternionExtensions_MoveInterpolate
    {
        static public bool GetMoveInterpolate(this Quaternion item, Quaternion target, float amount, out Quaternion output, float tolerance = 1e-2f)
        {
            output = item.GetInterpolate(target, amount);

            if (Quaternion.Angle(target, output) <= tolerance)
                return true;

            return false;
        }
    }
}