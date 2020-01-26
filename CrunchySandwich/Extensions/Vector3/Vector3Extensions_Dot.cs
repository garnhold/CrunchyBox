using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Dot
    {
        static public float GetDot(this Vector3 item, Vector3 other)
        {
            return Vector3.Dot(item, other);
        }
    }
}