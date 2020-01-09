using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_IEnumerable_Area
    {
        static public float GetLoopShoelaceArea(this IEnumerable<Vector2> item)
        {
            return item.CloseLoop().ConvertConnections((v0, v1) => v0.x*v1.y - v1.x*v0.y).Sum() * 0.5f;
        }

        static public float GetLoopArea(this IEnumerable<Vector2> item)
        {
            return item.GetLoopShoelaceArea().GetAbs();
        }
    }
}