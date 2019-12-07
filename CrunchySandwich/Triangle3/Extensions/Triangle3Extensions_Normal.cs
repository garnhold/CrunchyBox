using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class Triangle3Extensions_Normal
    {
        static public Vector3 GetNormal(this Triangle3 item)
        {
            return item.v0.GetNormalizedNormal(item.v1, item.v2);
        }
    }
}