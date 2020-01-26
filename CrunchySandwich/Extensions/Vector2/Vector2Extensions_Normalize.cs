using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Normalize
    {
        static public Vector2 GetNormalized(this Vector2 item)
        {
            return item.normalized;
        }

        static public Vector2 GetNormalized(this Vector2 item, out float magnitude)
        {
            magnitude = item.GetMagnitude();

            if(magnitude != 0.0f)
                return item / magnitude;

            return Vector2.zero;
        }
    }
}