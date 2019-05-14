using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Normal
    {
        static public Vector3 GetNormal(this Triangle3 item)
        {
            return (item.v1 - item.v0).GetCross(item.v2 - item.v0).GetNormalized();
        }
    }
}