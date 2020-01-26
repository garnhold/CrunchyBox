using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_BindMagnitude
    {
        static public Vector3 BindMagnitudeAbove(this Vector3 item, float lower)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindAbove(lower);
        }

        static public Vector3 BindMagnitudeBelow(this Vector3 item, float upper)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBelow(upper);
        }

        static public Vector3 BindMagnitudeBetween(this Vector3 item, float value1, float value2)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBetween(value1, value2);
        }
    }
}