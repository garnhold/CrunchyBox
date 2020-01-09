using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Magnitude
    {
        static public float GetMagnitude(this Vector2 item)
        {
            return item.magnitude;
        }

        static public float GetSquaredMagnitude(this Vector2 item)
        {
            return item.sqrMagnitude;
        }
    }
}