using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Area
    {
        static public Vector3 GetArear(this Vector2 item, float y)
        {
            return new Vector3(item.x, y, item.y);
        }

        static public Vector3 GetArear(this Vector2 item)
        {
            return item.GetArear(0.0f);
        }
    }
}