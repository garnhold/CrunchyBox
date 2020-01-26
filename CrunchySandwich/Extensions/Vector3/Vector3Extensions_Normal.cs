using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Normal
    {
        static public Vector3 GetNormal(this Vector3 v0, Vector3 v1, Vector3 v2)
        {
            return (v1 - v0).GetCross(v2 - v1);
        }
        static public Vector3 GetNormalizedNormal(this Vector3 v0, Vector3 v1, Vector3 v2)
        {
            return v0.GetNormal(v1, v2).GetNormalized();
        }
    }
}