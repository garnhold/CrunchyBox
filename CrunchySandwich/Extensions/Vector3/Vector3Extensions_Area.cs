using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Area
    {
        static public Vector2 GetArear(this Vector3 item)
        {
            return new Vector2(item.x, item.z);
        }
    }
}