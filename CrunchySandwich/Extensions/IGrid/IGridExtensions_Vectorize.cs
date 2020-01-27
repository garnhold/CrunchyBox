using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class IGridExtensions_Vectorize
    {
        static public IEnumerable<List<Vector2>> Vectorize(this IGrid<bool> item, int maximum_gap, float scale, Vector2 offset)
        {
            return item.TraverseEdges(maximum_gap).Convert(
                p => p.Convert(c => c.GetVector2() * scale + offset).ToList()
            );
        }
    }
}