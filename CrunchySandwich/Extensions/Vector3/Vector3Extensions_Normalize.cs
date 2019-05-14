using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Normalize
    {
        static public Vector3 GetNormalized(this Vector3 item)
        {
            return item.normalized;
        }

        static public Vector3 GetNormalized(this Vector3 item, out float magnitude)
        {
            magnitude = item.GetMagnitude();

            if (magnitude != 0.0f)
                return item / magnitude;

            return Vector3.zero;
        }
    }
}