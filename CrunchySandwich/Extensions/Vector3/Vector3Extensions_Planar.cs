using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Planar
    {
        static public Vector2 GetPlanar(this Vector3 item)
        {
            return new Vector2(item.x, item.y);
        }
    }
}