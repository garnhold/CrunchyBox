using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Vector3Extensions_Abs
    {
        static public Vector3 GetAbs(this Vector3 item)
        {
            return new Vector3(item.x.GetAbs(), item.y.GetAbs(), item.z.GetAbs());
        }
    }
}