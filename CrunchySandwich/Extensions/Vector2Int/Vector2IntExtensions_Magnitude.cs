using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2IntExtensions_Magnitude
    {
        static public float GetMagnitude(this Vector2Int item)
        {
            return item.magnitude;
        }

        static public int GetSquaredMagnitude(this Vector2Int item)
        {
            return item.sqrMagnitude;
        }
    }
}