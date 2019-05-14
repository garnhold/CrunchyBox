using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Abs
    {
        static public Vector3 GetAbs(this Vector3 item)
        {
            return new Vector3(item.x.GetAbs(), item.y.GetAbs(), item.z.GetAbs());
        }
    }
}