using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class QuaternionExtensions_Interpolate
    {
        static public Quaternion GetInterpolate(this Quaternion item, Quaternion target, float amount)
        {
            return Quaternion.Lerp(item, target, amount);
        }
    }
}