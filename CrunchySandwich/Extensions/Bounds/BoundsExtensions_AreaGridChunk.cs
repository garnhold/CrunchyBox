using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_AreaGridChunk
    {
        static public Bounds GetOverflownAreaGridChunk(this Bounds item, int x, int y, Vector2 cell_size)
        {
            Vector2 point1 = item.min.GetArear() + new Vector2(x, y).GetComponentMultiply(cell_size);
            Vector2 point2 = point1 + cell_size;

            return BoundsExtensions.CreateMinMaxAreaBounds(point1, point2, item.size.y, item.min.y);
        }
    }
}